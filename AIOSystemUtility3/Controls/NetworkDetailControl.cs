using System;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class NetworkDetailControl : UserControl, IVisitor
    {
        NetworkScraper NET = NetworkScraper.GetInstance();
        NetAdapterControl [] adapters = null;

        public NetworkDetailControl()
        {
            InitializeComponent();
            Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            Visible = false;
            NET.RegisterVisitor(this);
        }

        public void Update(Scraper s)
        {
            SetText();
        }

        delegate void SetTextCallback();
        SetTextCallback updateDelegate;
        private void SetText()
        {
            if (AdapterPanel.InvokeRequired)
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
                if (adapters == null || adapters.Length == 0)
                {
                    AdapterPanel.AutoScroll = false;
                    adapters = new NetAdapterControl[NET.NetworkAdapters.Count];
                    int top = 4;
                    for (int i = 0; i < adapters.Length; i++)
                    {
                        if(NET.NetworkAdapters[i].PhysicalAdapter){
                            adapters[i] = new PhysicalNetworkAdapterControl(AdapterPanel, NET.NetworkAdapters[i]);
                        }
                        else
                        {
                            adapters[i] = new VirtualNetworkAdapterControl(AdapterPanel, NET.NetworkAdapters[i]);
                        }
                        if (adapters[i] != null)
                        {
                            ((UserControl)adapters[i]).Top = top;
                            top = ((UserControl)adapters[i]).Bottom + 4;
                            ((UserControl)adapters[i]).Left = 4;
                            ((UserControl)adapters[i]).Width = AdapterPanel.Width - SystemInformation.VerticalScrollBarWidth / 2;
                            AdapterPanel.Controls.Add((UserControl)adapters[i]);
                        }
                    }
                    AdapterPanel.AutoScroll = true;
                }
                else
                {
                    for (int i = 0; i < adapters.Length; i++)
                    {
                        adapters[i].Update(NET.NetworkAdapters[i]);
                    }
                }
                NET.Lock.Release();
            }
        }

        private void OverviewBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void NetworkDetailControl_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                // Update Colours Here :D
                BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
                AdapterPanel.BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][1];
                foreach (Control c in Controls)
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
    }
}
