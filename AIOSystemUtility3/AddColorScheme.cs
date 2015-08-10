using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class AddColorScheme : Form
    {
        public Color[] Colors { get; private set; }
        bool[] done = new bool[] { false, false, false, false, false };
        public AddColorScheme()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Colors = new Color[5];
        }

        private void ShowColourPicker(int i, Button sender)
        {
            // Show the color dialog.
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                Colors[i] = colorDialog.Color;
                done[i] = true;
                sender.BackColor = Colors[i];

                bool allColorsPicked = true;
                foreach (bool fin in done)
                {
                    if (!fin)
                    {
                        allColorsPicked = false;
                        break;
                    }
                }
                if (allColorsPicked)
                {
                    OKbtn.Enabled = true;
                }
            }
        }

        private void AddColorBtn_Click(object sender, EventArgs e)
        {
            ShowColourPicker(0, (Button)sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowColourPicker(1, (Button)sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowColourPicker(2, (Button)sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowColourPicker(3, (Button)sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowColourPicker(4, (Button)sender);
        }
    }
}
