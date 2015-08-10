using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class MemModuleControl : UserControl
    {
        Panel parent = null;
        public MemModuleControl(int CoreNumber, Panel parent)
        {
            InitializeComponent();
            this.parent = parent;
            CoreNameTxt.Text = "Module #" + CoreNumber;
        }

        public void Update(float capacity, string formFactor, int speed)
        {
            BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
            foreach (Control c in Controls)
            {
                if (c is Label)
                {
                    ((Label)c).ForeColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][3];
                }
            }
            CapacityTxt.Text = capacity.ToString("0.## MB");
            FFactorTxt.Text = formFactor;
            SpeedTxt.Text = speed.ToString("0.## MHz");
        }

        private void MemModuleControl_MouseEnter(object sender, System.EventArgs e)
        {
            parent.Focus();
        }
    }
}
