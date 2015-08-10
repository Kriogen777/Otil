namespace AIOSystemUtility3
{
    partial class CPUSimpleControl
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
            this.CPUNameTxt = new System.Windows.Forms.Label();
            this.DetailsBtn = new System.Windows.Forms.Button();
            this.CPUSimplePanel = new System.Windows.Forms.Panel();
            this.grapher1 = new AIOSystemUtility3.Grapher();
            this.HandlesTxt = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ProcessesTxt = new System.Windows.Forms.Label();
            this.ThreadsTxt = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CoresTxt = new System.Windows.Forms.Label();
            this.ProcessorsTxt = new System.Windows.Forms.Label();
            this.VirtualizationTxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CPUMaxSpeedTxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CPUSpeedTxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CPUUtilizationTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CPUSimplePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 65);
            this.label1.TabIndex = 10;
            this.label1.Text = "Processor";
            // 
            // CPUNameTxt
            // 
            this.CPUNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUNameTxt.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUNameTxt.Location = new System.Drawing.Point(237, 48);
            this.CPUNameTxt.Name = "CPUNameTxt";
            this.CPUNameTxt.Size = new System.Drawing.Size(347, 47);
            this.CPUNameTxt.TabIndex = 14;
            this.CPUNameTxt.Text = "Unknown";
            this.CPUNameTxt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DetailsBtn
            // 
            this.DetailsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsBtn.FlatAppearance.BorderSize = 0;
            this.DetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailsBtn.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.DetailsBtn.Location = new System.Drawing.Point(1, 700);
            this.DetailsBtn.Name = "DetailsBtn";
            this.DetailsBtn.Size = new System.Drawing.Size(598, 26);
            this.DetailsBtn.TabIndex = 19;
            this.DetailsBtn.Text = "Details";
            this.DetailsBtn.UseVisualStyleBackColor = true;
            this.DetailsBtn.Click += new System.EventHandler(this.DetailsBtn_Click);
            // 
            // CPUSimplePanel
            // 
            this.CPUSimplePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUSimplePanel.Controls.Add(this.grapher1);
            this.CPUSimplePanel.Controls.Add(this.HandlesTxt);
            this.CPUSimplePanel.Controls.Add(this.DetailsBtn);
            this.CPUSimplePanel.Controls.Add(this.label18);
            this.CPUSimplePanel.Controls.Add(this.ProcessesTxt);
            this.CPUSimplePanel.Controls.Add(this.ThreadsTxt);
            this.CPUSimplePanel.Controls.Add(this.label15);
            this.CPUSimplePanel.Controls.Add(this.label16);
            this.CPUSimplePanel.Controls.Add(this.CoresTxt);
            this.CPUSimplePanel.Controls.Add(this.ProcessorsTxt);
            this.CPUSimplePanel.Controls.Add(this.VirtualizationTxt);
            this.CPUSimplePanel.Controls.Add(this.label8);
            this.CPUSimplePanel.Controls.Add(this.label7);
            this.CPUSimplePanel.Controls.Add(this.label6);
            this.CPUSimplePanel.Controls.Add(this.CPUMaxSpeedTxt);
            this.CPUSimplePanel.Controls.Add(this.label5);
            this.CPUSimplePanel.Controls.Add(this.CPUSpeedTxt);
            this.CPUSimplePanel.Controls.Add(this.label4);
            this.CPUSimplePanel.Controls.Add(this.CPUUtilizationTxt);
            this.CPUSimplePanel.Controls.Add(this.label2);
            this.CPUSimplePanel.Controls.Add(this.label1);
            this.CPUSimplePanel.Controls.Add(this.CPUNameTxt);
            this.CPUSimplePanel.Location = new System.Drawing.Point(0, 0);
            this.CPUSimplePanel.Name = "CPUSimplePanel";
            this.CPUSimplePanel.Size = new System.Drawing.Size(600, 726);
            this.CPUSimplePanel.TabIndex = 34;
            // 
            // grapher1
            // 
            this.grapher1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grapher1.Location = new System.Drawing.Point(31, 89);
            this.grapher1.Name = "grapher1";
            this.grapher1.Size = new System.Drawing.Size(553, 339);
            this.grapher1.TabIndex = 52;
            // 
            // HandlesTxt
            // 
            this.HandlesTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HandlesTxt.AutoSize = true;
            this.HandlesTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HandlesTxt.Location = new System.Drawing.Point(402, 635);
            this.HandlesTxt.Name = "HandlesTxt";
            this.HandlesTxt.Size = new System.Drawing.Size(20, 25);
            this.HandlesTxt.TabIndex = 51;
            this.HandlesTxt.Text = "-";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(304, 635);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 25);
            this.label18.TabIndex = 50;
            this.label18.Text = "Handles:";
            // 
            // ProcessesTxt
            // 
            this.ProcessesTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessesTxt.AutoSize = true;
            this.ProcessesTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessesTxt.Location = new System.Drawing.Point(402, 585);
            this.ProcessesTxt.Name = "ProcessesTxt";
            this.ProcessesTxt.Size = new System.Drawing.Size(20, 25);
            this.ProcessesTxt.TabIndex = 49;
            this.ProcessesTxt.Text = "-";
            // 
            // ThreadsTxt
            // 
            this.ThreadsTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ThreadsTxt.AutoSize = true;
            this.ThreadsTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreadsTxt.Location = new System.Drawing.Point(402, 610);
            this.ThreadsTxt.Name = "ThreadsTxt";
            this.ThreadsTxt.Size = new System.Drawing.Size(20, 25);
            this.ThreadsTxt.TabIndex = 48;
            this.ThreadsTxt.Text = "-";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(304, 610);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 25);
            this.label15.TabIndex = 47;
            this.label15.Text = "Threads:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(304, 585);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 25);
            this.label16.TabIndex = 46;
            this.label16.Text = "Processes:";
            // 
            // CoresTxt
            // 
            this.CoresTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CoresTxt.AutoSize = true;
            this.CoresTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoresTxt.Location = new System.Drawing.Point(500, 435);
            this.CoresTxt.Name = "CoresTxt";
            this.CoresTxt.Size = new System.Drawing.Size(20, 25);
            this.CoresTxt.TabIndex = 45;
            this.CoresTxt.Text = "-";
            // 
            // ProcessorsTxt
            // 
            this.ProcessorsTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessorsTxt.AutoSize = true;
            this.ProcessorsTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessorsTxt.Location = new System.Drawing.Point(500, 460);
            this.ProcessorsTxt.Name = "ProcessorsTxt";
            this.ProcessorsTxt.Size = new System.Drawing.Size(20, 25);
            this.ProcessorsTxt.TabIndex = 44;
            this.ProcessorsTxt.Text = "-";
            // 
            // VirtualizationTxt
            // 
            this.VirtualizationTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VirtualizationTxt.AutoSize = true;
            this.VirtualizationTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VirtualizationTxt.Location = new System.Drawing.Point(500, 485);
            this.VirtualizationTxt.Name = "VirtualizationTxt";
            this.VirtualizationTxt.Size = new System.Drawing.Size(20, 25);
            this.VirtualizationTxt.TabIndex = 43;
            this.VirtualizationTxt.Text = "-";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(304, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "Virtualization Enabled:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(304, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Logical Processors:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "Cores:";
            // 
            // CPUMaxSpeedTxt
            // 
            this.CPUMaxSpeedTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CPUMaxSpeedTxt.AutoSize = true;
            this.CPUMaxSpeedTxt.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUMaxSpeedTxt.Location = new System.Drawing.Point(27, 645);
            this.CPUMaxSpeedTxt.Name = "CPUMaxSpeedTxt";
            this.CPUMaxSpeedTxt.Size = new System.Drawing.Size(28, 37);
            this.CPUMaxSpeedTxt.TabIndex = 39;
            this.CPUMaxSpeedTxt.Text = "-";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 615);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 30);
            this.label5.TabIndex = 38;
            this.label5.Text = "Maximum Speed";
            // 
            // CPUSpeedTxt
            // 
            this.CPUSpeedTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CPUSpeedTxt.AutoSize = true;
            this.CPUSpeedTxt.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUSpeedTxt.Location = new System.Drawing.Point(27, 553);
            this.CPUSpeedTxt.Name = "CPUSpeedTxt";
            this.CPUSpeedTxt.Size = new System.Drawing.Size(28, 37);
            this.CPUSpeedTxt.TabIndex = 37;
            this.CPUSpeedTxt.Text = "-";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 30);
            this.label4.TabIndex = 36;
            this.label4.Text = "Speed";
            // 
            // CPUUtilizationTxt
            // 
            this.CPUUtilizationTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CPUUtilizationTxt.AutoSize = true;
            this.CPUUtilizationTxt.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUUtilizationTxt.Location = new System.Drawing.Point(27, 461);
            this.CPUUtilizationTxt.Name = "CPUUtilizationTxt";
            this.CPUUtilizationTxt.Size = new System.Drawing.Size(28, 37);
            this.CPUUtilizationTxt.TabIndex = 35;
            this.CPUUtilizationTxt.Text = "-";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 30);
            this.label2.TabIndex = 34;
            this.label2.Text = "Utilization";
            // 
            // CPUSimpleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CPUSimplePanel);
            this.Name = "CPUSimpleControl";
            this.Size = new System.Drawing.Size(600, 726);
            this.VisibleChanged += new System.EventHandler(this.CPUSimpleControl_VisibleChanged);
            this.CPUSimplePanel.ResumeLayout(false);
            this.CPUSimplePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CPUNameTxt;
        private System.Windows.Forms.Button DetailsBtn;
        private System.Windows.Forms.Panel CPUSimplePanel;
        private System.Windows.Forms.Label HandlesTxt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label ProcessesTxt;
        private System.Windows.Forms.Label ThreadsTxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label CoresTxt;
        private System.Windows.Forms.Label ProcessorsTxt;
        private System.Windows.Forms.Label VirtualizationTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CPUMaxSpeedTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CPUSpeedTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CPUUtilizationTxt;
        private System.Windows.Forms.Label label2;
        private Grapher grapher1;
    }
}
