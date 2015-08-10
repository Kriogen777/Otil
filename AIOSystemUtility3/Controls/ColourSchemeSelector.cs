using System;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class ColourSchemeSelector : UserControl
    {
        MiscControl parent = null;
        int index = 0;
        public ColourSchemeSelector(int index, MiscControl parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.index = index;
            BackColor = Colours.COLOURS[index][0];
            ColTxt.ForeColor = Colours.COLOURS[index][3];
            ColBtn.BackColor = Colours.COLOURS[index][1];
            ColBtn.FlatAppearance.MouseOverBackColor = Colours.COLOURS[index][2];
            ColBtn.FlatAppearance.MouseDownBackColor = Colours.COLOURS[index][0];
            ColBtn.FlatAppearance.BorderColor = Colours.COLOURS[index][0];
            ColBtn.ForeColor = Colours.COLOURS[index][4];
        }

        private void ColBtn_Click(object sender, EventArgs e)
        {
            Colours.GetInstance().SetSelectedColourScheme(index);
            parent.SwitchColours();
        }

        private void removeColourSchemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colours.GetInstance().RemoveColourScheme(index);
            parent.RemoveColourScheme(this);
        }
    }
}
