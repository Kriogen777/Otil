using System;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class CPUSimpleControl : UserControl, IVisitor
    {
        CPUScraper CPU = CPUScraper.GetInstance();
        CPUDetailControl CPUDetail = new CPUDetailControl();
        System.Timers.Timer UpdateGraph = new System.Timers.Timer(1000);
        public CPUSimpleControl()
        {
            InitializeComponent();
            Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right));
            Visible = false;
            CPU.RegisterVisitor(this);
            Controls.Add(CPUDetail);
            CPUDetail.VisibleChanged += CPUDetail_VisibleChanged;
            UpdateGraph.Elapsed += UpdateGraph_Elapsed;
            grapher1.SetKeyItem(0, "Utilization (%)");
            grapher1.SetKeyItem(1, "Temperature (°C)");
        }

        void UpdateGraph_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            UpdateGraph.Stop();
            CPU.Lock.WaitOne();
            grapher1.UpdateGraph(0, CPU.CurrentUtilizationPercent);
            grapher1.UpdateGraph(1, CPU.CPUTempDouble);
            CPU.Lock.Release();
            UpdateGraph.Start();
        }

        void CPUDetail_VisibleChanged(object sender, EventArgs e)
        {
            if (!CPUDetail.Visible)
            {
                //CPUSimplePanel.Visible = true;
                Utils.Animate(CPUSimplePanel, Utils.Effect.Slide, 150, 0, true);
            }
        }

        private void DetailsBtn_Click(object sender, EventArgs e)
        {
            //CPUSimplePanel.Visible = false;
            //CPUDetail.Visible = true;
            Utils.Animate(CPUSimplePanel, Utils.Effect.Slide, 150, 180, true);
            Utils.Animate(CPUDetail, Utils.Effect.Slide, 150, 180, true);
        }

        public void Update(Scraper s)
        {
            SetText();
            if (!UpdateGraph.Enabled) UpdateGraph.Start();
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
                CPUUtilizationTxt.Text = CPU.CurrentUtilization;
                double speed = 0;
                for (int i = 0; i < CPU.LogicalProcessorsCount; i++)
                {
                    speed += CPU.CoreClocks[i];
                }
                speed /= CPU.LogicalProcessorsCount;
                if (speed / 1000 >= 1)
                {
                    speed /= 1000;
                    CPUSpeedTxt.Text = speed.ToString("0.##") + " GHz";
                }
                else
                {
                    CPUSpeedTxt.Text = speed.ToString("0.##") + " MHz";
                }
                CPUMaxSpeedTxt.Text = (CPU.SpeedMax/1000).ToString("0.##") + " GHz";
                CoresTxt.Text = CPU.CoresCount.ToString();
                ProcessorsTxt.Text = CPU.LogicalProcessorsCount.ToString();
                VirtualizationTxt.Text = CPU.VirtualizationEnabled ? "Enabled" : "Disabled";
                ProcessesTxt.Text = CPU.ProcessCount.ToString();
                ThreadsTxt.Text = CPU.ThreadCount.ToString();
                HandlesTxt.Text = CPU.HandleCount.ToString();
                CPU.Lock.Release();
            }
        }

        private void CPUSimpleControl_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                // Update Colours Here :D
                BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
                foreach (Control c in CPUSimplePanel.Controls)
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
    }
}
