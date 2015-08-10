namespace AIOSystemUtility3
{
    partial class NetworkDetailControl
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
            this.OverviewBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DetailsTxt = new System.Windows.Forms.Label();
            this.AdapterPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // OverviewBtn
            // 
            this.OverviewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OverviewBtn.FlatAppearance.BorderSize = 0;
            this.OverviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverviewBtn.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.OverviewBtn.Location = new System.Drawing.Point(1, 699);
            this.OverviewBtn.Name = "OverviewBtn";
            this.OverviewBtn.Size = new System.Drawing.Size(598, 26);
            this.OverviewBtn.TabIndex = 79;
            this.OverviewBtn.Text = "Overview";
            this.OverviewBtn.UseVisualStyleBackColor = true;
            this.OverviewBtn.Click += new System.EventHandler(this.OverviewBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 65);
            this.label1.TabIndex = 77;
            this.label1.Text = "Network";
            // 
            // DetailsTxt
            // 
            this.DetailsTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsTxt.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsTxt.Location = new System.Drawing.Point(231, 38);
            this.DetailsTxt.Name = "DetailsTxt";
            this.DetailsTxt.Size = new System.Drawing.Size(347, 47);
            this.DetailsTxt.TabIndex = 78;
            this.DetailsTxt.Text = "Details";
            this.DetailsTxt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AdapterPanel
            // 
            this.AdapterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdapterPanel.AutoScroll = true;
            this.AdapterPanel.Location = new System.Drawing.Point(31, 78);
            this.AdapterPanel.Name = "AdapterPanel";
            this.AdapterPanel.Size = new System.Drawing.Size(538, 615);
            this.AdapterPanel.TabIndex = 80;
            // 
            // NetworkDetailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdapterPanel);
            this.Controls.Add(this.OverviewBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DetailsTxt);
            this.Name = "NetworkDetailControl";
            this.Size = new System.Drawing.Size(600, 726);
            this.VisibleChanged += new System.EventHandler(this.NetworkDetailControl_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OverviewBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DetailsTxt;
        private System.Windows.Forms.Panel AdapterPanel;
    }
}
