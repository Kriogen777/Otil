using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIOSystemUtility3
{
    class MemoryModule
    {
        public string MemType { get; set; }     // Wishful thinking
        public string Manufaturer { get; set; } // Wishful thinking
        public string PartNumber { get; set; }  // Wishful thinking
        public float Capacity { get; set; }
        //public float RemainingCapacity { get; set; }
        public string FormFactor { get; private set; }
        public int Speed { get; set; }

        public MemoryModule()
        {
            Capacity = 0; 
            SetFormFactor(0);
            Speed = 0;
        }

        public void SetFormFactor(int formFactor){
            switch (formFactor)
            {
                case 0: FormFactor = "Unknown"; break;
                case 1: FormFactor = "Other"; break;
                case 2: FormFactor = "SiP"; break;
                case 3: FormFactor = "DIP"; break;
                case 4: FormFactor = "ZIP"; break;
                case 5: FormFactor = "SOJ"; break;
                case 6: FormFactor = "Proprietary"; break;
                case 7: FormFactor = "SIMM"; break;
                case 8: FormFactor = "DIMM"; break;
                case 9: FormFactor = "TSOPO"; break;
                case 10: FormFactor = "PGA"; break;
                case 11: FormFactor = "RIM"; break;
                case 12: FormFactor = "SODIMM"; break;
                case 13: FormFactor = "SRIMM"; break;
                case 14: FormFactor = "SMD"; break;
                case 15: FormFactor = "SSMP"; break;
                case 16: FormFactor = "QFP"; break;
                case 17: FormFactor = "TQFP"; break;
                case 18: FormFactor = "SOIC"; break;
                case 19: FormFactor = "LCC"; break;
                case 20: FormFactor = "PLCC"; break;
                case 21: FormFactor = "FPGA"; break;
                case 22: FormFactor = "LGA"; break;
                default: FormFactor = "Unknown"; break;
            }
        }
    }
}
