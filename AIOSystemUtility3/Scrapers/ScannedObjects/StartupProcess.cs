using System;

namespace AIOSystemUtility3
{
    public class StartupProcess : IComparable<StartupProcess>
    {
        public string Name { get; set; }
        public string Command { get; set; }
        public string Location { get; set; }
        public string User { get; set; }

        public int CompareTo(StartupProcess p)
        {
            return this.Name.CompareTo(p.Name);
        }
    }
}
