using System;
using System.Collections;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class ServicesControl : UserControl, IVisitor
    {
        ServiceScraper Service = ServiceScraper.GetInstance();
        public ServiceControl[] services = null;
        public ServicesControl()
        {
            InitializeComponent();
            Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            Visible = false;
            Service.RegisterVisitor(this);
            ServicePanel.VerticalScroll.SmallChange = 122;
            ServicePanel.VerticalScroll.LargeChange = 462;
        }

        public void Update(Scraper s)
        {
            SetText();
        }

        delegate void SetTextCallback();
        SetTextCallback updateDelegate;
        private void SetText()
        {
            if (TotalServicesTxt.InvokeRequired)
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
                Service.Lock.WaitOne();
                int caretPosition = ServicePanel.VerticalScroll.Value;
                TotalServicesTxt.Text = Service.Services.Count.ToString();
                if (services == null || services.Length == 0 || services.Length != Service.Services.Count)
                {
                    ServicePanel.Controls.Clear();
                    ServicePanel.AutoScroll = false;
                    services = new ServiceControl[Service.Services.Count];
                    Service[] tempSortableArray = new Service[Service.Services.Count];
                    int lastBot = 0;
                    int index = 0;
                    foreach (DictionaryEntry pair in Service.Services)
                    {
                        tempSortableArray[index++] = (Service)pair.Value;
                    }
                    Array.Sort(tempSortableArray);
                    for (int i = 0; i < services.Length; i++)
                    {
                        services[i] = new ServiceControl(tempSortableArray[i], ServicePanel);
                        services[i].Top = lastBot + 4;
                        lastBot = services[i].Bottom;
                        services[i].Left = 4;
                        services[i].Width = ServicePanel.Width - SystemInformation.VerticalScrollBarWidth / 2;
                        ServicePanel.Controls.Add(services[i]);
                    }
                    ServicePanel.AutoScroll = true;
                    if (ServicePanel.VerticalScroll.Maximum < caretPosition)
                        caretPosition = ServicePanel.VerticalScroll.Maximum;
                }
                else
                {
                    for (int i = 0; i < services.Length; i++)
                    {
                        foreach (DictionaryEntry pair in Service.Services)
                        {
                            if (services[i].service.ProcessID == ((Service)pair.Value).ProcessID)
                            {
                                services[i].Update((Service)pair.Value);
                                break;
                            }
                        }
                    }
                }
                ServicePanel.VerticalScroll.Value = caretPosition;
                ServicePanel.PerformLayout();
                Service.Lock.Release();
            }
        }

        private void ServicesControl_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                // Update Colours Here :D
                BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
                ServicePanel.BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][1];
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
