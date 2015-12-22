using System;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class CPUDetailControl : UserControl, IVisitor
    {
        CPUScraper CPU = CPUScraper.GetInstance();

        CPUCoreControl[] cores = null;
        Panel CorePanel = new Panel();

        public CPUDetailControl()
        {
            InitializeComponent();
            Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            Visible = false;
            CPU.RegisterVisitor(this);
            CorePanel.Visible = false;
            CorePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            CorePanel.AutoScroll = true;
            this.Controls.Add(CorePanel);
        }

        public void Update(Scraper s)
        {
            SetText();
        }

        delegate void SetTextCallback();
        SetTextCallback updateDelegate;
        private void SetText()
        {
            if (CPUNameTxt.InvokeRequired)
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
                CPU.Lock.WaitOne();
                CPUNameTxt.Text = CPU.Name;
                FamilyTxt.Text = CPU.Family;
                PackageTxt.Text = CPU.Package;
                CoresTxt.Text = CPU.CoresCount.ToString();
                ProcessorsTxt.Text = CPU.LogicalProcessorsCount.ToString();
                VirtualizationTxt.Text = CPU.VirtualizationEnabled ? "Enabled" : "Disabled";
                L1SizeTxt.Text = CPU.CacheSizeL1 + " KB";
                L2SizeTxt.Text = CPU.CacheSizeL2 + " KB";
                L3SizeTxt.Text = CPU.CacheSizeL3 + " KB";
                L1DescTxt.Text = CPU.CacheDescriptorL1;
                L2DescTxt.Text = CPU.CacheDescriptorL2;
                L3DescTxt.Text = CPU.CacheDescriptorL3;
                ProcessesTxt.Text = CPU.ProcessCount.ToString();
                ThreadsTxt.Text = CPU.ThreadCount.ToString();
                HandlesTxt.Text = CPU.HandleCount.ToString();
                CoreVoltageTxt.Text = CPU.CoreVoltage.ToString("0.## V");
                TempTxt.Text = CPU.CPUTemp;
                FanSpeedTxt.Text = (int)CPU.FanSpeed + " RPM";
                CPUMaxSpeedTxt.Text = (CPU.SpeedMax / 1000).ToString("0.##") + " GHz";
                BusSpeedTxt.Text = CPU.BusSpeed.ToString("0.## MHz");

                // Update core controls
                int p = CorePanel.VerticalScroll.Value;
                if (cores == null || cores.Length == 0)
                {
                    CorePanel.AutoScroll = false;
                    cores = new CPUCoreControl[CPU.LogicalProcessorsCount];
                    for (int i = 0; i < cores.Length; i++)
                    {
                        cores[i] = new CPUCoreControl(i + 1, CorePanel);
                        cores[i].Update(CPU.CoreClocks[i], CPU.CoreMultipliers[i]);
                        cores[i].Top = i * cores[i].Height + 5 * (i + 1);
                        cores[i].Left = 5;
                        cores[i].Width = CorePanel.Width - SystemInformation.VerticalScrollBarWidth / 2;
                        CorePanel.Controls.Add(cores[i]);
                    }
                    CorePanel.AutoScroll = true;
                }
                else
                {
                    for (int i = 0; i < cores.Length; i++)
                    {
                        cores[i].Update(CPU.CoreClocks[i], CPU.CoreMultipliers[i]);
                    }
                }
                CorePanel.VerticalScroll.Value = p;
                CPU.Lock.Release();
            }
        }

        private void CPUDetailControl_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                // Update Colours Here :D
                BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
                CorePanel.BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][1];
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

        private void DetailsBtn_Click(object sender, EventArgs e)
        {
            //Visible = false;
            Utils.Animate(this, Utils.Effect.Slide, 150, 0, true);
        }

        private void CPUDetailControl_Resize(object sender, EventArgs e)
        {
            if (this.Width > 767)
            {
                if (!CorePanel.Visible)
                {
                    CorePanel.Visible = true;
                    CorePanel.SetBounds(540, 107, Width - 567, Height - 139);
                }
            }
            else
            {
                CorePanel.Visible = false;
            }
        }
    }
}
