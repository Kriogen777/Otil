using System.Management;
using System.Timers;

namespace AIOSystemUtility3
{
    class MoboScraper : Scraper
    {
        // Properties
        public string Manufacturer { get; set; }
        public string ModelName { get; set; }
        public string ModelRevision { get; set; } // Could be "1.xx"
        public string BIOSManufacturer { get; set; }
        public string BIOSName { get; set; }
        public string BIOSRevision { get; set; }
        public string BIOSDate { get; set; }

        // Wanted but can't find properties
        public string ChipsetManufacturer { get; set; }
        public string ChipsetName { get; set; }
        public string ChipsetRevision { get; set; }
        public string SouthbridgeManufacturer { get; set; }
        public string SouthbridgeName { get; set; }
        public string SouthbridgeRevision { get; set; }
        public string LPCIOManufacturer { get; set; }
        public string LPCIOName { get; set; }
        public string LPCIORevision { get; set; }
        public string GraphicsInterfaceVersion { get; set; }
        public string GraphicsInterfaceLinkWidth { get; set; }

        private static MoboScraper instance = null;
        public static MoboScraper GetInstance()
        {
            if (instance == null)
            {
                instance = new MoboScraper();
            }
            return instance;
        }

        private MoboScraper()
            : base()
        {
            Update.Elapsed += Update_Elapsed2;
        }

        protected void Update_Elapsed2(object sender, ElapsedEventArgs e)
        {
            Lock.WaitOne();
            if (!IsFirstScanComplete)
            {
                // BIOS
                searcher = new ManagementObjectSearcher("select * from Win32_BIOS");
                // Scrape & Update
                foreach (ManagementObject share in searcher.Get())
                {
                    Utils.Try(() => BIOSManufacturer = (string)share["Manufacturer"]);
                    Utils.Try(() => BIOSName = (string)share["Version"]);
                    foreach (PropertyData pc in share.Properties)
                    {
                        if ((pc.Name.Equals("Name") || pc.Name.Equals("Caption") || pc.Name.Equals("Description") || pc.Name.Equals("SoftwareElementID")) && pc.Value != null)
                        {
                            if (((string)pc.Value).StartsWith("BIOS Date"))
                            {
                                string dateInfo = (string)pc.Value;
                                if (dateInfo.Contains("Ver"))
                                {
                                    BIOSRevision = dateInfo.Substring(dateInfo.IndexOf('V'));
                                    dateInfo = dateInfo.Substring(0,dateInfo.IndexOf('V'));
                                }
                                BIOSDate = dateInfo;
                            }
                        }
                    } // End inner properties loop
                } // End outer management loop

                // BaseBoard
                searcher = new ManagementObjectSearcher("select * from Win32_BaseBoard");
                // Scrape & Update
                foreach (ManagementObject share in searcher.Get())
                {
                    Utils.Try(() => Manufacturer = (string)share["Manufacturer"]);
                    Utils.Try(() => ModelName = (string)share["Product"]);
                    Utils.Try(() => ModelRevision = (string)share["Version"]);
                }
                IsFirstScanComplete = true;
            } // End static properties
            Lock.Release();
            //Update.Start();
        }
    }
}
