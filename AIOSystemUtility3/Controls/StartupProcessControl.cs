using System;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class StartupProcessControl : UserControl
    {
        Panel parent = null;
        public StartupProcessControl(StartupProcess process, Panel parent)
        {
            InitializeComponent();
            Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parent = parent;
            Update();
            NameTxt.Text = process.Name;
            CommandTxt.Text = process.Command;
            LocationTxt.Text = process.Location;
            UserTxt.Text = process.User;
        }

        public void Update()
        {
            BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
            foreach (Control c in Controls)
            {
                if (c is Label)
                {
                    ((Label)c).ForeColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][3];
                }
            }
        }

        private void StartupProcessControl_MouseEnter(object sender, EventArgs e)
        {
            parent.Focus();
        }
    }
}
