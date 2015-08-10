using System;
using System.Collections;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class ProcessesControl : UserControl, IVisitor
    {
        ProcessScraper Process = ProcessScraper.GetInstance();
        public ProcessControl[] processes = null;
        public ProcessesControl()
        {
            InitializeComponent();
            Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            Visible = false;
            Process.RegisterVisitor(this);
            ProcessPanel.VerticalScroll.SmallChange = 154;
            ProcessPanel.VerticalScroll.LargeChange = 462;
        }

        public void Update(Scraper s)
        {
            SetText();
        }

        delegate void SetTextCallback();
        SetTextCallback updateDelegate;
        private void SetText()
        {
            if (TotalProcessesTxt.InvokeRequired)
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
                Process.Lock.WaitOne();
                int caretPosition = ProcessPanel.VerticalScroll.Value;
                TotalProcessesTxt.Text = Process.Processes.Count.ToString();
                if (processes == null || processes.Length == 0 || processes.Length != Process.Processes.Count)
                {
                    ProcessPanel.Controls.Clear();
                    ProcessPanel.AutoScroll = false;
                    processes = new ProcessControl[Process.Processes.Count];
                    Process[] tempSortableArray = new Process[Process.Processes.Count];
                    int lastBot = 0;
                    int index = 0;
                    foreach (DictionaryEntry pair in Process.Processes)
                    {
                        tempSortableArray[index++] = (Process)pair.Value;
                    }
                    Array.Sort(tempSortableArray);
                    for (int i = 0; i < processes.Length; i++)
                    {
                        processes[i] = new ProcessControl(tempSortableArray[i], ProcessPanel);
                        processes[i].Top = lastBot + 4;
                        lastBot = processes[i].Bottom;
                        processes[i].Left = 4;
                        processes[i].Width = ProcessPanel.Width - SystemInformation.VerticalScrollBarWidth / 2;
                        ProcessPanel.Controls.Add(processes[i]);
                    }
                    ProcessPanel.AutoScroll = true;
                    if (ProcessPanel.VerticalScroll.Maximum < caretPosition)
                        caretPosition = ProcessPanel.VerticalScroll.Maximum;
                }
                else
                {
                    for (int i = 0; i < processes.Length; i++)
                    {
                        foreach (DictionaryEntry pair in Process.Processes)
                        {
                            if (processes[i].process.ProcessID == ((Process)pair.Value).ProcessID)
                            {
                                processes[i].Update((Process)pair.Value);
                                break;
                            }
                        }
                    }
                }
                ProcessPanel.VerticalScroll.Value = caretPosition;
                ProcessPanel.PerformLayout();
                Process.Lock.Release();
            }
        }

        private void ProcessesControl_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                // Update Colours Here :D
                BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
                ProcessPanel.BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][1];
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
