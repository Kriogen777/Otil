using System.Management;
using System.Timers;
using OpenHardwareMonitor.Hardware;

namespace AIOSystemUtility3
{
    class GPUScraper : Scraper
    {
        // Static properties
        public string Name { get; private set; }
        public string Manufacturer { get; private set; }
        public string ChipType { get; private set; }
        public string DACType { get; private set; }
        public int MemCapacity { get; private set; }
        public uint MainScreenWidth { get; private set; }
        public uint MainScreenHeight { get; private set; }
        public uint MainScreenRefreshRate { get; private set; }
        public uint MainScreenBitrate { get; private set; }
        public string DriverVersion { get; private set; }
        public string DriverDate { get; private set; }

        // Dynamic properties
        public double Utilization { get; private set; }
        public double CoreClockSpeed { get; private set; }
        public double MemClockSpeed { get; private set; }
        public string GPUTemp { get; private set; }
        public double GPUTempDouble { get; private set; }
        public double FanSpeed { get; private set; }
        public double FanPercent { get; private set; }
        public double Voltage { get; private set; }

        private static GPUScraper instance = null;
        public static GPUScraper GetInstance()
        {
            if (instance == null)
            {
                instance = new GPUScraper();
            }
            return instance;
        }

        private GPUScraper()
            : base()
        {
            Update.Elapsed += Update_Elapsed2;
            //computerHardware.Open();
            computerHardware.GPUEnabled = true;
        }

        protected void Update_Elapsed2(object sender, ElapsedEventArgs e)
        {
            Lock.WaitOne();
            if (!IsFirstScanComplete)
            {
                computerHardware.Open();
                IsFirstScanComplete = true;
                searcher = new ManagementObjectSearcher("select * from Win32_VideoController");
                foreach (ManagementObject share in searcher.Get())
                {
                    uint bitsPerPixel = 0;
                    if (share["CurrentBitsPerPixel"] == null) continue;
                    Utils.Try(() => bitsPerPixel = (uint)share["CurrentBitsPerPixel"]);

                    if (bitsPerPixel == 0)
                    {
                        continue; // Active GPU check
                    }
                    else
                    {
                        Utils.Try(() => Name = (string)share["Name"]);
                        Utils.Try(() => Manufacturer = (string)share["AdapterCompatibility"]);
                        Utils.Try(() => ChipType = (string)share["VideoProcessor"]);
                        Utils.Try(() => DACType = (string)share["AdapterDACType"]);
                        Utils.Try(() => MemCapacity = (int)(((uint)share["AdapterRAM"]) / (1024 * 1024)));
                        Utils.Try(() => MainScreenWidth = (uint)share["CurrentHorizontalResolution"]);
                        Utils.Try(() => MainScreenHeight = (uint)share["CurrentVerticalResolution"]);
                        Utils.Try(() => MainScreenRefreshRate = (uint)share["CurrentRefreshRate"]);
                        MainScreenBitrate = bitsPerPixel;
                        Utils.Try(() => DriverVersion = (string)share["DriverVersion"]);
                        try
                        {
                            string tempDate = (string)share["DriverDate"];
                            DriverDate = tempDate.Substring(0, 4) + "-";
                            DriverDate += tempDate.Substring(4, 2) + "-";
                            DriverDate += tempDate.Substring(6, 2);
                        }
                        catch (ManagementException exc) { }
                    }
                }
            } // End static properties
            
            foreach (var hardware in computerHardware.Hardware)
                {
                    if (hardware.HardwareType == HardwareType.GpuAti || hardware.HardwareType == HardwareType.GpuNvidia)
                    {
                        hardware.Update();
                        foreach (var sensor in hardware.Sensors)
                        {
                            // Core Voltage
                            if (sensor.SensorType == SensorType.Voltage && sensor.Name.Equals("GPU Core"))
                            {
                                Voltage = (double)sensor.Value;
                            }

                            // Clocks
                            if (sensor.SensorType == SensorType.Clock)
                            {
                                if (sensor.Name.Equals("GPU Core") && sensor.Value != null)
                                {
                                    CoreClockSpeed = (float)sensor.Value;
                                }
                                else if (sensor.Name.Equals("GPU Memory") && sensor.Value != null)
                                {
                                    MemClockSpeed = (float)sensor.Value;
                                }
                            }

                            // Temperature
                            if (sensor.SensorType == SensorType.Temperature && sensor.Name.Equals("GPU Core"))
                            {
                                GPUTemp = sensor.Value == null ? "Unknown" : ((float)sensor.Value).ToString("0.00 °C");// +" °C";
                                GPUTempDouble = sensor.Value == null ? 0 : (double)(float)sensor.Value;
                            }

                            // Load
                            if (sensor.SensorType == SensorType.Load && sensor.Name.Equals("GPU Core") && sensor.Value != null)
                            {
                                Utilization = (double)(float)sensor.Value;
                            }

                            // Fan percent
                            if (sensor.SensorType == SensorType.Control && sensor.Name.Equals("GPU Fan") && sensor.Value != null)
                            {
                                FanPercent = (double)(float)sensor.Value;
                            }

                            // Fan rpm
                            if (sensor.SensorType == SensorType.Fan && sensor.Name.Equals("GPU Fan") && sensor.Value != null)
                            {
                                FanSpeed = (double)(float)sensor.Value;
                            }
                        }
                    }
                }
            Lock.Release();
            Update.Start();
        }
    }
}
