namespace AIOSystemUtility3
{
    partial class NETSummary
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
            this.DownTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpu = new System.Windows.Forms.Label();
            this.UpTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DownTxt
            // 
            this.DownTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DownTxt.AutoSize = true;
            this.DownTxt.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownTxt.Location = new System.Drawing.Point(82, 103);
            this.DownTxt.Name = "DownTxt";
            this.DownTxt.Size = new System.Drawing.Size(28, 37);
            this.DownTxt.TabIndex = 23;
            this.DownTxt.Text = "-";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "Down:";
            // 
            // gpu
            // 
            this.gpu.BackColor = System.Drawing.Color.Transparent;
            this.gpu.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu.Location = new System.Drawing.Point(-2, 7);
            this.gpu.Name = "gpu";
            this.gpu.Size = new System.Drawing.Size(118, 65);
            this.gpu.TabIndex = 21;
            this.gpu.Text = "NET";
            // 
            // UpTxt
            // 
            this.UpTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpTxt.AutoSize = true;
            this.UpTxt.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpTxt.Location = new System.Drawing.Point(82, 65);
            this.UpTxt.Name = "UpTxt";
            this.UpTxt.Size = new System.Drawing.Size(28, 37);
            this.UpTxt.TabIndex = 20;
            this.UpTxt.Text = "-";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 30);
            this.label2.TabIndex = 19;
            this.label2.Text = "Up:";
            // 
            // GPUSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DownTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gpu);
            this.Controls.Add(this.UpTxt);
            this.Controls.Add(this.label2);
            this.Name = "GPUSummary";
            this.Size = new System.Drawing.Size(210, 146);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DownTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label gpu;
        private System.Windows.Forms.Label UpTxt;
        private System.Windows.Forms.Label label2;
    }
}
