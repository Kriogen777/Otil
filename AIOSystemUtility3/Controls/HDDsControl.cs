using System;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class HDDsControl : UserControl, IVisitor
    {
        HDDScraper HDD = HDDScraper.GetInstance();
        public HDDControl[] hardDrives = null;

        public HDDsControl()
        {
            InitializeComponent();
            Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            Visible = false;
            HDD.RegisterVisitor(this);
        }

        public void Update(Scraper s)
        {
            SetText();
        }

        delegate void SetTextCallback();
        SetTextCallback updateDelegate;
        private void SetText()
        {
            if (TotalCapTxt.InvokeRequired)
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
                HDD.Lock.WaitOne();
                // Update direct controls
                double totalCap = 0;
                double free = 0;
                int partitionsCount = 0;
                foreach (HardDiskDrive hdd in HDD.HardDrives)
                {
                    totalCap += hdd.Capacity;
                    foreach (Partition part in hdd.Partitions)
                    {
                        partitionsCount++;
                        free += part.FreeSpace;
                    }
                }
                TotalCapTxt.Text = totalCap.ToString("0.## GB");
                FreeTxt.Text = free.ToString("0.## GB");
                DrivesTxt.Text = HDD.HardDrives.Count.ToString();
                PartitionsTxt.Text = partitionsCount.ToString();
                // Update child controls
                if (hardDrives == null || hardDrives.Length != HDD.HardDrives.Count)
                {
                    HDDPanel.Controls.Clear();
                    if (HDD.HardDrives.Count > 0)
                    {
                        hardDrives = new HDDControl[HDD.HardDrives.Count];
                        int lastBot = 0;
                        for (int i = 0; i < hardDrives.Length; i++)
                        {
                            hardDrives[i] = new HDDControl(HDDPanel, HDD.HardDrives[i]);
                            hardDrives[i].Top = lastBot + 4;
                            lastBot = hardDrives[i].Bottom;
                            hardDrives[i].Left = 4;
                            HDDPanel.Controls.Add(hardDrives[i]);
                        }
                    }
                }
                else
                {
                    int caretPosition = HDDPanel.VerticalScroll.Value;
                    for (int i = 0; i < hardDrives.Length; i++)
                    {
                        hardDrives[i].Update(HDD.HardDrives[i]);
                    }
                    HDDPanel.VerticalScroll.Value = caretPosition;
                }
                HDD.Lock.Release();
            }
        }

        private void HDDsControl_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                // Update Colours Here :D
                BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
                HDDPanel.BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][1];
                foreach (Control c in Controls)
                {
                    if (c is Label)
                    {
                        ((Label)c).ForeColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][3];
                    }
                }
            }
        }
    }
}
