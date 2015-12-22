namespace AIOSystemUtility3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.spacerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.StartupBtn = new System.Windows.Forms.Button();
            this.ServicesBtn = new System.Windows.Forms.Button();
            this.ProcessBtn = new System.Windows.Forms.Button();
            this.NetBtn = new System.Windows.Forms.Button();
            this.HDDBtn = new System.Windows.Forms.Button();
            this.RAMBtn = new System.Windows.Forms.Button();
            this.GPUBtn = new System.Windows.Forms.Button();
            this.CPUBtn = new System.Windows.Forms.Button();
            this.SystemBtn = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.SummaryPanel = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuPanel.SuspendLayout();
            this.spacerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MenuPanel.Controls.Add(this.spacerPanel);
            this.MenuPanel.Controls.Add(this.SettingsBtn);
            this.MenuPanel.Controls.Add(this.StartupBtn);
            this.MenuPanel.Controls.Add(this.ServicesBtn);
            this.MenuPanel.Controls.Add(this.ProcessBtn);
            this.MenuPanel.Controls.Add(this.NetBtn);
            this.MenuPanel.Controls.Add(this.HDDBtn);
            this.MenuPanel.Controls.Add(this.RAMBtn);
            this.MenuPanel.Controls.Add(this.GPUBtn);
            this.MenuPanel.Controls.Add(this.CPUBtn);
            this.MenuPanel.Controls.Add(this.SystemBtn);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 726);
            this.MenuPanel.TabIndex = 0;
            // 
            // spacerPanel
            // 
            this.spacerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.spacerPanel.BackColor = System.Drawing.SystemColors.Control;
            this.spacerPanel.Controls.Add(this.label1);
            this.spacerPanel.Location = new System.Drawing.Point(0, 660);
            this.spacerPanel.Name = "spacerPanel";
            this.spacerPanel.Size = new System.Drawing.Size(200, 66);
            this.spacerPanel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tim Headley";
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.SystemColors.Control;
            this.SettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SettingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.SettingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Segoe UI Light", 21.25F);
            this.SettingsBtn.Location = new System.Drawing.Point(0, 594);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(200, 65);
            this.SettingsBtn.TabIndex = 10;
            this.SettingsBtn.Text = "Misc.";
            this.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBtn.UseVisualStyleBackColor = false;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // StartupBtn
            // 
            this.StartupBtn.BackColor = System.Drawing.SystemColors.Control;
            this.StartupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartupBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.StartupBtn.FlatAppearance.BorderSize = 0;
            this.StartupBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.StartupBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.StartupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartupBtn.Font = new System.Drawing.Font("Segoe UI Light", 21.25F);
            this.StartupBtn.Location = new System.Drawing.Point(0, 528);
            this.StartupBtn.Name = "StartupBtn";
            this.StartupBtn.Size = new System.Drawing.Size(200, 65);
            this.StartupBtn.TabIndex = 9;
            this.StartupBtn.Text = "Startup";
            this.StartupBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartupBtn.UseVisualStyleBackColor = false;
            this.StartupBtn.Click += new System.EventHandler(this.StartupBtn_Click);
            // 
            // ServicesBtn
            // 
            this.ServicesBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ServicesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ServicesBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ServicesBtn.FlatAppearance.BorderSize = 0;
            this.ServicesBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.ServicesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.ServicesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServicesBtn.Font = new System.Drawing.Font("Segoe UI Light", 21.25F);
            this.ServicesBtn.Location = new System.Drawing.Point(0, 462);
            this.ServicesBtn.Name = "ServicesBtn";
            this.ServicesBtn.Size = new System.Drawing.Size(200, 65);
            this.ServicesBtn.TabIndex = 8;
            this.ServicesBtn.Text = "Services";
            this.ServicesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ServicesBtn.UseVisualStyleBackColor = false;
            this.ServicesBtn.Click += new System.EventHandler(this.ServicesBtn_Click);
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ProcessBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProcessBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ProcessBtn.FlatAppearance.BorderSize = 0;
            this.ProcessBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.ProcessBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.ProcessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessBtn.Font = new System.Drawing.Font("Segoe UI Light", 21.25F);
            this.ProcessBtn.Location = new System.Drawing.Point(0, 396);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(200, 65);
            this.ProcessBtn.TabIndex = 7;
            this.ProcessBtn.Text = "Processes";
            this.ProcessBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProcessBtn.UseVisualStyleBackColor = false;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // NetBtn
            // 
            this.NetBtn.BackColor = System.Drawing.SystemColors.Control;
            this.NetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NetBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.NetBtn.FlatAppearance.BorderSize = 0;
            this.NetBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.NetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.NetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NetBtn.Font = new System.Drawing.Font("Segoe UI Light", 21.25F);
            this.NetBtn.Location = new System.Drawing.Point(0, 330);
            this.NetBtn.Name = "NetBtn";
            this.NetBtn.Size = new System.Drawing.Size(200, 65);
            this.NetBtn.TabIndex = 5;
            this.NetBtn.Text = "Network";
            this.NetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NetBtn.UseVisualStyleBackColor = false;
            this.NetBtn.Click += new System.EventHandler(this.NetBtn_Click);
            // 
            // HDDBtn
            // 
            this.HDDBtn.BackColor = System.Drawing.SystemColors.Control;
            this.HDDBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HDDBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.HDDBtn.FlatAppearance.BorderSize = 0;
            this.HDDBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.HDDBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.HDDBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HDDBtn.Font = new System.Drawing.Font("Segoe UI Light", 21.25F);
            this.HDDBtn.Location = new System.Drawing.Point(0, 264);
            this.HDDBtn.Name = "HDDBtn";
            this.HDDBtn.Size = new System.Drawing.Size(200, 65);
            this.HDDBtn.TabIndex = 4;
            this.HDDBtn.Text = "Hard Drives";
            this.HDDBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HDDBtn.UseVisualStyleBackColor = false;
            this.HDDBtn.Click += new System.EventHandler(this.HDDBtn_Click);
            // 
            // RAMBtn
            // 
            this.RAMBtn.BackColor = System.Drawing.SystemColors.Control;
            this.RAMBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RAMBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.RAMBtn.FlatAppearance.BorderSize = 0;
            this.RAMBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.RAMBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.RAMBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RAMBtn.Font = new System.Drawing.Font("Segoe UI Light", 21.25F);
            this.RAMBtn.Location = new System.Drawing.Point(0, 198);
            this.RAMBtn.Name = "RAMBtn";
            this.RAMBtn.Size = new System.Drawing.Size(200, 65);
            this.RAMBtn.TabIndex = 3;
            this.RAMBtn.Text = "Memory";
            this.RAMBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RAMBtn.UseVisualStyleBackColor = false;
            this.RAMBtn.Click += new System.EventHandler(this.RAMBtn_Click);
            // 
            // GPUBtn
            // 
            this.GPUBtn.BackColor = System.Drawing.SystemColors.Control;
            this.GPUBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GPUBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.GPUBtn.FlatAppearance.BorderSize = 0;
            this.GPUBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.GPUBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.GPUBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GPUBtn.Font = new System.Drawing.Font("Segoe UI Light", 21.25F);
            this.GPUBtn.Location = new System.Drawing.Point(0, 132);
            this.GPUBtn.Name = "GPUBtn";
            this.GPUBtn.Size = new System.Drawing.Size(200, 65);
            this.GPUBtn.TabIndex = 2;
            this.GPUBtn.Text = "Graphics Card";
            this.GPUBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GPUBtn.UseVisualStyleBackColor = false;
            this.GPUBtn.Click += new System.EventHandler(this.GPUBtn_Click);
            // 
            // CPUBtn
            // 
            this.CPUBtn.BackColor = System.Drawing.SystemColors.Control;
            this.CPUBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CPUBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.CPUBtn.FlatAppearance.BorderSize = 0;
            this.CPUBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.CPUBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.CPUBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPUBtn.Font = new System.Drawing.Font("Segoe UI Light", 21.25F);
            this.CPUBtn.Location = new System.Drawing.Point(0, 66);
            this.CPUBtn.Name = "CPUBtn";
            this.CPUBtn.Size = new System.Drawing.Size(200, 65);
            this.CPUBtn.TabIndex = 1;
            this.CPUBtn.Text = "Processor";
            this.CPUBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CPUBtn.UseVisualStyleBackColor = false;
            this.CPUBtn.Click += new System.EventHandler(this.CPUBtn_Click);
            // 
            // SystemBtn
            // 
            this.SystemBtn.BackColor = System.Drawing.SystemColors.Control;
            this.SystemBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SystemBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.SystemBtn.FlatAppearance.BorderSize = 0;
            this.SystemBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.SystemBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.SystemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SystemBtn.Font = new System.Drawing.Font("Segoe UI Light", 21.25F);
            this.SystemBtn.Location = new System.Drawing.Point(0, 0);
            this.SystemBtn.Name = "SystemBtn";
            this.SystemBtn.Size = new System.Drawing.Size(200, 65);
            this.SystemBtn.TabIndex = 0;
            this.SystemBtn.Text = "System";
            this.SystemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SystemBtn.UseVisualStyleBackColor = false;
            this.SystemBtn.Click += new System.EventHandler(this.SystemBtn_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ContentPanel.Location = new System.Drawing.Point(200, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(600, 726);
            this.ContentPanel.TabIndex = 1;
            // 
            // SummaryPanel
            // 
            this.SummaryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SummaryPanel.AutoScroll = true;
            this.SummaryPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SummaryPanel.Location = new System.Drawing.Point(800, 0);
            this.SummaryPanel.Name = "SummaryPanel";
            this.SummaryPanel.Size = new System.Drawing.Size(229, 726);
            this.SummaryPanel.TabIndex = 2;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Otil has minimised to system tray. Double click to reopen.";
            this.notifyIcon1.BalloonTipTitle = "Otil - Freshly Squeezed";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Otil";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 726);
            this.Controls.Add(this.SummaryPanel);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.MenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1045, 765);
            this.Name = "Form1";
            this.Text = "Otil - Freshly Squeezed";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.MenuPanel.ResumeLayout(false);
            this.spacerPanel.ResumeLayout(false);
            this.spacerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button SystemBtn;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Button StartupBtn;
        private System.Windows.Forms.Button ServicesBtn;
        private System.Windows.Forms.Button ProcessBtn;
        private System.Windows.Forms.Button NetBtn;
        private System.Windows.Forms.Button HDDBtn;
        private System.Windows.Forms.Button RAMBtn;
        private System.Windows.Forms.Button GPUBtn;
        private System.Windows.Forms.Button CPUBtn;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel SummaryPanel;
        private System.Windows.Forms.Panel spacerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;


    }
}

