using System;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class MemoryControl : UserControl, IVisitor
    {
        RAMScraper RAM = RAMScraper.GetInstance();
        MemModuleControl[] modules = null;
        Grapher grapher1 = new Grapher(60, 1);
        System.Timers.Timer UpdateGraph = new System.Timers.Timer(1000);

        public MemoryControl()
        {
            InitializeComponent();
            Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            Visible = false;
            RAM.RegisterVisitor(this);
            //grapher1.SetBounds(600, 107, 200, 595);
            grapher1.Visible = false;
            grapher1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            grapher1.SetKeyItem(0, "Utilization (%)");
            this.Controls.Add(grapher1);
            UpdateGraph.Elapsed += UpdateGraph_Elapsed;
        }

        void UpdateGraph_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            RAM.Lock.WaitOne();
            grapher1.UpdateGraph(0, RAM.TotalPercentUtilization);
            RAM.Lock.Release();
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
            if (TotalTxt.InvokeRequired)
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
                RAM.Lock.WaitOne();
                TotalTxt.Text = (RAM.TotalCapacity / 1000).ToString("0.## GB");
                UsedTxt.Text = RAM.TotalAmountInUse.ToString("0.## GB");
                AvailableTxt.Text = RAM.TotalAmountAvailable.ToString("0.## GB");
                UtilizationTxt.Text = RAM.TotalPercentUtilization.ToString("0.## '%'");
                PageCapTxt.Text = (RAM.PageCapacity / 1000).ToString("0.## GB");
                PageCapRemTxt.Text = (RAM.PageCapacityRemaining / 1000).ToString("0.## GB");
                CommitedTxt.Text = RAM.Commited;
                CachedTxt.Text = RAM.Cached.ToString("0.## GB");
                PagedPoolTxt.Text = (RAM.PagedPool / 1000).ToString("0.## GB");
                NonPagedPoolTxt.Text = (RAM.NonPagedPool / 1000).ToString("0.## GB");

                // Update module controls
                int p = ModulePanel.VerticalScroll.Value;
                if (modules == null)
                {
                    if (RAM.MemoryModules.Count > 0)
                    {
                        ModulesTxt.Text = RAM.MemoryModules.Count.ToString();
                        modules = new MemModuleControl[RAM.MemoryModules.Count];
                        for (int i = 0; i < modules.Length; i++)
                        {
                            modules[i] = new MemModuleControl(i + 1, ModulePanel);
                            MemoryModule memM = RAM.MemoryModules[i];
                            modules[i].Update(memM.Capacity, memM.FormFactor, memM.Speed);
                            modules[i].Top = i * modules[i].Height + 4 * (i + 1);
                            modules[i].Left = 4;
                            modules[i].Width = ModulePanel.Width - 8;
                            ModulePanel.Controls.Add(modules[i]);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < modules.Length; i++)
                    {
                        MemoryModule memM = RAM.MemoryModules[i];
                        modules[i].Update(memM.Capacity, memM.FormFactor, memM.Speed);
                    }
                }
                ModulePanel.VerticalScroll.Value = p;

                RAM.Lock.Release();
            }
        }

        private void MemoryControl_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                // Update Colours Here :D
                BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
                ModulePanel.BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][1];
                foreach (Control c in Controls)
                {
                    if (c is Label)
                    {
                        ((Label)c).ForeColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][3];
                    }
                }
            }
        }

        private void MemoryControl_Resize(object sender, EventArgs e)
        {
            if (this.Width > 827)
            {
                if (!grapher1.Visible)
                {
                    grapher1.Visible = true;
                    grapher1.SetBounds(600, 107, Width - 627, Height - 130);
                }
            }
            else
            {
                grapher1.Visible = false;
            }
        }
    }
}
