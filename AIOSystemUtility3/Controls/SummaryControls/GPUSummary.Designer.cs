namespace AIOSystemUtility3
{
    partial class GPUSummary
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
            this.TempTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpu = new System.Windows.Forms.Label();
            this.UtilizationTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TempTxt
            // 
            this.TempTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TempTxt.AutoSize = true;
            this.TempTxt.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempTxt.Location = new System.Drawing.Point(62, 103);
            this.TempTxt.Name = "TempTxt";
            this.TempTxt.Size = new System.Drawing.Size(28, 37);
            this.TempTxt.TabIndex = 23;
            this.TempTxt.Text = "-";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "Temp:";
            // 
            // gpu
            // 
            this.gpu.BackColor = System.Drawing.Color.Transparent;
            this.gpu.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu.Location = new System.Drawing.Point(-2, 7);
            this.gpu.Name = "gpu";
            this.gpu.Size = new System.Drawing.Size(118, 65);
            this.gpu.TabIndex = 21;
            this.gpu.Text = "GPU";
            // 
            // UtilizationTxt
            // 
            this.UtilizationTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UtilizationTxt.AutoSize = true;
            this.UtilizationTxt.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UtilizationTxt.Location = new System.Drawing.Point(106, 66);
            this.UtilizationTxt.Name = "UtilizationTxt";
            this.UtilizationTxt.Size = new System.Drawing.Size(28, 37);
            this.UtilizationTxt.TabIndex = 20;
            this.UtilizationTxt.Text = "-";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 30);
            this.label2.TabIndex = 19;
            this.label2.Text = "Utilization:";
            // 
            // GPUSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TempTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gpu);
            this.Controls.Add(this.UtilizationTxt);
            this.Controls.Add(this.label2);
            this.Name = "GPUSummary";
            this.Size = new System.Drawing.Size(210, 146);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TempTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label gpu;
        private System.Windows.Forms.Label UtilizationTxt;
        private System.Windows.Forms.Label label2;
    }
}
