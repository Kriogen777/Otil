using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIOSystemUtility3
{
    public class HardDiskDrive
    {
        // Globals
        public string HWName { get; set; }
        public double Capacity { get; set; }
        public double Temperature { get; set; }
        public int Index { get; set; }

        public List<string> PartitionDeviceIDs { get; set; }

        public List<Partition> Partitions = new List<Partition>();

        public HardDiskDrive()
        {
            PartitionDeviceIDs = new List<string>();
        }

        public void addPartition(Partition p)
        {
            Partitions.Add(p);
        }

        public string ToString()
        {
            string s =
                Index.ToString() + "\r\n" +
                HWName + "\r\n" +
                Capacity.ToString("#.##") + "\r\n" +
                Temperature.ToString("#.##") + "\r\n";
            foreach (Partition p in Partitions)
            {
                if (p != null)
                {
                    s += p.ToString() + "\r\n";
                }
            }

            return s;
        }
    }
}
