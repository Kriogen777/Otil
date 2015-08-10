using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Management;
using System.Timers;

namespace AIOSystemUtility3
{
    class RAMScraper : Scraper
    {
        //Properties
        public List<MemoryModule> MemoryModules { get; private set; }
        //public int SlotsUsed { get; private set; }
        public float TotalCapacity { get; private set; }
        public float TotalAmountInUse { get; private set; }
        public float TotalAmountAvailable { get; private set; }
        public double TotalPercentUtilization { get; private set; }

        // Paging
        public float PageCapacity { get; set; }
        public float PageCapacityRemaining { get; set; }
        public string Commited { get; private set; }
        public float Cached { get; private set; }
        public float PagedPool { get; private set; }
        public float NonPagedPool { get; private set; }

        private static RAMScraper instance = null;
        public static RAMScraper GetInstance()
        {
            if (instance == null)
            {
                instance = new RAMScraper();
            }
            return instance;
        }

        private RAMScraper()
            : base()
        {
            Update.Elapsed += Update_Elapsed2;
            MemoryModules = new List<MemoryModule>();
            //SlotsUsed = 1;
            TotalCapacity = 0;
            TotalAmountInUse = 0;
            TotalAmountAvailable = 0;
            TotalPercentUtilization = 0;
            Commited = "";
            Cached = 0;
            PagedPool = 0;
            NonPagedPool = 0;
            computerHardware.Open();
            computerHardware.RAMEnabled = true;
        }

        protected void Update_Elapsed2(object sender, ElapsedEventArgs e)
        {
            Lock.WaitOne();
            if (!IsFirstScanComplete)
            {
                IsFirstScanComplete = true;
                // Physical Memory
                searcher = new ManagementObjectSearcher("select * from Win32_PhysicalMemory");
                // Scrape & Update
                foreach (ManagementObject share in searcher.Get())
                {
                    MemoryModule temp = new MemoryModule();
                    if (!((string)share["Manufacturer"]).Contains("Manufacturer"))
                    {
                        Utils.Try(() => temp.Manufaturer = (string)share["Manufacturer"]);
                    }
                    if (!((string)share["SerialNumber"]).Contains("SerNum"))
                    {
                        Utils.Try(() => temp.PartNumber = (string)share["SerialNumber"]);
                    }
                    Utils.Try(() => temp.Capacity = (float)(UInt64)share["Capacity"] / (1024 * 1024));
                    TotalCapacity += temp.Capacity; // Get total RAM
                    Utils.Try(() => temp.SetFormFactor((int)(ushort)share["FormFactor"]));
                    Utils.Try(() => temp.Speed = (int)(uint)share["Speed"]);
                    MemoryModules.Add(temp);
                } // End outer management loop
            } // End static properties

            // Scrape Dynamic Info
            foreach (var hardware in computerHardware.Hardware)
            {
                hardware.Update();
                foreach (var sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == SensorType.Load && sensor.Value != null)
                    {
                        TotalPercentUtilization = (double)sensor.Value; // 40.5
                    }
                    else if (sensor.SensorType == SensorType.Data)
                    {
                        if (sensor.Name.Equals("Used Memory") && sensor.Value != null)
                        {
                            TotalAmountInUse = (float)sensor.Value; // 3.2
                        }
                        else if (sensor.Name.Equals("Available Memory") && sensor.Value != null)
                        {
                            TotalAmountAvailable = (float)sensor.Value; // 4.7
                        }
                    }
                }
            }
            // Page File
            searcher = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
            // Scrape & Update
            foreach (ManagementObject share in searcher.Get())
            {
                Utils.Try(() => PageCapacity = (float)(UInt64)share["SizeStoredInPagingFiles"] / 1024);
                Utils.Try(() => PageCapacityRemaining = (float)(UInt64)share["FreeSpaceInPagingFiles"] / 1024);
            }

            // Win32_PerRawData_PerfOS_Memory - Committed, Cached, Pagepool, NonPagepool
            searcher = new ManagementObjectSearcher("select * from Win32_PerfRawData_PerfOS_Memory");
            // Scrape & Update
            double committedGb = 0;
            double commitLimitGb = 0;
            Cached = 0;
            foreach (ManagementObject share in searcher.Get())
            {
                Utils.Try(() => Cached += (float)(UInt64)share["ModifiedPageListBytes"]);
                Utils.Try(() => Cached += (float)(UInt64)share["StandbyCacheCoreBytes"]);
                Utils.Try(() => Cached += (float)(UInt64)share["StandbyCacheNormalPriorityBytes"]);
                Utils.Try(() => Cached += (float)(UInt64)share["StandbyCacheReserveBytes"]);

                Utils.Try(() => committedGb = (double)(UInt64)share["CommittedBytes"] / (1024 * 1024 * 1024));
                Utils.Try(() => commitLimitGb = (double)(UInt64)share["CommitLimit"] / (1024 * 1024 * 1024));
                Utils.Try(() => PagedPool = (float)(UInt64)share["PoolPagedBytes"] / (1024 * 1024));
                Utils.Try(() => NonPagedPool = (float)(UInt64)share["PoolNonpagedBytes"] / (1024 * 1024));
            }
            Commited = committedGb.ToString("#.##") + "/" + commitLimitGb.ToString("#.##") + " Gb";
            Cached /= (1024 * 1024 * 1024); //Gb
            Lock.Release();
            Update.Start();
        }
    }
}
