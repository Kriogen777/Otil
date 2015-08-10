namespace AIOSystemUtility3
{
    partial class RAMSummary
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
            this.InUseTxt = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.UtilizationTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InUseTxt
            // 
            this.InUseTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InUseTxt.AutoSize = true;
            this.InUseTxt.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InUseTxt.Location = new System.Drawing.Point(3, 72);
            this.InUseTxt.Name = "InUseTxt";
            this.InUseTxt.Size = new System.Drawing.Size(28, 37);
            this.InUseTxt.TabIndex = 27;
            this.InUseTxt.Text = "-";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(-2, 7);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(131, 65);
            this.name.TabIndex = 26;
            this.name.Text = "RAM";
            // 
            // UtilizationTxt
            // 
            this.UtilizationTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UtilizationTxt.AutoSize = true;
            this.UtilizationTxt.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UtilizationTxt.Location = new System.Drawing.Point(105, 110);
            this.UtilizationTxt.Name = "UtilizationTxt";
            this.UtilizationTxt.Size = new System.Drawing.Size(28, 37);
            this.UtilizationTxt.TabIndex = 25;
            this.UtilizationTxt.Text = "-";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "Utilization:";
            // 
            // RAMSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InUseTxt);
            this.Controls.Add(this.name);
            this.Controls.Add(this.UtilizationTxt);
            this.Controls.Add(this.label2);
            this.Name = "RAMSummary";
            this.Size = new System.Drawing.Size(210, 146);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InUseTxt;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label UtilizationTxt;
        private System.Windows.Forms.Label label2;
    }
}
