using System;

namespace AIOSystemUtility3
{
    public class Service : IComparable<Service>
    {
        public string Name { get; set; }
        public string Caption { get; set; } // DisplayName
        public string Description { get; set; }
        public int ProcessID { get; set; }
        public string StartMode { get; set; }
        public string IsRunning { get; set; } // State
        // Remove dead processes check
        public bool CheckedThisUpdate = false;

        public Service()
        {
            ProcessID = -1;
        }

        public int CompareTo(Service p)
        {
            return this.Name.CompareTo(p.Name);
        }
    }
}
