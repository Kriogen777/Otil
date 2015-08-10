using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class CPUCoreControl : UserControl
    {
        Panel parent = null;
        Grapher grapher1 = new Grapher(60, 1);
        System.Timers.Timer UpdateGraph = new System.Timers.Timer(1000);
        CPUScraper CPU = CPUScraper.GetInstance();
        int index = 0;
        public CPUCoreControl(int CoreNumber, Panel parent)
        {
            InitializeComponent();
            this.parent = parent;
            Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            CoreNameTxt.Text = "Core #" + CoreNumber;
            index = CoreNumber - 1;
            grapher1.Visible = false;
            grapher1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            //grapher1.SetKeyItem(0, "Utilization (%)");
            this.Controls.Add(grapher1);
            UpdateGraph.Elapsed += UpdateGraph_Elapsed;
        }

        void UpdateGraph_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            CPU.Lock.WaitOne();
            grapher1.UpdateGraph(0, CPU.CoreUtilizationPercent[index]);
            CPU.Lock.Release();
        }

        public void Update(double speed, double multiplier)
        {
            if (!UpdateGraph.Enabled) UpdateGraph.Start();
            BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
            foreach (Control c in Controls)
            {
                if (c is Label)
                {
                    ((Label)c).ForeColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][3];
                }
            }
            SpeedTxt.Text = (speed / 1000).ToString("0.## GHz");
            MultiplierTxt.Text = multiplier.ToString("x0.#");
        }

        private void CPUCoreControl_MouseEnter(object sender, System.EventArgs e)
        {
            parent.Focus();
        }

        private void CPUCoreControl_Resize(object sender, System.EventArgs e)
        {
            if (this.Width > 335)
            {
                if (!grapher1.Visible)
                {
                    grapher1.Visible = true;
                    grapher1.SetBounds(220, 4, Width - 224, Height - 8);
                }
            }
            else
            {
                grapher1.Visible = false;
            }
        }
    }
}
