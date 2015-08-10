using System;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class HDDControl : UserControl
    {
        Panel parent = null;
        public PartitionControl[] partitions = null;

        public HDDControl(Panel parent, HardDiskDrive drive)
        {
            this.parent = parent;
            InitializeComponent();
            Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            Update(drive);
            this.Width = parent.Width - 8;
            PartitionPanel.HorizontalScroll.Enabled = false;
            PartitionPanel.HorizontalScroll.Visible = false;
        }

        public void Update(HardDiskDrive drive)
        {
            BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
            PartitionPanel.BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][1];
            foreach (Control c in Controls)
            {
                if (c is Label)
                {
                    ((Label)c).ForeColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][3];
                }
            }
            NameTxt.Text = drive.HWName;
            CapacityTxt.Text = drive.Capacity.ToString("0.## GB");
            TempTxt.Text = drive.Temperature.ToString("0.## °C");

            if (partitions == null || partitions.Length != drive.Partitions.Count)
            {
                PartitionPanel.Controls.Clear();
                int top = 4;
                partitions = new PartitionControl[drive.Partitions.Count];
                for (int i = 0; i < drive.Partitions.Count; i++)
                {
                    Partition partition = drive.Partitions[i];
                    PartitionControl part = new PartitionControl(partition);
                    part.Top = top;
                    top = part.Bottom + 4;
                    PartitionPanel.Controls.Add(part);
                    partitions[i] = part;
                }
            }
            else
            {
                foreach (Partition partition in drive.Partitions)
                {
                    foreach (PartitionControl partitionControl in partitions)
                    {
                        if (partition.Equals(partitionControl.partition))
                        {
                            partitionControl.Update(partition);
                            break;
                        }
                    }
                }
            }
        }

        private void HDDControl_MouseEnter(object sender, EventArgs e)
        {
            parent.Focus();
        }
    }
}
