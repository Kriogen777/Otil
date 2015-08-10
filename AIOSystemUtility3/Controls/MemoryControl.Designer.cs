namespace AIOSystemUtility3
{
    partial class MemoryControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.TotalTxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UsedTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AvailableTxt = new System.Windows.Forms.Label();
            this.UtilizationTxt = new System.Windows.Forms.Label();
            this.ModulesTxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PageCapTxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PageCapRemTxt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CommitedTxt = new System.Windows.Forms.Label();
            this.CachedTxt = new System.Windows.Forms.Label();
            this.PagedPoolTxt = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.NonPagedPoolTxt = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ModulePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Memory";
            // 
            // TotalTxt
            // 
            this.TotalTxt.AutoSize = true;
            this.TotalTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTxt.Location = new System.Drawing.Point(158, 107);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.Size = new System.Drawing.Size(20, 25);
            this.TotalTxt.TabIndex = 59;
            this.TotalTxt.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 58;
            this.label5.Text = "Total Capacity:";
            // 
            // UsedTxt
            // 
            this.UsedTxt.AutoSize = true;
            this.UsedTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsedTxt.Location = new System.Drawing.Point(158, 132);
            this.UsedTxt.Name = "UsedTxt";
            this.UsedTxt.Size = new System.Drawing.Size(20, 25);
            this.UsedTxt.TabIndex = 57;
            this.UsedTxt.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 56;
            this.label3.Text = "In Use:";
            // 
            // AvailableTxt
            // 
            this.AvailableTxt.AutoSize = true;
            this.AvailableTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableTxt.Location = new System.Drawing.Point(158, 157);
            this.AvailableTxt.Name = "AvailableTxt";
            this.AvailableTxt.Size = new System.Drawing.Size(20, 25);
            this.AvailableTxt.TabIndex = 55;
            this.AvailableTxt.Text = "-";
            // 
            // UtilizationTxt
            // 
            this.UtilizationTxt.AutoSize = true;
            this.UtilizationTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UtilizationTxt.Location = new System.Drawing.Point(158, 182);
            this.UtilizationTxt.Name = "UtilizationTxt";
            this.UtilizationTxt.Size = new System.Drawing.Size(20, 25);
            this.UtilizationTxt.TabIndex = 54;
            this.UtilizationTxt.Text = "-";
            // 
            // ModulesTxt
            // 
            this.ModulesTxt.AutoSize = true;
            this.ModulesTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModulesTxt.Location = new System.Drawing.Point(158, 207);
            this.ModulesTxt.Name = "ModulesTxt";
            this.ModulesTxt.Size = new System.Drawing.Size(20, 25);
            this.ModulesTxt.TabIndex = 53;
            this.ModulesTxt.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 52;
            this.label8.Text = "Modules:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "Utilization:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 50;
            this.label6.Text = "Available:";
            // 
            // PageCapTxt
            // 
            this.PageCapTxt.AutoSize = true;
            this.PageCapTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageCapTxt.Location = new System.Drawing.Point(437, 107);
            this.PageCapTxt.Name = "PageCapTxt";
            this.PageCapTxt.Size = new System.Drawing.Size(20, 25);
            this.PageCapTxt.TabIndex = 69;
            this.PageCapTxt.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 68;
            this.label4.Text = "Page Capacity:";
            // 
            // PageCapRemTxt
            // 
            this.PageCapRemTxt.AutoSize = true;
            this.PageCapRemTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageCapRemTxt.Location = new System.Drawing.Point(437, 132);
            this.PageCapRemTxt.Name = "PageCapRemTxt";
            this.PageCapRemTxt.Size = new System.Drawing.Size(20, 25);
            this.PageCapRemTxt.TabIndex = 67;
            this.PageCapRemTxt.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(247, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 25);
            this.label10.TabIndex = 66;
            this.label10.Text = "Page Cap. Remaining:";
            // 
            // CommitedTxt
            // 
            this.CommitedTxt.AutoSize = true;
            this.CommitedTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommitedTxt.Location = new System.Drawing.Point(437, 207);
            this.CommitedTxt.Name = "CommitedTxt";
            this.CommitedTxt.Size = new System.Drawing.Size(20, 25);
            this.CommitedTxt.TabIndex = 65;
            this.CommitedTxt.Text = "-";
            // 
            // CachedTxt
            // 
            this.CachedTxt.AutoSize = true;
            this.CachedTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CachedTxt.Location = new System.Drawing.Point(437, 232);
            this.CachedTxt.Name = "CachedTxt";
            this.CachedTxt.Size = new System.Drawing.Size(20, 25);
            this.CachedTxt.TabIndex = 64;
            this.CachedTxt.Text = "-";
            // 
            // PagedPoolTxt
            // 
            this.PagedPoolTxt.AutoSize = true;
            this.PagedPoolTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PagedPoolTxt.Location = new System.Drawing.Point(437, 157);
            this.PagedPoolTxt.Name = "PagedPoolTxt";
            this.PagedPoolTxt.Size = new System.Drawing.Size(20, 25);
            this.PagedPoolTxt.TabIndex = 63;
            this.PagedPoolTxt.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(247, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 25);
            this.label14.TabIndex = 62;
            this.label14.Text = "Paged Pool:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(247, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 25);
            this.label15.TabIndex = 61;
            this.label15.Text = "Cached";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(247, 207);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 25);
            this.label16.TabIndex = 60;
            this.label16.Text = "Commited:";
            // 
            // NonPagedPoolTxt
            // 
            this.NonPagedPoolTxt.AutoSize = true;
            this.NonPagedPoolTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NonPagedPoolTxt.Location = new System.Drawing.Point(438, 182);
            this.NonPagedPoolTxt.Name = "NonPagedPoolTxt";
            this.NonPagedPoolTxt.Size = new System.Drawing.Size(20, 25);
            this.NonPagedPoolTxt.TabIndex = 71;
            this.NonPagedPoolTxt.Text = "-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(248, 182);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(145, 25);
            this.label18.TabIndex = 70;
            this.label18.Text = "Non Paged Pool:";
            // 
            // ModulePanel
            // 
            this.ModulePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ModulePanel.Location = new System.Drawing.Point(31, 304);
            this.ModulePanel.Name = "ModulePanel";
            this.ModulePanel.Size = new System.Drawing.Size(538, 398);
            this.ModulePanel.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 73;
            this.label2.Text = "Memory Modules:";
            // 
            // MemoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModulePanel);
            this.Controls.Add(this.NonPagedPoolTxt);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.PageCapTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PageCapRemTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CommitedTxt);
            this.Controls.Add(this.CachedTxt);
            this.Controls.Add(this.PagedPoolTxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TotalTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UsedTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AvailableTxt);
            this.Controls.Add(this.UtilizationTxt);
            this.Controls.Add(this.ModulesTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "MemoryControl";
            this.Size = new System.Drawing.Size(600, 726);
            this.VisibleChanged += new System.EventHandler(this.MemoryControl_VisibleChanged);
            this.Resize += new System.EventHandler(this.MemoryControl_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label UsedTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AvailableTxt;
        private System.Windows.Forms.Label UtilizationTxt;
        private System.Windows.Forms.Label ModulesTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PageCapTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PageCapRemTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label CommitedTxt;
        private System.Windows.Forms.Label CachedTxt;
        private System.Windows.Forms.Label PagedPoolTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label NonPagedPoolTxt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel ModulePanel;
        private System.Windows.Forms.Label label2;
    }
}
