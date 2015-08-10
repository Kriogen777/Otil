namespace AIOSystemUtility3
{
    partial class StartupProcessesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.TotalStartupsTxt = new System.Windows.Forms.Label();
            this.StartupPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 69;
            this.label2.Text = "Startup Processes:";
            // 
            // TotalStartupsTxt
            // 
            this.TotalStartupsTxt.AutoSize = true;
            this.TotalStartupsTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalStartupsTxt.Location = new System.Drawing.Point(195, 89);
            this.TotalStartupsTxt.Name = "TotalStartupsTxt";
            this.TotalStartupsTxt.Size = new System.Drawing.Size(20, 25);
            this.TotalStartupsTxt.TabIndex = 68;
            this.TotalStartupsTxt.Text = "-";
            // 
            // StartupPanel
            // 
            this.StartupPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartupPanel.AutoScroll = true;
            this.StartupPanel.Location = new System.Drawing.Point(39, 117);
            this.StartupPanel.Name = "StartupPanel";
            this.StartupPanel.Size = new System.Drawing.Size(533, 585);
            this.StartupPanel.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 65);
            this.label1.TabIndex = 66;
            this.label1.Text = "Startup";
            // 
            // StartupProcessesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalStartupsTxt);
            this.Controls.Add(this.StartupPanel);
            this.Controls.Add(this.label1);
            this.Name = "StartupProcessesControl";
            this.Size = new System.Drawing.Size(600, 726);
            this.VisibleChanged += new System.EventHandler(this.StartupProcessesControl_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalStartupsTxt;
        private System.Windows.Forms.Panel StartupPanel;
        private System.Windows.Forms.Label label1;
    }
}
