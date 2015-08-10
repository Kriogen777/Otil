using System;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class SystemSummary : UserControl, IVisitor
    {
        SystemScraper Sys = SystemScraper.GetInstance();
        public SystemSummary()
        {
            InitializeComponent();
            Sys.RegisterVisitor(this);
            UpdateColour();
        }

        public void Update(Scraper s)
        {
            // Update Components Here :D
            SetText();
        }

        delegate void SetTextCallback();
        SetTextCallback updateDelegate;
        private void SetText()
        {
            if (TimeHMTxt.InvokeRequired)
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
                Sys.Lock.WaitOne();
                TimeHMTxt.Text = Sys.TimeHM;
                TimeSTxt.Text = Sys.TimeS;
                DateTxt.Text = Sys.Date;
                DayTxt.Text = Sys.Day;
                Sys.Lock.Release();
            }
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
    }
}
