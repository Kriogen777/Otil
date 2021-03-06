﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class Form1 : Form
    {
        // Icon Hack: https://stackoverflow.com/questions/4048910/setting-a-different-taskbar-icon-to-the-icon-displayed-in-the-titlebar-c
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, IntPtr lParam);

        private const uint WM_SETICON = 0x80u;
        private const int ICON_SMALL = 0;

        // Tray Icon
        int trayMeasure = 0;
        System.Timers.Timer iconDrawTimer = new System.Timers.Timer(1000);
        
        // Colours
        Colours colours = Colours.GetInstance();

        // Scrapers
        ProcessScraper Processes = ProcessScraper.GetInstance();
        CPUScraper CPU = CPUScraper.GetInstance();
        GPUScraper GPU = GPUScraper.GetInstance();
        HDDScraper HDD = HDDScraper.GetInstance();
        MoboScraper Mobo = MoboScraper.GetInstance();
        NetworkScraper Net = NetworkScraper.GetInstance();
        RAMScraper RAM = RAMScraper.GetInstance();
        ServiceScraper Services = ServiceScraper.GetInstance();
        StartupScraper Startup = StartupScraper.GetInstance();
        SystemScraper Sys = SystemScraper.GetInstance();

        // Controls
        SystemControl SysCon = new SystemControl();
        CPUSimpleControl CPUSimpleCon = new CPUSimpleControl();
        GPUControl GPUCon = new GPUControl();
        MemoryControl RAMCon = new MemoryControl();
        HDDsControl HDDsCon = new HDDsControl();
        NetworkSimpleControl NetCon = new NetworkSimpleControl();
        ProcessesControl ProcessesCon = new ProcessesControl();
        ServicesControl ServicesCon = new ServicesControl();
        StartupProcessesControl StartupCon = new StartupProcessesControl();

        MiscControl MiscCon = null;

        // renderedOnce [] - horrible animation hack
        bool[] renderedOnce = { false, false, false, false, false, false, false, false, false, false, false};

        // Summary controls - to be scripted later
        SystemSummary SysSum = new SystemSummary();
        CPUSummary CPUSum = new CPUSummary();
        GPUSummary GPUSum = new GPUSummary();
        RAMSummary RAMSum = new RAMSummary();
        NETSummary NETSum = new NETSummary();

        // Index of selected page
        int PageIndex = -1; // defaulted to impossible index to always draw the first time
        Button PageButton = null;

        

        public Form1()
        {
            InitializeComponent();
            // Icon stuff
            using (Bitmap emptyImage = new Bitmap(1, 1))
            {
                SendMessage(this.Handle, WM_SETICON, ICON_SMALL, emptyImage.GetHicon());
            }
            iconDrawTimer.Elapsed += iconDrawTimer_Elapsed;
            iconDrawTimer.Start();

            ContentPanel.Controls.Add(SysCon);
            ContentPanel.Controls.Add(CPUSimpleCon);
            ContentPanel.Controls.Add(GPUCon);
            ContentPanel.Controls.Add(RAMCon);
            ContentPanel.Controls.Add(HDDsCon);
            ContentPanel.Controls.Add(NetCon);
            ContentPanel.Controls.Add(ProcessesCon);
            ContentPanel.Controls.Add(ServicesCon);
            ContentPanel.Controls.Add(StartupCon);
            MiscCon = new MiscControl(this);
            ContentPanel.Controls.Add(MiscCon);
            
            SummaryPanel.Controls.Add(SysSum);
            SummaryPanel.Controls.Add(CPUSum);
            SummaryPanel.Controls.Add(GPUSum);
            SummaryPanel.Controls.Add(RAMSum);
            SummaryPanel.Controls.Add(NETSum);
            AddControlsToSummary();

            StartPosition = FormStartPosition.CenterScreen;
            try
            {
                PageIndex = (int)AIOSystemUtility3.Properties.Settings.Default["SELECTED_PAGE"];
            }
            catch (System.Configuration.ConfigurationErrorsException ex)
            {
                Console.WriteLine(ex);
                PageIndex = 0;
            }

            SwitchControls(PageIndex);

            Console.WriteLine("=============== NOW LET THE STORY BEGIN ===============");
        }

        // Update Tray Icon
        void iconDrawTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            iconDrawTimer.Stop(); // Keeps the timer from spawning many threads all waiting for the locks
            
            if (notifyIcon1 != null)
            {
                Icon tempIcon = null;
                if (trayMeasure == 0)
                {
                    CPU.Lock.WaitOne();
                    tempIcon = GetIcon(CPU.CurrentUtilizationPercent.ToString("0."));
                    CPU.Lock.Release();
                }
                else if (trayMeasure == 1)
                {
                    CPU.Lock.WaitOne();
                    tempIcon = GetIcon(CPU.CPUTempDouble.ToString("0.°"));
                    CPU.Lock.Release();
                }
                else if (trayMeasure == 2)
                {
                    GPU.Lock.WaitOne();
                    tempIcon = GetIcon(GPU.Utilization.ToString("0."));
                    GPU.Lock.Release();
                }
                else if (trayMeasure == 3)
                {
                    GPU.Lock.WaitOne();
                    tempIcon = GetIcon(GPU.GPUTempDouble.ToString("0.°"));
                    GPU.Lock.Release();
                }
                if (tempIcon != null) notifyIcon1.Icon = tempIcon;
            }
            iconDrawTimer.Start();
        }

        private void AddControlsToSummary()
        {
            int top = 0;
            for (int i = 0; i < SummaryPanel.Controls.Count; i++)
            {
                SummaryPanel.Controls[i].Top = top;
                top += SummaryPanel.Controls[i].Height + 1;
            }
        }

        private void SwitchControls(int index)
        {
            int angle = 270; // From below
            if (index < PageIndex) angle = 90; // From above

            bool animate = true;
            if (PageIndex == index) animate = false;

            // Animate away currently visible control
            foreach (Control c in ContentPanel.Controls)
            {
                if (c.Visible)
                {
                    if (animate) Utils.Animate(c, Utils.Effect.Slide, 100, angle, renderedOnce[index]);
                    //else c.Visible = false;
                }
            }

            PageIndex = index;
            try
            {
                AIOSystemUtility3.Properties.Settings.Default["SELECTED_PAGE"] = PageIndex;
                AIOSystemUtility3.Properties.Settings.Default.Save();
            }
            catch (System.Configuration.ConfigurationErrorsException ex)
            {
                Console.WriteLine(ex);
            }
            
            
            UserControl displayMe = null;
            switch (index)
            {
                case 0: displayMe = SysCon; break;
                case 1: displayMe = CPUSimpleCon; break;
                case 2: displayMe = GPUCon; break;
                case 3: displayMe = RAMCon; break;
                case 4: displayMe = HDDsCon; break;
                case 5: displayMe = NetCon; break;
                case 6: break; // Motherboard - now on system
                case 7: displayMe = ProcessesCon; break;
                case 8: displayMe = ServicesCon; break;
                case 9: displayMe = StartupCon; break;
                case 10: displayMe = MiscCon; break;
            }
            if (animate) Utils.Animate(displayMe, Utils.Effect.Slide, 100, angle, renderedOnce[index]);
            else if (!renderedOnce[index]) displayMe.Visible = true;
            renderedOnce[index] = true;
            
            switch (index)
            {
                case 0: SwitchColours(SystemBtn);
                    break;
                case 1: SwitchColours(CPUBtn);
                    break;
                case 2: SwitchColours(GPUBtn);
                    break;
                case 3: SwitchColours(RAMBtn);
                    break;
                case 4: SwitchColours(HDDBtn);
                    break;
                case 5: SwitchColours(NetBtn);
                    break;
                case 7: SwitchColours(ProcessBtn);
                    break;
                case 8: SwitchColours(ServicesBtn);
                    break;
                case 9: SwitchColours(StartupBtn);
                    break;
                case 10: SwitchColours(SettingsBtn);
                    break;
            }

        }
        public void SwitchColours(Button btn = null)
        {
            if (btn != null) PageButton = btn;
            foreach (Control c in MenuPanel.Controls)
            {
                if (c is Button && c != PageButton)
                {
                    ((Button)c).BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][1];
                    ((Button)c).FlatAppearance.MouseOverBackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][2];
                    ((Button)c).FlatAppearance.MouseDownBackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
                    ((Button)c).FlatAppearance.BorderColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
                    ((Button)c).ForeColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][4];
                }
                else if (c is Button && c == PageButton)
                {
                    ((Button)c).BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
                    ((Button)c).FlatAppearance.MouseOverBackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
                    ((Button)c).FlatAppearance.MouseDownBackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
                    ((Button)c).FlatAppearance.BorderColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
                    ((Button)c).ForeColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][3];
                }
            }
            MenuPanel.BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][2];
            ContentPanel.BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][0];
            SummaryPanel.BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][2];
            spacerPanel.BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][1];

            SysSum.UpdateColour();
            CPUSum.UpdateColour();
            GPUSum.UpdateColour();
            RAMSum.UpdateColour();
            NETSum.UpdateColour();
        }

        private void SystemBtn_Click(object sender, EventArgs e)
        {
            SwitchControls(0);
        }

        private void CPUBtn_Click(object sender, EventArgs e)
        {
            SwitchControls(1);
        }

        private void GPUBtn_Click(object sender, EventArgs e)
        {
            SwitchControls(2);
        }

        private void RAMBtn_Click(object sender, EventArgs e)
        {
            SwitchControls(3);
        }

        private void HDDBtn_Click(object sender, EventArgs e)
        {
            SwitchControls(4);
        }

        private void NetBtn_Click(object sender, EventArgs e)
        {
            SwitchControls(5);
        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            SwitchControls(7);
        }

        private void ServicesBtn_Click(object sender, EventArgs e)
        {
            SwitchControls(8);
        }

        private void StartupBtn_Click(object sender, EventArgs e)
        {
            SwitchControls(9);
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SwitchControls(10);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            Processes.Lock.WaitOne();
            Processes.StopScraping();
            Processes.Lock.Release();
            CPU.Lock.WaitOne();
            CPU.StopScraping();
            CPU.Lock.Release();
            GPU.Lock.WaitOne();
            GPU.StopScraping();
            GPU.Lock.Release();
            HDD.Lock.WaitOne();
            HDD.StopScraping();
            HDD.Lock.Release();
            Mobo.Lock.WaitOne();
            Mobo.StopScraping();
            Mobo.Lock.Release();
            Net.Lock.WaitOne();
            Net.StopScraping();
            Net.Lock.Release();
            RAM.Lock.WaitOne();
            RAM.StopScraping();
            RAM.Lock.Release();
            Services.Lock.WaitOne();
            Services.StopScraping();
            Services.Lock.Release();
            Startup.Lock.WaitOne();
            Startup.StopScraping();
            Startup.Lock.Release();
            Sys.Lock.WaitOne();
            Sys.StopScraping();
            Sys.Lock.Release();

            iconDrawTimer.Stop();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void cPUUtilisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(ToolStripMenuItem item in TrayIconContextMenu.Items){
                item.Checked = false;
            }
            cPUUtilisationToolStripMenuItem.Checked = true;
            trayMeasure = 0;
        }

        private void cPUTemperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in TrayIconContextMenu.Items)
            {
                item.Checked = false;
            }
            cPUTemperatureToolStripMenuItem.Checked = true;
            trayMeasure = 1;
        }

        private void gPUUtilizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in TrayIconContextMenu.Items)
            {
                item.Checked = false;
            }
            gPUUtilizationToolStripMenuItem.Checked = true;
            trayMeasure = 2;
        }

        private void gPUTemperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in TrayIconContextMenu.Items)
            {
                item.Checked = false;
            }
            gPUTemperatureToolStripMenuItem.Checked = true;
            trayMeasure = 3;
        }

        // https://msdn.microsoft.com/en-us/library/system.drawing.icon.fromhandle(v=vs.90).aspx
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto)]
        extern static bool DestroyIcon(IntPtr handle);

        // Solution to draw text onto an Icon from : http://stackoverflow.com/a/5966965/4331033
        // Solution for GDI Object leak limit : http://stackoverflow.com/a/23256773/4331033
        Icon createdIcon = null;
        private Icon GetIcon(string text)
        {
            try
            {
                // Destroy the Icon first
                if (createdIcon != null)
                {
                    DestroyIcon(createdIcon.Handle);
                }

                //Create bitmap, kind of canvas
                Bitmap bitmap = new Bitmap(32, 32);

                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
                Icon icon = ((Icon)(resources.GetObject("notifyIcon1.Icon")));
                Font drawFont = new Font("Arial", 14, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.White);

                Graphics graphics = Graphics.FromImage(bitmap);

                graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                graphics.DrawIcon(icon, new Rectangle(0, 0, 32, 32));
                graphics.DrawString(text, drawFont, drawBrush, 0, 4);

                IntPtr iconPtr = bitmap.GetHicon();
                createdIcon = Icon.FromHandle(iconPtr);
                
                drawFont.Dispose();
                drawBrush.Dispose();
                graphics.Dispose();
                bitmap.Dispose();

                return createdIcon;
            }
            catch (Exception e)
            {
                try
                {
                    Console.WriteLine("Origin message: " + e.Message);
                    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
                    createdIcon = ((Icon)(resources.GetObject("notifyIcon1.Icon")));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Secondary message: " + ex.Message);
                    // Destroy the Icon
                    DestroyIcon(createdIcon.Handle);
                }
            }
            return createdIcon;
        }

    }
}
