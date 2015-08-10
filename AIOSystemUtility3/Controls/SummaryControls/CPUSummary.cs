using System;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class CPUSummary : UserControl, IVisitor
    {
        CPUScraper CPU = CPUScraper.GetInstance();
        public CPUSummary()
        {
            InitializeComponent();
            CPU.RegisterVisitor(this);
            BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][2];
            UpdateColour();
        }

        public void UpdateColour()
        {
            BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][2];
            foreach (Control c in Controls)
            {
                if (c is Label)
                {
                    ((Label)c).ForeColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][3];
                }
            }
        }

        public void Update(Scraper s)
        {
            SetText();
        }

        delegate void SetTextCallback();
        SetTextCallback updateDelegate;
        private void SetText()
        {
            if (CPUUtilizationTxt.InvokeRequired)
            {
                updateDelegate = new SetTextCallback(SetText);
                try
                {
                    Invoke(updateDelegate);
                }
                catch (System.ObjectDisposedException e)
                {
                    Console.WriteLine("Caught exception: " + e.StackTrace);
                }

            }
            else
            {
                CPU.Lock.WaitOne();
                CPUUtilizationTxt.Text = CPU.CurrentUtilization;
                CPUTempTxt.Text = CPU.CPUTemp;
                CPU.Lock.Release();
            }
        }
    }
}
