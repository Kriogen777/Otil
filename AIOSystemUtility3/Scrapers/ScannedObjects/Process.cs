using System;

namespace AIOSystemUtility3
{
    public class Process : IComparable<Process>
    {
        public string Name { get; set; }
        public string ProcessID { get; set; }
        public int ThreadCount { get; set; }
        public double ProcessorUse { get; set; }
        public long WorkingSetSize { get; set; }
        // Remove dead processes check
        public bool CheckedThisUpdate = false;

        public int CompareTo(Process p)
        {
            //int comp = (int)(p.ProcessorUse - this.ProcessorUse);
            //if (comp == 0)
            //{
            return this.Name.CompareTo(p.Name);
            //}
            //return (int)(p.ProcessorUse - this.ProcessorUse);
        }
    }
}
