using System;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class NETSummary : UserControl, IVisitor
    {
        NetworkScraper NET = NetworkScraper.GetInstance();
        public NETSummary()
        {
            InitializeComponent();
            NET.RegisterVisitor(this);
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
            if (UpTxt.InvokeRequired)
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
                NET.Lock.WaitOne();
                float sumU = 0;
                float sumD = 0;
                foreach(NetworkAdapter adapter in NET.NetworkAdapters){
                    if (adapter.PhysicalAdapter)
                    {
                        sumU += adapter.KBSSentFloat;
                        sumD += adapter.KBSRecievedFloat;
                    }
                }
                UpTxt.Text = sumU.ToString("0.00 KB/s");
                DownTxt.Text = sumD.ToString("0.00 KB/s");
                NET.Lock.Release();
            }
        }
    }
}
