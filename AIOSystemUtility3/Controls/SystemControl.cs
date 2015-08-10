using System;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class SystemControl : UserControl, IVisitor
    {
        SystemScraper Sys = SystemScraper.GetInstance();
        MoboScraper Mobo = MoboScraper.GetInstance();
        public SystemControl()
        {
            InitializeComponent();
            Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            Visible = false;
            Sys.RegisterVisitor(this);
            Mobo.RegisterVisitor(this);
        }

        private void SystemControl_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                // Update Colours Here :D
                BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
                foreach (Control c in Controls)
                {
                    if (c is Label)
                    {
                        ((Label)c).ForeColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][3];
                    }
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
            if (PCNameTxt.InvokeRequired)
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
                //TimeHMTxt.Text = Sys.TimeHM;
                //TimeSTxt.Text = Sys.TimeS;
                //DateTxt.Text = Sys.Date;
                //DayTxt.Text = Sys.Day;
                PCNameTxt.Text = Sys.ComputerName;
                PCUptimeTxt.Text = Sys.SystemUptime;
                OSNameTxt.Text = Sys.OSName;
                OSArchitectureTxt.Text = Sys.OSArchitecture;
                OSVersionTxt.Text = Sys.OSBuild;
                Sys.Lock.Release();

                Mobo.Lock.WaitOne();
                MoboNameTxt.Text = Mobo.ModelName;
                MoboManTxt.Text = Mobo.Manufacturer;
                MoboVersionTxt.Text = Mobo.ModelRevision;
                BIOSNameTxt.Text = Mobo.BIOSName;
                BIOSManTxt.Text = Mobo.BIOSManufacturer;
                BIOSDateTxt.Text = Mobo.BIOSDate;
                BIOSVersionTxt.Text = Mobo.BIOSRevision;
                Mobo.Lock.Release();
            }
        }
    }
}
