using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIOSystemUtility3
{
    public delegate void VoidDelegate();

    /// <summary>
    /// Black magic that lets us ignore issues where something is wrong 
    /// without surrounding every single line in a try-catch.
    /// 
    /// Don't try this at home folks.
    /// From:
    /// http://stackoverflow.com/questions/117173/c-try-catch-every-line-of-code-without-individual-try-catch-blocks
    /// </summary>
    public static class Utils
    {
        public static void Try(VoidDelegate v)
        {
            try
            {
                v();
            }
            catch { }
        }
    }
}
