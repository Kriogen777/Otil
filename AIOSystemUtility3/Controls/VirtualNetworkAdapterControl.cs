using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class VirtualNetworkAdapterControl : UserControl, NetAdapterControl
    {
        NetworkAdapter Adapter { get; set; }
        Panel parent = null;

        public VirtualNetworkAdapterControl(Panel parent, NetworkAdapter Adapter)
        {
            InitializeComponent();
            Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parent = parent;
            Update(Adapter);
        }

        public void Update(NetworkAdapter Adapter)
        {
            this.Adapter = Adapter;
            NameTxt.Text = Adapter.Name;
            TypeTxt.Text = Adapter.AdapterType;
            ManufacturerTxt.Text = Adapter.Manufacturer;
            PhysicalTxt.Text = Adapter.PhysicalAdapter ? "True" : "False";

            BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
            foreach (Control c in Controls)
            {
                if (c is Label)
                {
                    ((Label)c).ForeColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][3];
                }
            }
        }

        private void PhysicalNetworkAdapterControl_MouseEnter(object sender, System.EventArgs e)
        {
            parent.Focus();
        }
    }
}
