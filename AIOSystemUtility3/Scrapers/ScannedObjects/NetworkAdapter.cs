using System.Diagnostics;

namespace AIOSystemUtility3
{
    public class NetworkAdapter
    {
        public string AdapterType { get; set; } // Only Phys
        public string Name { get; set; }
        public int Index { get; set; }
        public string MACAddress { get; set; }
        public string Manufacturer { get; set; }
        public string NetConnectionID { get; set; } // Meh
        public bool PhysicalAdapter { get; set; }
        public long Speed { get; set; }
        public string DefaultIPGateway { get; set; }
        public bool DHCPEnabled { get; set; }
        public string IPv4Address { get; set; }
        public string IPv6Address { get; set; }
        public string IPSubnet { get; set; }
        public string KBSSent { get; set; }
        public float KBSSentFloat { get; set; }
        public string KBSRecieved { get; set; }
        public float KBSRecievedFloat { get; set; }

        public PerformanceCounter PerformanceCounterSent;
        public PerformanceCounter PerformanceCounterReceived;
    }
}
