using System;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class GPUSummary : UserControl, IVisitor
    {
        GPUScraper GPU = GPUScraper.GetInstance();
        public GPUSummary()
        {
            InitializeComponent();
            GPU.RegisterVisitor(this);
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
                GPU.Lock.WaitOne();
                UtilizationTxt.Text = GPU.Utilization.ToString("0.## '%'");
                TempTxt.Text = GPU.GPUTemp;
                GPU.Lock.Release();
            }
        }
    }
}
