using System;
using System.ServiceProcess;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class ServiceControl : UserControl
    {
        public Service service { get; set; }
        Panel parent = null;
        ToolTip tTip = new ToolTip();

        public ServiceControl(Service service, Panel parent)
        {
            InitializeComponent();
            Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parent = parent;
            tTip.AutoPopDelay = 1000;
            Update(service);
        }

        public void Update(Service service)
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

            this.service = service;
            NameTxt.Text = service.Name;
            if (!string.IsNullOrWhiteSpace(service.Description))
            {
                string[] words = service.Description.Split(' ');
                if (words.Length > 10)
                {
                    string tt = "";
                    for (int i = 0; i < words.Length; i++)
                    {
                        tt += words[i] + " ";
                        if ((i + 1) % 10 == 0)
                        {
                            tt += Environment.NewLine;
                        }
                    }
                    tTip.SetToolTip(this, tt);
                }
                else
                {
                    tTip.SetToolTip(this, service.Description);
                }
            }
            PIDTxt.Text = service.ProcessID.ToString();
            StartModeTxt.Text = service.StartMode;
            IsRunningTxt.Text = service.IsRunning;
        }

        private void ServiceControl_MouseEnter(object sender, EventArgs e)
        {
            parent.Focus();
        }

        private void SystemBtn_Click(object sender, EventArgs e)
        {
            ServiceController sc = new ServiceController(service.Name);
            if ((sc.Status.Equals(ServiceControllerStatus.Stopped)) ||
            (sc.Status.Equals(ServiceControllerStatus.StopPending)))
            {
                sc.Start();
            }
            else
            {
                sc.Stop();
            }
            sc.Refresh();
        }
    }
}
