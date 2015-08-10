namespace AIOSystemUtility3
{
    partial class HDDControl
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
            this.NameTxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CapacityTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TempTxt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PartitionPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // NameTxt
            // 
            this.NameTxt.AutoSize = true;
            this.NameTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.Location = new System.Drawing.Point(199, 2);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(20, 25);
            this.NameTxt.TabIndex = 65;
            this.NameTxt.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 64;
            this.label5.Text = "Name:";
            // 
            // CapacityTxt
            // 
            this.CapacityTxt.AutoSize = true;
            this.CapacityTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapacityTxt.Location = new System.Drawing.Point(199, 27);
            this.CapacityTxt.Name = "CapacityTxt";
            this.CapacityTxt.Size = new System.Drawing.Size(20, 25);
            this.CapacityTxt.TabIndex = 63;
            this.CapacityTxt.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 62;
            this.label3.Text = "Capacity:";
            // 
            // TempTxt
            // 
            this.TempTxt.AutoSize = true;
            this.TempTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempTxt.Location = new System.Drawing.Point(199, 52);
            this.TempTxt.Name = "TempTxt";
            this.TempTxt.Size = new System.Drawing.Size(20, 25);
            this.TempTxt.TabIndex = 61;
            this.TempTxt.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 59;
            this.label7.Text = "Partitions:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 58;
            this.label6.Text = "Temperature:";
            // 
            // PartitionPanel
            // 
            this.PartitionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PartitionPanel.AutoScroll = true;
            this.PartitionPanel.Location = new System.Drawing.Point(8, 106);
            this.PartitionPanel.Name = "PartitionPanel";
            this.PartitionPanel.Size = new System.Drawing.Size(509, 140);
            this.PartitionPanel.TabIndex = 66;
            // 
            // HDDControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PartitionPanel);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CapacityTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TempTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "HDDControl";
            this.Size = new System.Drawing.Size(525, 249);
            this.MouseEnter += new System.EventHandler(this.HDDControl_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CapacityTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TempTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PartitionPanel;
    }
}
