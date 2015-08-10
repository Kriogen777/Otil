using System;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class RAMSummary : UserControl, IVisitor
    {
        RAMScraper RAM = RAMScraper.GetInstance();
        public RAMSummary()
        {
            InitializeComponent();
            RAM.RegisterVisitor(this);
            UpdateColour();
        }

        public void UpdateColour(){
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
            if (UtilizationTxt.InvokeRequired)
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
                RAM.Lock.WaitOne();
                InUseTxt.Text = RAM.TotalAmountInUse.ToString("0.##") + "/" + (RAM.TotalCapacity/1000).ToString("0.## GB");
                UtilizationTxt.Text = RAM.TotalPercentUtilization.ToString("0.## '%'");
                RAM.Lock.Release();
            }
        }
    }
}
