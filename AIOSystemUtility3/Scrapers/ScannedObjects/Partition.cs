using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIOSystemUtility3
{
    public class Partition
    {
        public string Name { get; set; }
        public string FileSystem { get; set; }
        public double FreeSpace { get; set; }
        public double Capacity { get; set; }
        public string VolumeName { get; set; }
        public bool SystemPartition { get; set; }
        public string VolumeSerialNumber { get; set; } // Unique ID
        public bool FoundAndUpdated { get; set; } // For removal

        public string ToString()
        {
            string s =
                Name + "\r\n" +
                FileSystem + "\r\n" +
                Capacity.ToString("#.##") + "\r\n" +
                FreeSpace.ToString("#.##") + "\r\n" +
                VolumeName + "\r\n" + 
                SystemPartition;
            return s;
        }
    }
}
