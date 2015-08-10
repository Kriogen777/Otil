using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Timers;
using System.Linq;

namespace AIOSystemUtility3
{
    class NetworkScraper : Scraper
    {
        //Properties
        public List<NetworkAdapter> NetworkAdapters { get; set; }
        private List<int> Indices = new List<int>();

        private static NetworkScraper instance = null;
        public static NetworkScraper GetInstance()
        {
            if (instance == null)
            {
                instance = new NetworkScraper();
            }
            return instance;
        }

        private NetworkScraper()
            : base()
        {
            Update.Elapsed += Update_Elapsed2;
            NetworkAdapters = new List<NetworkAdapter>();
        }

        protected void Update_Elapsed2(object sender, ElapsedEventArgs e)
        {
            Lock.WaitOne();
            if (!IsFirstScanComplete)
            {
                IsFirstScanComplete = true;
            } // End static properties

            if (NetworkAdapters.Count == 0)
            {
                // Adapters
                searcher = new ManagementObjectSearcher("select * from Win32_NetworkAdapter");
                // Scrape & Update
                foreach (ManagementObject share in searcher.Get())
                {
                    if (!Indices.Contains((int)(uint)share["Index"]))
                    {
                        NetworkAdapter adapter = new NetworkAdapter();
                        adapter.AdapterType = (string)share["AdapterType"];
                        adapter.Name = (string)share["Name"];
                        adapter.Index = (int)(uint)share["Index"];
                        adapter.MACAddress = (string)share["MACAddress"];
                        adapter.Manufacturer = (string)share["Manufacturer"];
                        adapter.NetConnectionID = (string)share["NetConnectionID"];
                        adapter.PhysicalAdapter = (bool)share["PhysicalAdapter"];
                        if (adapter.PhysicalAdapter && ((string)share["PNPDeviceID"]).StartsWith("ROOT"))
                        {
                            adapter.PhysicalAdapter = false;
                        }

                        if (share["Speed"] != null)
                            adapter.Speed = (long)(ulong)share["Speed"];
                        if (adapter.PhysicalAdapter)
                        {
                            string instanceName = adapter.Name.Replace('(', '[');
                            instanceName = instanceName.Replace(')', ']');
                            instanceName = instanceName.Replace('#', '_');
                            instanceName = instanceName.Replace('\\', '_');
                            instanceName = instanceName.Replace('/', '_');
                            PerformanceCounterCategory category = new PerformanceCounterCategory("Network Interface");
                            instanceName = category.GetInstanceNames().Where(x => x.Contains(instanceName)).FirstOrDefault();

                            if (instanceName != null)
                            {
                                adapter.PerformanceCounterSent = new PerformanceCounter("Network Interface", "Bytes Sent/sec", instanceName);
                                adapter.PerformanceCounterReceived = new PerformanceCounter("Network Interface", "Bytes Received/sec", instanceName);
                            }
                        }
                        adapter.KBSSent = "0 Kb/s";
                        adapter.KBSRecieved = "0 Kb/s";

                        using (ManagementObject Mo = new ManagementObject("Win32_NetworkAdapterConfiguration.Index=" + adapter.Index))
                        {
                            if (Mo["DefaultIPGateway"] != null)
                                adapter.DefaultIPGateway = ((string[])Mo["DefaultIPGateway"])[0];
                            adapter.DHCPEnabled = (bool)Mo["DHCPEnabled"];
                            if (Mo["IPAddress"] != null)
                            {
                                string[] compositeIP = (string[])Mo["IPAddress"];
                                adapter.IPv4Address = compositeIP[0];
                                adapter.IPv6Address = compositeIP[1];
                            }
                            if (Mo["IPSubnet"] != null)
                            {
                                string[] subnet = (string[])Mo["IPSubnet"];
                                adapter.IPSubnet = subnet[0];
                            }
                        }
                        Indices.Add(adapter.Index);
                        NetworkAdapters.Add(adapter);
                    }
                } // End outer management loop
            }
            else
            {
                foreach (NetworkAdapter adapter in NetworkAdapters)
                {
                    try
                    {
                        if (adapter.PhysicalAdapter)
                        {
                            if (adapter.PerformanceCounterSent != null && adapter.PerformanceCounterReceived != null)
                            {
                                adapter.KBSSentFloat = (adapter.PerformanceCounterSent.NextValue() / 1024);
                                adapter.KBSSent = adapter.KBSSentFloat + " Kb/s";
                                adapter.KBSRecievedFloat = (adapter.PerformanceCounterReceived.NextValue() / 1024);
                                adapter.KBSRecieved = adapter.KBSRecievedFloat + " Kb/s";
                            }
                            
                            using (ManagementObject Mo = new ManagementObject("Win32_NetworkAdapterConfiguration.Index=" + adapter.Index))
                            {
                                if (Mo["DefaultIPGateway"] != null)
                                    adapter.DefaultIPGateway = ((string[])Mo["DefaultIPGateway"])[0];
                                adapter.DHCPEnabled = (bool)Mo["DHCPEnabled"];
                                if (Mo["IPAddress"] != null)
                                {
                                    string[] compositeIP = (string[])Mo["IPAddress"];
                                    adapter.IPv4Address = compositeIP[0];
                                    adapter.IPv6Address = compositeIP[1];
                                }
                                if (Mo["IPSubnet"] != null)
                                {
                                    string[] subnet = (string[])Mo["IPSubnet"];
                                    adapter.IPSubnet = subnet[0];
                                }
                            }
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine("Operation Not Supported For: " + adapter.Name + "(" + adapter.AdapterType + ")");
                        Console.WriteLine(ex);
                    }
                }
            }
            Lock.Release();
            Update.Start();
        }
    }
}
