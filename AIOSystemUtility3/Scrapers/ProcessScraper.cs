using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Management;
using System.Timers;

namespace AIOSystemUtility3
{
    class ProcessScraper : Scraper
    {
        // Properties
        public Hashtable Processes { get; private set; }

        private static ProcessScraper instance = null;
        public static ProcessScraper GetInstance()
        {
            if (instance == null)
            {
                instance = new ProcessScraper();
            }
            return instance;
        }

        private ProcessScraper()
            : base()
        {
            Processes = new Hashtable();
            Update.Elapsed += Update_Elapsed2;
        }

        protected void Update_Elapsed2(object sender, ElapsedEventArgs e)
        {
            Lock.WaitOne();
            if (!IsFirstScanComplete)
                IsFirstScanComplete = true;

            searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PerfFormattedData_PerfProc_Process");
            // Scrape & Update
            foreach (ManagementObject share in searcher.Get())
            {
                int processID = -1;
                Utils.Try(() => processID = (int)(uint)share["IDProcess"]);

                if (!Processes.ContainsKey(processID))
                {
                    // Sanity check
                    if (processID == -1 || ((string)share["Name"]).Equals("_Total") || ((string)share["Name"]).Equals("Idle"))
                    {
                        continue;
                    }
                    Process temp = new Process();
                    Utils.Try(() => temp.Name = (string)share["Name"]);
                    Utils.Try(() => temp.ThreadCount = (int)(uint)share["ThreadCount"]);
                    Utils.Try(() => temp.WorkingSetSize = (long)(ulong)share["WorkingSetPrivate"]);
                    Utils.Try(() => temp.ProcessorUse = (long)(ulong)share["PercentProcessorTime"]);
                    temp.ProcessID = processID.ToString();

                    try
                    {
                        System.Diagnostics.Process processToFetchIcon = System.Diagnostics.Process.GetProcessById(processID);
                        temp.ProcessIcon = Icon.ExtractAssociatedIcon(processToFetchIcon.MainModule.FileName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error fetching icon: " + ex.Message);
                    }

                    temp.CheckedThisUpdate = true;
                    Processes.Add(processID, temp);
                }
                else
                {
                    Process temp = (Process)Processes[processID];
                    Utils.Try(() => temp.ThreadCount = (int)(uint)share["ThreadCount"]);
                    Utils.Try(() => temp.WorkingSetSize = (long)(ulong)share["WorkingSetPrivate"]);
                    Utils.Try(() => temp.ProcessorUse = (long)(ulong)share["PercentProcessorTime"]);
                    temp.CheckedThisUpdate = true;
                }
            }
            List<int> indices = new List<int>();
            foreach (DictionaryEntry en in Processes)
            {
                Process temp = (Process)en.Value;
                if (temp.CheckedThisUpdate)
                {
                    temp.CheckedThisUpdate = false;
                }
                else
                {
                    // Dead process
                    indices.Add((int)en.Key);
                }
            }
            foreach (int index in indices)
                Processes.Remove(index);

            Lock.Release();
            Update.Start();
        }
    }
}
