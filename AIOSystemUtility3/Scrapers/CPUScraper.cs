using OpenHardwareMonitor.Hardware;
using System;
using System.Management;
using System.Timers;
namespace AIOSystemUtility3
{
    class CPUScraper : Scraper
    {
        // Properties
        public string Name { get; private set; }
        public string Family { get; private set; }
        public string Package { get; private set; }
        public double SpeedMax { get; private set; }
        public uint CoresCount { get; private set; }
        public uint LogicalProcessorsCount { get; private set; }
        public bool VirtualizationEnabled { get; private set; }
        public UInt32 CacheSizeL1 { get; private set; }
        public string CacheDescriptorL1 { get; private set; }
        public UInt32 CacheSizeL2 { get; private set; }
        public string CacheDescriptorL2 { get; private set; }
        public UInt32 CacheSizeL3 { get; private set; }
        public string CacheDescriptorL3 { get; private set; }

        // Dynamic properties
        public double CoreVoltage { get; private set; }
        public int ProcessCount { get; private set; }
        public int ThreadCount { get; private set; }
        public int HandleCount { get; private set; }
        // OHWM properties
        public float FanSpeed { get; private set; }
        public string CPUTemp { get; private set; }
        public double CPUTempDouble { get; private set; }
        public string CurrentUtilization { get; private set; }
        public double CurrentUtilizationPercent { get; private set; }
        public double BusSpeed { get; private set; }
        public double[] CoreClocks { get; private set; }
        public double[] CoreMultipliers { get; private set; }
        public double[] CoreUtilizationPercent { get; private set; }



        private static CPUScraper instance = null;
        public static CPUScraper GetInstance()
        {
            if (instance == null)
            {
                instance = new CPUScraper();
            }
            return instance;
        }

        private CPUScraper()
            : base()
        {
            Update.Elapsed += Update_Elapsed2;
            computerHardware.CPUEnabled = true;
            computerHardware.MainboardEnabled = true;
        }

        protected void Update_Elapsed2(object sender, ElapsedEventArgs e)
        {
            Lock.WaitOne();
            if (!IsFirstScanComplete)
            {
                searcher = new ManagementObjectSearcher("select * from Win32_Processor");
                foreach (ManagementObject share in searcher.Get())
                {
                    Utils.Try(() => Name = (string)share["Name"]);
                    if (Name.Contains("@"))
                        Name = Name.Substring(0, Name.IndexOf('@')); // Don't like intel's naming convention
                    Name = Name.Trim();
                    Utils.Try(() => Family = getCodename(Convert.ToInt32((UInt16)share["Family"])));
                    Utils.Try(() => Package = (string)share["SocketDesignation"]);
                    Utils.Try(() => SpeedMax = Convert.ToDouble((uint)share["MaxClockSpeed"]));
                    Utils.Try(() => CoresCount = (uint)share["NumberOfCores"]);
                    Utils.Try(() => LogicalProcessorsCount = (uint)share["NumberOfLogicalProcessors"]);
                    Utils.Try(() => VirtualizationEnabled = (bool)share["VirtualizationFirmwareEnabled"]);
                }
                // Scrape Cache
                searcher = new ManagementObjectSearcher("select * from Win32_CacheMemory");
                // Scrape & Update
                foreach (ManagementObject share in searcher.Get())
                {
                    try
                    {
                        UInt16 level = (UInt16)share["Level"];
                        string desc = getCacheDescriptor((int)(UInt16)share["Associativity"]);
                        UInt32 size = (UInt32)share["MaxCacheSize"];

                        if (level == 3)
                        {
                            CacheDescriptorL1 = desc;
                            CacheSizeL1 = size;
                        }
                        else if (level == 4)
                        {
                            CacheDescriptorL2 = desc;
                            CacheSizeL2 = size;
                        }
                        else if (level == 5)
                        {
                            CacheDescriptorL3 = desc;
                            CacheSizeL3 = size;
                        }
                    }
                    catch (ManagementException exc) { }
                }
            } // End static properties scan

            using (ManagementObject Mo = new ManagementObject("Win32_Processor.DeviceID='CPU0'"))
            {
                if (Mo["CurrentVoltage"] != null)
                    CoreVoltage = ((double)(ushort)Mo["CurrentVoltage"]) / 10;
            }
            searcher = new ManagementObjectSearcher("SELECT ThreadCount, HandleCount FROM Win32_Process");
            ProcessCount = 0;
            ThreadCount = 0;
            HandleCount = 0;
            foreach (ManagementObject share in searcher.Get())
            {
                try
                {
                    ProcessCount++;
                    ThreadCount += (int)(uint)share["ThreadCount"];
                    HandleCount += (int)(uint)share["HandleCount"];
                }
                catch (ManagementException exc) { }
            }
            computerHardware.Open();
            foreach (var hardware in computerHardware.Hardware)
            {
                // Fan speed
                if (hardware.HardwareType != HardwareType.CPU)
                {
                    foreach (var subhardware in hardware.SubHardware)
                    {
                        subhardware.Update();
                        if (subhardware.Sensors.Length > 0)
                        {
                            foreach (var sensor in subhardware.Sensors)
                            {
                                if (sensor.SensorType == SensorType.Fan && sensor.Name.Equals("Fan #1", StringComparison.OrdinalIgnoreCase))
                                {
                                    FanSpeed = (float)sensor.Value;
                                }
                            }
                        }
                    }
                    continue;
                }
                else
                {
                    hardware.Update();
                    if (CoreClocks == null || CoreMultipliers == null || CoreUtilizationPercent == null)
                    {
                        CoreClocks = new double[LogicalProcessorsCount];
                        CoreMultipliers = new double[LogicalProcessorsCount];
                        CoreUtilizationPercent = new double[LogicalProcessorsCount];
                    }
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.Name.Equals("CPU Total"))
                        {
                            CurrentUtilization = ((double)sensor.Value).ToString("0.##") + " %";
                            CurrentUtilizationPercent = (double)sensor.Value;
                        }
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            CPUTempDouble = sensor.Value == null ? 0 : (double)(float)sensor.Value;
                            CPUTemp = CPUTempDouble.ToString("0.00 °C");// +" °C";
                        }
                        if (sensor.Name.Equals("Bus Speed"))
                        {
                            BusSpeed = (double)sensor.Value;
                        }
                        if (sensor.SensorType == SensorType.Clock && sensor.Index > 0)
                        {
                            CoreClocks[sensor.Index - 1] = (float)sensor.Value;
                            CoreMultipliers[sensor.Index - 1] = CoreClocks[sensor.Index - 1] / BusSpeed;
                        }
                        if (sensor.SensorType == SensorType.Load && sensor.Index > 0)
                        {
                            CoreUtilizationPercent[sensor.Index - 1] = (double)sensor.Value;
                        }
                    }
                }
            }
            if (CurrentUtilization != null && CurrentUtilization.Length > 0)
                IsFirstScanComplete = true;
            Lock.Release();
            Update.Start();
        }

        private string getCacheDescriptor(int associativity)
        {
            switch (associativity)
            {
                case 1: return "Other";
                case 2: return "Unknown";
                case 3: return "Direct Mapped";
                case 4: return "2-way Set-Associative";
                case 5: return "4-way Set-Associative";
                case 6: return "Fully Associative";
                case 7: return "8-way Set-Associative";
                case 8: return "16-way Set-Associative";
                case 9: return "12-way Set-Associative";
                case 10: return "24-way Set-Associative";
                case 11: return "32-way Set-Associative";
                case 12: return "48-way Set-Associative";
                case 13: return "64-way Set-Associative";
                case 14: return "20-way Set-Associative";
            }
            return null;
        }

        private string getCodename(int family)
        {
            // As per the "System Management BIOS (SMBIOS) Reference Specification DSP0134"
            switch (family)
            {
                case 1: return "Other";
                case 2: return "Unknown";
                case 3: return "8086";
                case 4: return "80286";
                case 5: return "80386";
                case 6: return "80486";
                case 7: return "8087";
                case 8: return "80287";
                case 9: return "80387";
                case 10: return "80487";
                case 11: return "Pentium(R) brand";
                case 12: return "Pentium(R) Pro";
                case 13: return "Pentium(R) II";
                case 14: return "Pentium(R) processor with MMX(TM) technology";
                case 15: return "Celeron(TM)";
                case 16: return "Pentium(R) II Xeon(TM)";
                case 17: return "Pentium(R) III";
                case 18: return "M1 Family";
                case 19: return "M2 Family";
                // 20-23
                case 24: return "K5 Family";
                case 25: return "K6 Family";
                case 26: return "K6-2";
                case 27: return "K6-3";
                case 28: return "AMD Athlon(TM) Processor Family";
                case 29: return "AMD(R) Duron(TM) Processor";
                case 30: return "AMD29000 Family";
                case 31: return "K6-2+";
                case 32: return "Power PC Family";
                case 33: return "Power PC 601";
                case 34: return "Power PC 603";
                case 35: return "Power PC 603+";
                case 36: return "Power PC 604";
                case 37: return "Power PC 620";
                case 38: return "Power PC X704";
                case 39: return "Power PC 750";
                case 40: return "Intel(R) Core(TM) Duo processor";
                case 41: return "Intel(R) Core(TM) Duo mobile processor";
                case 42: return "Intel(R) Core(TM) Solo mobile processor";
                case 43: return "Intel(R) Atom(TM) processor";
                // 44-47
                case 48: return "Unknown";
                case 49: return "Alpha Family";
                case 50: return "Alpha 21064";
                case 51: return "Alpha 21066";
                case 52: return "Alpha 21164PC";
                case 53: return "Alpha 21164a";
                case 54: return "Alpha 21264";
                case 55: return "Alpha 21364";
                case 56: return "AMD Turion(TM) II Ultra Dual-Core Mobile M Processor Family";
                case 57: return "AMD Turion(TM) II Dual-Core Mobile M Processor Family";
                case 58: return "AMD Athlon(TM) II Dual-Core M Processor Family";
                case 59: return "AMD Opteron(TM) 6100 Series Processor";
                case 60: return "AMD Opteron(TM) 4100 Series Processor";
                case 61: return "AMD Opteron(TM) 6200 Series Processor";
                case 62: return "AMD Opteron(TM) 4200 Series Processor";
                case 63: return "AMD FX(TM) Series Processor";
                case 64: return "MIPS Family";
                case 65: return "MIPS R4000";
                case 66: return "MIPS R4200";
                case 67: return "MIPS R4400";
                case 68: return "MIPS R4600";
                case 69: return "MIPS R10000";
                case 70: return "AMD C-Series Processor";
                case 71: return "AMD E-Series Processor";
                case 72: return "AMD A-Series Processor";
                case 73: return "AMD G-Series Processor";
                case 74: return "AMD Z-Series Processor";
                case 75: return "AMD R-Series Processor";
                case 76: return "AMD Opteron(TM) 4300 Series Processor";
                case 77: return "AMD Opteron(TM) 6300 Series Processor";
                case 78: return "AMD Opteron(TM) 3300 Series Processor";
                case 79: return "AMD FirePro(TM) Series Processor";
                case 80: return "SPARC Family";
                case 81: return "SuperSPARC";
                case 82: return "microSPARC II";
                case 83: return "microSPARC IIep";
                case 84: return "UltraSPARC";
                case 85: return "UltraSPARC II";
                case 86: return "UltraSPARC IIi";
                case 87: return "UltraSPARC III";
                case 88: return "UltraSPARC IIIi";
                // 89-95
                case 96: return "68040";
                case 97: return "68xxx Family";
                case 98: return "68000";
                case 99: return "68010";
                case 100: return "68020";
                case 101: return "68030";
                // 102-111
                case 112: return "Hobbit Family";
                // 113-119
                case 120: return "Crusoe(TM) TM5000 Family";
                case 121: return "Crusoe(TM) TM3000 Family";
                case 122: return "Efficeon(TM) TM8000 Family";
                // 123-127
                case 128: return "Weitek";
                // 129
                case 130: return "Itanium(TM) Processor";
                case 131: return "AMD Athlon(TM) 64 Processor Family";
                case 132: return "AMD Opteron(TM) Family";
                case 133: return "AMD Sempron(TM) Processor Family";
                case 134: return "AMD Turion(TM) 64 Mobile Technology";
                case 135: return "Dual-Core AMD Opteron(TM) Processor Family";
                case 136: return "AMD Athlon(TM) 64 X2 Dual-Core Processor Family";
                case 137: return "AMD Turion(TM) 64 X2 Mobile Technology";
                case 138: return "Quad-Core AMD Opteron(TM) Processor Family";
                case 139: return "Third-Generation AMD Opteron(TM) Processor Family";
                case 140: return "AMD Phenom(TM) FX Quad-Core Processor Family";
                case 141: return "AMD Phenom(TM) X4 Quad-Core Processor Family";
                case 142: return "AMD Phenom(TM) X2 Dual-Core Processor Family";
                case 143: return "AMD Athlon(TM) X2 Dual-Core Processor Family";
                case 144: return "PA-RISC Family";
                case 145: return "PA-RISC 8500";
                case 146: return "PA-RISC 8000";
                case 147: return "PA-RISC 7300LC";
                case 148: return "PA-RISC 7200";
                case 149: return "PA-RISC 7100LC";
                case 150: return "PA-RISC 7100";
                // 151-159
                case 160: return "V30 Family";
                case 161: return "Quad-Core Intel(R) Xeon(R) processor 3200 Series";
                case 162: return "Dual-Core Intel(R) Xeon(R) processor 3000 Series";
                case 163: return "Quad-Core Intel(R) Xeon(R) processor 5300 Series";
                case 164: return "Dual-Core Intel(R) Xeon(R) processor 5100 Series";
                case 165: return "Dual-Core Intel(R) Xeon(R) processor 5000 Series";
                case 166: return "Dual-Core Intel(R) Xeon(R) processor LV";
                case 167: return "Dual-Core Intel(R) Xeon(R) processor ULV";
                case 168: return "Dual-Core Intel(R) Xeon(R) processor 7100 Series";
                case 169: return "Quad-Core Intel(R) Xeon(R) processor 5400 Series";
                case 170: return "Quad-Core Intel(R) Xeon(R) processor";
                case 171: return "Dual-Core Intel(R) Xeon(R) processor 5200 Series";
                case 172: return "Dual-Core Intel(R) Xeon(R) processor 7200 Series";
                case 173: return "Quad-Core Intel(R) Xeon(R) processor 7300 Series";
                case 174: return "Quad-Core Intel(R) Xeon(R) processor 7400 Series";
                case 175: return "Multi-Core Intel(R) Xeon(R) processor 7400 Series";
                case 176: return "Pentium(R) III Xeon(TM)";
                case 177: return "Pentium(R) III Processor with Intel(R) SpeedStep(TM) Technology";
                case 178: return "Pentium(R) 4";
                case 179: return "Intel(R) Xeon(TM)";
                case 180: return "AS400 Family";
                case 181: return "Intel(R) Xeon(TM) processor MP";
                case 182: return "AMD AthlonXP(TM) Family";
                case 183: return "AMD AthlonMP(TM) Family";
                case 184: return "Intel(R) Itanium(R) 2";
                case 185: return "Intel Pentium M Processor";
                case 186: return "Intel(R) Celeron(R) D processor";
                case 187: return "Intel(R) Pentium(R) D processor";
                case 188: return "Intel(R) Pentium(R) Processor Extreme Edition";
                case 189: return "Intel(R) Core(TM) Solo Processor";
                case 190: return "k7";
                case 191: return "Intel(R) Core(TM) 2 Duo Processor";
                case 192: return "Intel(R) Core(TM) 2 Solo processor";
                case 193: return "Intel(R) Core(TM) 2 Extreme processor";
                case 194: return "Intel(R) Core(TM) 2 Quad processor";
                case 195: return "Intel(R) Core(TM) 2 Extreme mobile processor";
                case 196: return "Intel(R) Core(TM) 2 Duo mobile processor";
                case 197: return "Intel(R) Core(TM) 2 Solo mobile processor";
                case 198: return "Intel(R) Core(TM) i7 processor";
                case 199: return "Dual-Core Intel(R) Celeron(R) processor";
                case 200: return "IBM390 Family";
                case 201: return "G4";
                case 202: return "G5";
                case 203: return "G6";
                case 204: return "z/Architecture base";
                case 205: return "Intel(R) Core(TM) i5 processor";
                case 206: return "Intel(R) Core(TM) i3 processor";
                // 207-209
                case 210: return "VIA C7(TM)-M Processor Family";
                case 211: return "VIA C7(TM)-D Processor Family";
                case 212: return "VIA C7(TM) Processor Family";
                case 213: return "VIA Eden(TM) Processor Family";
                case 214: return "Multi-Core Intel(R) Xeon(R) processor";
                case 215: return "Dual-Core Intel(R) Xeon(R) processor 3xxx Series";
                case 216: return "Quad-Core Intel(R) Xeon(R) processor 3xxx Series";
                case 217: return "VIA Nano(TM) Processor Family";
                case 218: return "Dual-Core Intel(R) Xeon(R) processor 5xxx Series";
                case 219: return "Quad-Core Intel(R) Xeon(R) processor 5xxx Series";
                // 220
                case 221: return "Dual-Core Intel(R) Xeon(R) processor 7xxx Series";
                case 222: return "Quad-Core Intel(R) Xeon(R) processor 7xxx Series";
                case 223: return "Multi-Core Intel(R) Xeon(R) processor 7xxx Series";
                case 224: return "Multi-Core Intel(R) Xeon(R) processor 3400 Series";
                // 225-227
                case 228: return "AMD Opteron(TM) 3000 Series Processor";
                case 229: return "AMD Sempron(TM) II Processor";
                case 230: return "Embedded AMD Opteron(TM) Quad-Core Processor Family";
                case 231: return "AMD Phenom(TM) Triple-Core Processor Family";
                case 232: return "AMD Turion(TM) Ultra Dual-Core Mobile Processor Family";
                case 233: return "AMD Turion(TM) Dual-Core Mobile Processor Family";
                case 234: return "AMD Athlon(TM) Dual-Core Processor Family";
                case 235: return "AMD Sempron(TM) SI Processor Family";
                case 236: return "AMD Phenom(TM) II Processor Family";
                case 237: return "AMD Athlon(TM) II Processor Family";
                case 238: return "Six-Core AMD Opteron(TM) Processor Family";
                case 239: return "AMD Sempron(TM) M Processor Family";
                // 240-249
                case 250: return "i860";
                case 251: return "i960";
                // 252-2599
                case 260: return "SH-3";
                case 261: return "SH-4";
                // 262-279
                case 280: return "ARM";
                case 281: return "StrongARM";
                // 282-299
                case 300: return "6x86";
                case 301: return "MediaGX";
                case 302: return "MII";
                // 303-319
                case 320: return "WinChip";
                // 321-349
                case 350: return "DSP";
                // 351-499
                case 500: return "Video Processor";
            }

            return "Unsupported Family";
        }

    }
}
