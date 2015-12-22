using System;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class NetworkSimpleControl : UserControl, IVisitor
    {
        NetworkScraper NET = NetworkScraper.GetInstance();
        NetworkDetailControl NetDetail = new NetworkDetailControl();
        System.Timers.Timer UpdateGraph = new System.Timers.Timer(1000);

        public NetworkSimpleControl()
        {
            InitializeComponent();
            Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            Visible = false;
            NET.RegisterVisitor(this);
            Controls.Add(NetDetail);
            NetDetail.VisibleChanged += NetDetail_VisibleChanged;
            UpdateGraph.Elapsed += UpdateGraph_Elapsed;
            grapher1.SetKeyItem(0, "Kb/s Down");
            grapher1.SetKeyItem(1, "Kb/s Up");
            grapher1.SetDynamicMax(true);
        }

        void NetDetail_VisibleChanged(object sender, EventArgs e)
        {
            if (!NetDetail.Visible)
            {
                NetworkSimplePanel.Visible = true;
            }
        }

        void UpdateGraph_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
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
            grapher1.UpdateGraph(0, sumD);
            grapher1.UpdateGraph(1, sumU);
            NET.Lock.Release();
        }

        public void Update(Scraper s)
        {
            SetText();
            if (!UpdateGraph.Enabled) UpdateGraph.Start();
        }

        delegate void SetTextCallback();
        SetTextCallback updateDelegate;
        private void SetText()
        {
            if (TotalKbsDownTxt.InvokeRequired)
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
                int sumPhysical = 0;
                float sumU = 0;
                float sumD = 0;
                foreach (NetworkAdapter adapter in NET.NetworkAdapters)
                {
                    if (adapter.PhysicalAdapter)
                    {
                        sumU += adapter.KBSSentFloat;
                        sumD += adapter.KBSRecievedFloat;
                        sumPhysical++;
                    }
                }
                TotalKbsDownTxt.Text = sumD.ToString("0.##") + " Kb/s";
                TotalKbsUpTxt.Text = sumU.ToString("0.##") + " Kb/s";
                PhysicalCountTxt.Text = sumPhysical.ToString();
                VirtualCountTxt.Text = (NET.NetworkAdapters.Count - sumPhysical).ToString();

                NET.Lock.Release();
            }
        }

        private void NetworkSimpleControl_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                // Update Colours Here :D
                NetworkSimplePanel.BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
                foreach (Control c in NetworkSimplePanel.Controls)
                {
                    if (c is Label)
                    {
                        ((Label)c).ForeColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][3];
                    }
                    if (c is Button)
                    {
                        ((Button)c).BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][1];
                        ((Button)c).FlatAppearance.MouseOverBackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][2];
                        ((Button)c).FlatAppearance.MouseDownBackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
                        ((Button)c).FlatAppearance.BorderColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
                        ((Button)c).ForeColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][4];
                    }
                }
            }
        }

        private void DetailsBtn_Click_1(object sender, EventArgs e)
        {
            //NetworkSimplePanel.Visible = false;
            //NetDetail.Visible = true;  
            Utils.Animate(NetworkSimplePanel, Utils.Effect.Slide, 150, 180, true);
            Utils.Animate(NetDetail, Utils.Effect.Slide, 150, 180, true);
        }
    }
}
