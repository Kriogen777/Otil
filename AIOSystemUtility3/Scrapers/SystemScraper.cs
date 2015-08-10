using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Timers;

namespace AIOSystemUtility3
{
    class SystemScraper : Scraper
    {
        public string TimeHM { get; private set; }
        public string TimeS { get; private set; }
        public string Date { get; private set; }
        public string Day { get; private set; }
        public string ComputerName { get; private set; }
        public string SystemUptime { get; private set; }
        public string OSName { get; private set; }
        public string OSArchitecture { get; private set; }
        public string OSBuild { get; private set; }

        private static SystemScraper instance = null;
        public static SystemScraper GetInstance()
        {
            if (instance == null)
            {
                instance = new SystemScraper();
            }
            return instance;
        }

        private SystemScraper()
            : base()
        {
            Update.Elapsed += Update_Elapsed2;
        }

        protected void Update_Elapsed2(object sender, ElapsedEventArgs e)
        {
            Lock.WaitOne();
            if (!IsFirstScanComplete)
            {
                IsFirstScanComplete = true;
                var osNameTemp = (from obj in new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get().OfType<ManagementObject>() select obj.GetPropertyValue("Caption")).FirstOrDefault();
                OSName = osNameTemp != null ? osNameTemp.ToString() : "Unknown OS";
                ComputerName = Environment.MachineName;
                OSArchitecture = Environment.Is64BitOperatingSystem == true ? "x64" : "x86";
                OSBuild = Environment.OSVersion.ToString();
            } // End static properties
            // Time and day
            DateTime now = System.DateTime.Now;
            TimeHM = now.ToString("HH:mm");
            TimeS = now.ToString(":ss");
            Date = now.ToString("d MMMM yyyy");
            Day = now.ToString("dddd");

            // Uptime
            var ticks = Stopwatch.GetTimestamp();
            var uptime = ((double)ticks) / Stopwatch.Frequency;
            var uptimeSpan = TimeSpan.FromSeconds(uptime);
            SystemUptime = uptimeSpan.ToString(@"dd\.hh\:mm\:ss");
            Lock.Release();
            Update.Start();
        }
    }
}
