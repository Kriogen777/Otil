namespace AIOSystemUtility3
{
    partial class CPUSummary
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
            this.CPUUtilizationTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CPUTxt = new System.Windows.Forms.Label();
            this.CPUTempTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CPUUtilizationTxt
            // 
            this.CPUUtilizationTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CPUUtilizationTxt.AutoSize = true;
            this.CPUUtilizationTxt.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUUtilizationTxt.Location = new System.Drawing.Point(105, 59);
            this.CPUUtilizationTxt.Name = "CPUUtilizationTxt";
            this.CPUUtilizationTxt.Size = new System.Drawing.Size(28, 37);
            this.CPUUtilizationTxt.TabIndex = 15;
            this.CPUUtilizationTxt.Text = "-";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Utilization:";
            // 
            // CPUTxt
            // 
            this.CPUTxt.BackColor = System.Drawing.Color.Transparent;
            this.CPUTxt.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTxt.Location = new System.Drawing.Point(-3, 0);
            this.CPUTxt.Name = "CPUTxt";
            this.CPUTxt.Size = new System.Drawing.Size(118, 65);
            this.CPUTxt.TabIndex = 16;
            this.CPUTxt.Text = "CPU";
            // 
            // CPUTempTxt
            // 
            this.CPUTempTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CPUTempTxt.AutoSize = true;
            this.CPUTempTxt.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTempTxt.Location = new System.Drawing.Point(61, 96);
            this.CPUTempTxt.Name = "CPUTempTxt";
            this.CPUTempTxt.Size = new System.Drawing.Size(28, 37);
            this.CPUTempTxt.TabIndex = 18;
            this.CPUTempTxt.Text = "-";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "Temp:";
            // 
            // CPUSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CPUTempTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CPUTxt);
            this.Controls.Add(this.CPUUtilizationTxt);
            this.Controls.Add(this.label2);
            this.Name = "CPUSummary";
            this.Size = new System.Drawing.Size(210, 146);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CPUUtilizationTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CPUTxt;
        private System.Windows.Forms.Label CPUTempTxt;
        private System.Windows.Forms.Label label3;
    }
}
