namespace AIOSystemUtility3
{
    partial class NetworkSimpleControl
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
            this.NetworkSimplePanel = new System.Windows.Forms.Panel();
            this.VirtualCountTxt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grapher1 = new AIOSystemUtility3.Grapher();
            this.DetailsBtn = new System.Windows.Forms.Button();
            this.PhysicalCountTxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalKbsUpTxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalKbsDownTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OverviewTxt = new System.Windows.Forms.Label();
            this.NetworkSimplePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NetworkSimplePanel
            // 
            this.NetworkSimplePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NetworkSimplePanel.Controls.Add(this.VirtualCountTxt);
            this.NetworkSimplePanel.Controls.Add(this.label6);
            this.NetworkSimplePanel.Controls.Add(this.grapher1);
            this.NetworkSimplePanel.Controls.Add(this.DetailsBtn);
            this.NetworkSimplePanel.Controls.Add(this.PhysicalCountTxt);
            this.NetworkSimplePanel.Controls.Add(this.label5);
            this.NetworkSimplePanel.Controls.Add(this.TotalKbsUpTxt);
            this.NetworkSimplePanel.Controls.Add(this.label4);
            this.NetworkSimplePanel.Controls.Add(this.TotalKbsDownTxt);
            this.NetworkSimplePanel.Controls.Add(this.label2);
            this.NetworkSimplePanel.Controls.Add(this.label1);
            this.NetworkSimplePanel.Controls.Add(this.OverviewTxt);
            this.NetworkSimplePanel.Location = new System.Drawing.Point(0, 0);
            this.NetworkSimplePanel.Name = "NetworkSimplePanel";
            this.NetworkSimplePanel.Size = new System.Drawing.Size(600, 726);
            this.NetworkSimplePanel.TabIndex = 0;
            // 
            // VirtualCountTxt
            // 
            this.VirtualCountTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VirtualCountTxt.AutoSize = true;
            this.VirtualCountTxt.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VirtualCountTxt.Location = new System.Drawing.Point(216, 544);
            this.VirtualCountTxt.Name = "VirtualCountTxt";
            this.VirtualCountTxt.Size = new System.Drawing.Size(28, 37);
            this.VirtualCountTxt.TabIndex = 88;
            this.VirtualCountTxt.Text = "-";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 550);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 30);
            this.label6.TabIndex = 87;
            this.label6.Text = "Virtual Adapters:";
            // 
            // grapher1
            // 
            this.grapher1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grapher1.Location = new System.Drawing.Point(31, 79);
            this.grapher1.Name = "grapher1";
            this.grapher1.Size = new System.Drawing.Size(556, 339);
            this.grapher1.TabIndex = 86;
            // 
            // DetailsBtn
            // 
            this.DetailsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsBtn.FlatAppearance.BorderSize = 0;
            this.DetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailsBtn.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.DetailsBtn.Location = new System.Drawing.Point(1, 699);
            this.DetailsBtn.Name = "DetailsBtn";
            this.DetailsBtn.Size = new System.Drawing.Size(598, 26);
            this.DetailsBtn.TabIndex = 79;
            this.DetailsBtn.Text = "Details";
            this.DetailsBtn.UseVisualStyleBackColor = true;
            this.DetailsBtn.Click += new System.EventHandler(this.DetailsBtn_Click_1);
            // 
            // PhysicalCountTxt
            // 
            this.PhysicalCountTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PhysicalCountTxt.AutoSize = true;
            this.PhysicalCountTxt.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhysicalCountTxt.Location = new System.Drawing.Point(216, 514);
            this.PhysicalCountTxt.Name = "PhysicalCountTxt";
            this.PhysicalCountTxt.Size = new System.Drawing.Size(28, 37);
            this.PhysicalCountTxt.TabIndex = 85;
            this.PhysicalCountTxt.Text = "-";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 30);
            this.label5.TabIndex = 84;
            this.label5.Text = "Physical Adapters:";
            // 
            // TotalKbsUpTxt
            // 
            this.TotalKbsUpTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalKbsUpTxt.AutoSize = true;
            this.TotalKbsUpTxt.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalKbsUpTxt.Location = new System.Drawing.Point(200, 451);
            this.TotalKbsUpTxt.Name = "TotalKbsUpTxt";
            this.TotalKbsUpTxt.Size = new System.Drawing.Size(28, 37);
            this.TotalKbsUpTxt.TabIndex = 83;
            this.TotalKbsUpTxt.Text = "-";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 30);
            this.label4.TabIndex = 82;
            this.label4.Text = "Total Kb/s Up:";
            // 
            // TotalKbsDownTxt
            // 
            this.TotalKbsDownTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalKbsDownTxt.AutoSize = true;
            this.TotalKbsDownTxt.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalKbsDownTxt.Location = new System.Drawing.Point(200, 421);
            this.TotalKbsDownTxt.Name = "TotalKbsDownTxt";
            this.TotalKbsDownTxt.Size = new System.Drawing.Size(28, 37);
            this.TotalKbsDownTxt.TabIndex = 81;
            this.TotalKbsDownTxt.Text = "-";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 30);
            this.label2.TabIndex = 80;
            this.label2.Text = "Total Kb/s Down:";
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
            // OverviewTxt
            // 
            this.OverviewTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OverviewTxt.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewTxt.Location = new System.Drawing.Point(237, 38);
            this.OverviewTxt.Name = "OverviewTxt";
            this.OverviewTxt.Size = new System.Drawing.Size(350, 47);
            this.OverviewTxt.TabIndex = 78;
            this.OverviewTxt.Text = "Overview";
            this.OverviewTxt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NetworkSimpleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NetworkSimplePanel);
            this.Name = "NetworkSimpleControl";
            this.Size = new System.Drawing.Size(600, 726);
            this.VisibleChanged += new System.EventHandler(this.NetworkSimpleControl_VisibleChanged);
            this.NetworkSimplePanel.ResumeLayout(false);
            this.NetworkSimplePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NetworkSimplePanel;
        private System.Windows.Forms.Label VirtualCountTxt;
        private System.Windows.Forms.Label label6;
        private Grapher grapher1;
        private System.Windows.Forms.Button DetailsBtn;
        private System.Windows.Forms.Label PhysicalCountTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TotalKbsUpTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TotalKbsDownTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OverviewTxt;

    }
}
