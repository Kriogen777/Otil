using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Management;
using System.Timers;

namespace AIOSystemUtility3
{
    class HDDScraper : Scraper
    {
        public List<HardDiskDrive> HardDrives { get; private set; }

        private static HDDScraper instance = null;
        public static HDDScraper GetInstance()
        {
            if (instance == null)
            {
                instance = new HDDScraper();
            }
            return instance;
        }

        private HDDScraper()
            : base()
        {
            Update.Elapsed += Update_Elapsed2;
            HardDrives = new List<HardDiskDrive>();
            //computerHardware.Open();
            computerHardware.HDDEnabled = true;
        }

        protected void Update_Elapsed2(object sender, ElapsedEventArgs e)
        {
            Lock.WaitOne();
            // HARD DISK DRIVES
            searcher = new ManagementObjectSearcher("select * from Win32_DiskDrive");
            if (!IsFirstScanComplete || searcher.Get().Count != HardDrives.Count)
            {
                computerHardware.Open();
                IsFirstScanComplete = true;
                // Get HDDs then per HDD store list of partition IDs as ints, then per partition, add to a HDD

                // Clear potentiall populated HDD list
                HardDrives.Clear();
                // Scrape & Update
                foreach (ManagementObject share in searcher.Get())
                {
                    HardDiskDrive hdd = new HardDiskDrive();
                    hdd.HWName = (string)share["Caption"];
                    hdd.Index = (int)(uint)share["Index"];
                    if (share["Size"] != null)
                        hdd.Capacity = ((double)(ulong)share["Size"]) / (1024 * 1024 * 1024); // In Gb
                    HardDrives.Add(hdd);
                } // End outer management loop

                // LOGICAL DISK TO PARTITION
                searcher = new ManagementObjectSearcher("select * from Win32_LogicalDiskToPartition");
                // Scrape & Update
                foreach (ManagementObject share in searcher.Get())
                {
                    HardDiskDrive hdd = null; // To be set later

                    string antecedent = (string)share["Antecedent"];
                    int hash = antecedent.IndexOf('#');
                    int comma = antecedent.IndexOf(',');
                    try
                    {
                        int hddIndex = Convert.ToInt32(antecedent.Substring(hash + 1, comma - hash - 1));
                        foreach (HardDiskDrive hddStored in HardDrives)
                        {
                            if (hddStored.Index == hddIndex)
                            {
                                hdd = hddStored; // Set the selected drive to add a partition to
                                break;
                            }
                        }
                    }
                    catch (System.FormatException ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                    }

                    string dependent = (string)share["Dependent"];
                    int ivCommas = dependent.IndexOf('"');
                    dependent = dependent.Substring(ivCommas + 1, dependent.Length - ivCommas - 2);
                    if (hdd != null)
                    {
                        hdd.PartitionDeviceIDs.Add(dependent);
                    }
                } // End outer management loop

                // LOGICAL DISK
                searcher = new ManagementObjectSearcher("select * from Win32_LogicalDisk");
                string systemPartition = Environment.ExpandEnvironmentVariables("%SystemDrive%");
                // Scrape & Update
                foreach (ManagementObject share in searcher.Get())
                {
                    HardDiskDrive hdd = null; // To be set later

                    string partitionDeviceID = (string)share.Properties["DeviceID"].Value;
                    bool found = false;
                    foreach (HardDiskDrive hddStored in HardDrives)
                    {
                        if (found == false)
                        {
                            foreach (string partitionID in hddStored.PartitionDeviceIDs)
                            {
                                if (partitionID.Equals(partitionDeviceID))
                                {
                                    hdd = hddStored;
                                    found = true;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (hdd != null)
                    {
                        Partition partition = new Partition();
                        partition.Name = partitionDeviceID;
                        partition.Capacity = ((double)(ulong)share.Properties["Size"].Value) / (1024 * 1024 * 1024);
                        partition.FreeSpace = ((double)(ulong)share.Properties["FreeSpace"].Value) / (1024 * 1024 * 1024);
                        partition.FileSystem = (string)share.Properties["FileSystem"].Value;
                        partition.VolumeName = (string)share.Properties["VolumeName"].Value;
                        partition.SystemPartition = partitionDeviceID.Equals(systemPartition);
                        partition.VolumeSerialNumber = (string)share.Properties["VolumeSerialNumber"].Value;
                        partition.FoundAndUpdated = false;
                        hdd.addPartition(partition);
                    } // End null check
                } // End outer management loop
            } // End static properties

            // TEMPERATURES
            foreach (var hardware in computerHardware.Hardware)
            {
                hardware.Update();
                string ident = hardware.Identifier.ToString(); // "/hdd/0"
                int slash = ident.LastIndexOf('/');
                try
                {
                    int hddIndex = Convert.ToInt32(ident.Substring(slash + 1, ident.Length - slash - 1));
                    foreach (HardDiskDrive hdd in HardDrives)
                    {
                        if (hdd.Index == hddIndex)
                        {
                            foreach (var sensor in hardware.Sensors)
                            {
                                if (sensor.SensorType == SensorType.Temperature)
                                {
                                    hdd.Temperature = (double)(float)sensor.Value;
                                    break;
                                }
                            }
                            break;
                        }
                    } // End HDD matching check
                }
                catch (System.FormatException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }

            // LOGICAL DISK DYNAMICS
            searcher = new ManagementObjectSearcher("select * from Win32_LogicalDisk");
            bool foundPartition = false;

            foreach (ManagementObject share in searcher.Get())
            {
                string VolumeSerialNumber = (string)share.Properties["VolumeSerialNumber"].Value;
                foreach (HardDiskDrive hddStored in HardDrives)
                {
                    foreach (Partition partition in hddStored.Partitions)
                    {
                        if (partition.VolumeSerialNumber.Equals(VolumeSerialNumber))
                        {
                            partition.Name = (string)share.Properties["DeviceID"].Value;
                            partition.Capacity = ((double)(ulong)share.Properties["Size"].Value) / (1024 * 1024 * 1024);
                            partition.FreeSpace = ((double)(ulong)share.Properties["FreeSpace"].Value) / (1024 * 1024 * 1024);
                            partition.VolumeName = (string)share.Properties["VolumeName"].Value;

                            foundPartition = true;
                            partition.FoundAndUpdated = true;
                            break;
                        }
                    }
                    if (foundPartition) break;
                }

                // New Partition
                if (!foundPartition)
                {
                    HardDiskDrive hdd = null; // To be set later

                    string partitionDeviceID = (string)share.Properties["DeviceID"].Value;
                    bool found = false;
                    foreach (HardDiskDrive hddStored in HardDrives)
                    {
                        if (found == false)
                        {
                            foreach (string partitionID in hddStored.PartitionDeviceIDs)
                            {
                                if (partitionID.Equals(partitionDeviceID))
                                {
                                    hdd = hddStored;
                                    found = true;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (hdd != null)
                    {
                        Partition partition = new Partition();
                        partition.Name = partitionDeviceID;
                        partition.Capacity = ((double)(ulong)share.Properties["Size"].Value) / (1024 * 1024 * 1024);
                        partition.FreeSpace = ((double)(ulong)share.Properties["FreeSpace"].Value) / (1024 * 1024 * 1024);
                        partition.FileSystem = (string)share.Properties["FileSystem"].Value;
                        partition.VolumeName = (string)share.Properties["VolumeName"].Value;
                        partition.SystemPartition = false;
                        partition.VolumeSerialNumber = (string)share.Properties["VolumeSerialNumber"].Value;
                        partition.FoundAndUpdated = true;
                        hdd.addPartition(partition);
                    } // End null check
                }
                foundPartition = false;
            } // End outer management loop

            // Loop through all partitions, if not updated? delete: mark not up to date anymore
            foreach (HardDiskDrive hddStored in HardDrives)
            {
                List<Partition> toDelete = new List<Partition>();
                foreach (Partition partition in hddStored.Partitions)
                {
                    if (partition.FoundAndUpdated)
                    {
                        partition.FoundAndUpdated = false;
                    }
                    else
                    {
                        toDelete.Add(partition);
                    }
                }
                foreach (Partition partition in toDelete)
                {
                    hddStored.Partitions.Remove(partition);
                }
            }

            Lock.Release();
            Update.Start();
        }
    }
}
