using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class ProcessControl : UserControl
    {
        public Process process { get; set; }
        Panel parent = null;
        public ProcessControl(Process process, Panel parent)
        {
            InitializeComponent();
            Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parent = parent;
            Width = parent.Width - 4;
            Update(process);
        }

        public void Update(Process process)
        {
            BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
            foreach (Control c in Controls)
            {
                if (c is Label)
                {
                    ((Label)c).ForeColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][3];
                }
                else if (c is Button)
                {
                    ((Button)c).BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][1];
                    ((Button)c).FlatAppearance.MouseOverBackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][2];
                    ((Button)c).FlatAppearance.MouseDownBackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
                    ((Button)c).FlatAppearance.BorderColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
                    ((Button)c).ForeColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][4];
                }
            }

            this.process = process;
            NameTxt.Text = process.Name;
            PIDTxt.Text = process.ProcessID;
            ThreadCountTxt.Text = process.ThreadCount.ToString();
            ProcessorUseTxt.Text = (process.ProcessorUse / 100).ToString("0.## %");
            WorkingSetSizeTxt.Text = (process.WorkingSetSize / (1024 * 1024)).ToString("0.## Mb");
        }

        private void ProcessControl_MouseEnter(object sender, System.EventArgs e)
        {
            parent.Focus();
        }

        private void SystemBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                System.Diagnostics.Process processToEnd = System.Diagnostics.Process.GetProcessById(int.Parse(process.ProcessID));
                processToEnd.CloseMainWindow();
                processToEnd.Close();
            }
            catch(System.Exception ex){
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
