using System.Collections;
using System.Collections.Generic;
using System.Management;
using System.Timers;

namespace AIOSystemUtility3
{
    class ServiceScraper : Scraper
    {
        //Properties
        public Hashtable Services { get; private set; }

        private static ServiceScraper instance = null;
        public static ServiceScraper GetInstance()
        {
            if (instance == null)
            {
                instance = new ServiceScraper();
            }
            return instance;
        }

        private ServiceScraper()
            : base()
        {
            Update.Elapsed += Update_Elapsed2;
            Services = new Hashtable();
        }

        protected void Update_Elapsed2(object sender, ElapsedEventArgs e)
        {
            Lock.WaitOne();
            if (!IsFirstScanComplete)
                IsFirstScanComplete = true;

            searcher = new ManagementObjectSearcher("select * from Win32_Service");
            // Scrape & Update
            foreach (ManagementObject share in searcher.Get())
            {
                int processID = -1;
                Utils.Try(() => processID = (int)(uint)share["ProcessID"]);

                if (!Services.ContainsKey(processID))
                {
                    // Sanity check
                    if (processID == -1 || ((string)share["Name"]).Equals("_Total") || ((string)share["Name"]).Equals("Idle"))
                    {
                        continue;
                    }
                    Service temp = new Service();
                    Utils.Try(() => temp.Name = (string)share["Name"]);
                    Utils.Try(() => temp.Caption = (string)share["DisplayName"]);
                    Utils.Try(() => temp.Description = (string)share["Description"]);
                    Utils.Try(() => temp.StartMode = (string)share["StartMode"]);
                    Utils.Try(() => temp.IsRunning = (string)share["State"]);
                    temp.ProcessID = processID;
                    temp.CheckedThisUpdate = true;
                    Services.Add(temp.ProcessID, temp);
                }
                else
                {
                    Service temp = (Service)Services[processID];
                    Utils.Try(() => temp.IsRunning = (string)share["State"]);
                    temp.CheckedThisUpdate = true;
                }
            } // End outer management loop
            List<int> indices = new List<int>();
            foreach (DictionaryEntry en in Services)
            {
                Service temp = (Service)en.Value;
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
                Services.Remove(index);

            Lock.Release();
            Update.Start();
        }
    }
}
