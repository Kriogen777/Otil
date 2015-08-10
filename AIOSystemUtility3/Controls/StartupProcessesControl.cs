using System;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class StartupProcessesControl : UserControl, IVisitor
    {
        StartupScraper Startup = StartupScraper.GetInstance();
        public StartupProcessControl[] startups = null;

        public StartupProcessesControl()
        {
            InitializeComponent();
            Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            Visible = false;
            Startup.RegisterVisitor(this);
            StartupPanel.VerticalScroll.SmallChange = 154;
            StartupPanel.VerticalScroll.LargeChange = 462;
        }

        public void Update(Scraper s)
        {
            SetText();
        }

        delegate void SetTextCallback();
        SetTextCallback updateDelegate;
        private void SetText()
        {
            if (TotalStartupsTxt.InvokeRequired)
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
                // Update here
                Startup.Lock.WaitOne();
                int caretPosition = StartupPanel.VerticalScroll.Value;
                TotalStartupsTxt.Text = Startup.StartupProcesses.Count.ToString();
                if (startups == null || startups.Length == 0 || startups.Length != Startup.StartupProcesses.Count)
                {
                    StartupPanel.Controls.Clear();
                    StartupPanel.AutoScroll = false;
                    startups = new StartupProcessControl[Startup.StartupProcesses.Count];
                    int lastBot = 0;
                    StartupProcess[] tempSortableArray = Startup.StartupProcesses.ToArray();
                    Array.Sort(tempSortableArray);
                    for (int i = 0; i < startups.Length; i++)
                    {
                        startups[i] = new StartupProcessControl(tempSortableArray[i], StartupPanel);
                        startups[i].Top = lastBot + 4;
                        lastBot = startups[i].Bottom;
                        startups[i].Left = 4;
                        startups[i].Width = StartupPanel.Width - SystemInformation.VerticalScrollBarWidth / 2;
                        StartupPanel.Controls.Add(startups[i]);
                    }
                    StartupPanel.AutoScroll = true;
                    if (StartupPanel.VerticalScroll.Maximum < caretPosition)
                        caretPosition = StartupPanel.VerticalScroll.Maximum;
                }
                StartupPanel.VerticalScroll.Value = caretPosition;
                StartupPanel.PerformLayout();
                Startup.Lock.Release();
            }
        }

        private void StartupProcessesControl_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                // Update Colours Here :D
                BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
                StartupPanel.BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][1];
                foreach (Control c in Controls)
                {
                    if (c is Label)
                    {
                        ((Label)c).ForeColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][3];
                    }
                }
                foreach (Control c in StartupPanel.Controls)
                {
                    if (c is StartupProcessControl)
                    {
                        ((StartupProcessControl)c).Update();
                    }
                }
            }
        }
    }
}
