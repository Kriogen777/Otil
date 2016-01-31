using System;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class GPUControl : UserControl, IVisitor
    {
        GPUScraper GPU = GPUScraper.GetInstance();
        System.Timers.Timer UpdateGraph = new System.Timers.Timer(1000);
        public GPUControl()
        {
            InitializeComponent();
            Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            Visible = false;
            GPU.RegisterVisitor(this);
            grapher1.SetKeyItem(0, "Utilization (%)");
            grapher1.SetKeyItem(1, "Temperature (°C)");
            UpdateGraph.Elapsed += UpdateGraph_Elapsed;
        }

        void UpdateGraph_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            UpdateGraph.Stop();
            GPU.Lock.WaitOne();
            grapher1.UpdateGraph(0, GPU.Utilization);
            grapher1.UpdateGraph(1, GPU.GPUTempDouble);
            GPU.Lock.Release();
            UpdateGraph.Start();
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
            if (NameTxt.InvokeRequired)
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
                GPU.Lock.WaitOne();
                NameTxt.Text = GPU.Name;
                ManufacturerTxt.Text = GPU.Manufacturer;
                ChipTypeTxt.Text = GPU.ChipType;
                DACTypeTxt.Text = GPU.DACType;
                MemoryTxt.Text = GPU.MemCapacity + " MB";
                DispModeTxt.Text = GPU.MainScreenWidth + " x " + GPU.MainScreenHeight + " (" + GPU.MainScreenBitrate + " bit)(" + GPU.MainScreenRefreshRate + "Hz)";
                DriverVTxt.Text = GPU.DriverVersion;
                DriverDTxt.Text = GPU.DriverDate;
                //UtilizationTxt.Text = GPU.Utilization.ToString("0.## '%'");
                CoreClockTxt.Text = GPU.CoreClockSpeed.ToString("0.## MHz");
                MemClockSpeedTxt.Text = GPU.MemClockSpeed.ToString("0.## MHz");
                TempTxt.Text = GPU.GPUTemp;
                if(GPU.FanSpeed != 0)
                    FanSpeedTxt.Text = GPU.FanSpeed.ToString("0.## RPM");
                else
                    FanSpeedTxt.Text = GPU.FanPercent.ToString("0.## '%'");
                if (GPU.Voltage == 0)
                    CoreVoltageTxt.Text = " - ";
                else
                    CoreVoltageTxt.Text = GPU.Voltage.ToString("0.## V");
                GPU.Lock.Release();
            }
        }

        private void GPUControl_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                // Update Colours Here :D
                BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
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
