using System;
using System.Drawing;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class MiscControl : UserControl
    {
        Form1 parent = null;
        public MiscControl(Form1 Parent)
        {
            this.parent = Parent;
            InitializeComponent();
            Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            Visible = false;
            SwitchColours(false);

            // Set up colour scheme demo
            for (int i = 0; i < Colours.COLOURS.Count; i++)
            {
                ColourSchemePanel.Controls.Add(new ColourSchemeSelector(i, this));
            }
        }

        public void SwitchColours(bool updateParent = true)
        {
            if (updateParent)
                parent.SwitchColours();
            BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
            ColourSchemePanel.BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][2];
            AboutTxt.ForeColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][4];
            AboutTxt.BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][2];
            foreach (Control c in Controls)
            {
                if (c is Label)
                {
                    ((Label)c).ForeColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][3];
                }
            }
            AddColorBtn.BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
            AddColorBtn.FlatAppearance.MouseOverBackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][2];
            AddColorBtn.FlatAppearance.MouseDownBackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][1];
            AddColorBtn.FlatAppearance.BorderColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
            AddColorBtn.ForeColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][4];
        }

        private void AddColorBtn_Click(object sender, EventArgs e)
        {
            using (var form = new AddColorScheme())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Color[] colors = form.Colors;
                    Colours.GetInstance().AddColourScheme(colors);
                    ColourSchemePanel.Controls.Add(new ColourSchemeSelector(Colours.COLOURS.Count - 1, this));
                }
            }
        }

        public void RemoveColourScheme(ColourSchemeSelector removeMe)
        {
            ColourSchemePanel.Controls.Remove(removeMe);
            SwitchColours();
        }
    }
}
