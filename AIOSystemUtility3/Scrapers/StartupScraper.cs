using System.Collections.Generic;
using System.Management;
using System.Timers;

namespace AIOSystemUtility3
{
    class StartupScraper : Scraper
    {
        //Properties
        public List<StartupProcess> StartupProcesses { get; private set; }

        private static StartupScraper instance = null;
        public static StartupScraper GetInstance()
        {
            if (instance == null)
            {
                instance = new StartupScraper();
            }
            return instance;
        }

        private StartupScraper()
            : base()
        {
            Update.Elapsed += Update_Elapsed2;
            StartupProcesses = new List<StartupProcess>();
        }

        protected void Update_Elapsed2(object sender, ElapsedEventArgs e)
        {
            Lock.WaitOne();
            if (!IsFirstScanComplete)
            {
                IsFirstScanComplete = true;
                searcher = new ManagementObjectSearcher("select * from Win32_StartupCommand");
                // Scrape & Update
                foreach (ManagementObject share in searcher.Get())
                {
                    StartupProcess temp = new StartupProcess();
                    Utils.Try(() => temp.Name = (string)share["Name"]);
                    Utils.Try(() => temp.Command = (string)share["Command"]);
                    Utils.Try(() => temp.Location = (string)share["Location"]);
                    Utils.Try(() => temp.User = (string)share["User"]);
                    StartupProcesses.Add(temp);
                }

                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run", false);
                foreach (string appName in key.GetValueNames())
                {
                    StartupProcess temp = new StartupProcess();
                    Utils.Try(() => temp.Name = appName);
                    Utils.Try(() => temp.Command = key.GetValue(appName).ToString());
                    temp.Location = "Computer\\HKEY_LOCAL_MACHINE\\Software\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run";
                    bool found = false;
                    foreach (StartupProcess temp2 in StartupProcesses)
                    {
                        if (temp2.Name == temp.Name || temp2.Command == temp.Command)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found) StartupProcesses.Add(temp);
                }

            } // End static properties
            Lock.Release();
            UpdateVisitors();
            //Update.Start();
        }
    }
}
