using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class PhysicalNetworkAdapterControl : UserControl, NetAdapterControl
    {
        NetworkAdapter Adapter { get; set; }
        Panel parent = null;
        System.Timers.Timer UpdateGraph = new System.Timers.Timer(1000);

        public PhysicalNetworkAdapterControl(Panel parent, NetworkAdapter Adapter)
        {
            InitializeComponent();
            Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parent = parent;
            UpdateGraph.Elapsed += UpdateGraph_Elapsed;
            grapher1.SetKeyItem(0, "Kb/s Down");
            grapher1.SetKeyItem(1, "Kb/s Up");
            grapher1.SetDynamicMax(true);
            Update(Adapter);
        }

        private void UpdateGraph_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            UpdateGraph.Stop();
            grapher1.UpdateGraph(0, Adapter.KBSRecievedFloat);
            grapher1.UpdateGraph(1, Adapter.KBSSentFloat);
            UpdateGraph.Start();
        }

        public void Update(NetworkAdapter Adapter)
        {
            this.Adapter = Adapter;
            NameTxt.Text = Adapter.Name;
            TypeTxt.Text = Adapter.AdapterType;
            ManufacturerTxt.Text = Adapter.Manufacturer;
            PhysicalTxt.Text = Adapter.PhysicalAdapter ? "True" : "False";
            DHCPTxt.Text = Adapter.DHCPEnabled ? "True" : "False";
            MACTxt.Text = Adapter.MACAddress;
            IPv4Txt.Text = Adapter.IPv4Address;
            IPv6Txt.Text = Adapter.IPv6Address;
            SubnetTxt.Text = Adapter.IPSubnet;
            GatewayTxt.Text = Adapter.DefaultIPGateway;
            KbsDownTxt.Text = Adapter.KBSRecieved;
            KbsUpTxt.Text = Adapter.KBSSent;

            int maxLeft = 0;
            BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
            foreach (Control c in Controls)
            {
                if (c is Label)
                {
                    ((Label)c).ForeColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][3];
                    if (c.Right > maxLeft) maxLeft = c.Right + 15;
                }
            }
            grapher1.Left = maxLeft;
            grapher1.Width = this.Width - maxLeft - 4;

            if (!UpdateGraph.Enabled) UpdateGraph.Start();
        }

        private void PhysicalNetworkAdapterControl_MouseEnter(object sender, System.EventArgs e)
        {
            parent.Focus();
        }

        private void PhysicalNetworkAdapterControl_Resize(object sender, System.EventArgs e)
        {
            if (Width - grapher1.Left < 204)
            {
                grapher1.Visible = false;
            }
            else
            {
                if (!grapher1.Visible && Adapter.PerformanceCounterReceived != null && Adapter.PerformanceCounterSent != null) grapher1.Visible = true;
            }
        }
    }
}
