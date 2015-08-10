namespace AIOSystemUtility3
{
    partial class SystemSummary
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
            this.DayTxt = new System.Windows.Forms.Label();
            this.DateTxt = new System.Windows.Forms.Label();
            this.TimeSTxt = new System.Windows.Forms.Label();
            this.TimeHMTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DayTxt
            // 
            this.DayTxt.BackColor = System.Drawing.Color.Transparent;
            this.DayTxt.Font = new System.Drawing.Font("Segoe UI Light", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayTxt.Location = new System.Drawing.Point(1, 74);
            this.DayTxt.Name = "DayTxt";
            this.DayTxt.Size = new System.Drawing.Size(191, 28);
            this.DayTxt.TabIndex = 8;
            this.DayTxt.Text = "Wednesday";
            // 
            // DateTxt
            // 
            this.DateTxt.BackColor = System.Drawing.Color.Transparent;
            this.DateTxt.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTxt.Location = new System.Drawing.Point(2, 46);
            this.DateTxt.Name = "DateTxt";
            this.DateTxt.Size = new System.Drawing.Size(196, 38);
            this.DateTxt.TabIndex = 7;
            this.DateTxt.Text = "16 April 2015";
            // 
            // TimeSTxt
            // 
            this.TimeSTxt.BackColor = System.Drawing.Color.Transparent;
            this.TimeSTxt.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeSTxt.Location = new System.Drawing.Point(117, 17);
            this.TimeSTxt.Name = "TimeSTxt";
            this.TimeSTxt.Size = new System.Drawing.Size(47, 39);
            this.TimeSTxt.TabIndex = 6;
            this.TimeSTxt.Text = ":44";
            // 
            // TimeHMTxt
            // 
            this.TimeHMTxt.BackColor = System.Drawing.Color.Transparent;
            this.TimeHMTxt.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeHMTxt.Location = new System.Drawing.Point(-3, -9);
            this.TimeHMTxt.Name = "TimeHMTxt";
            this.TimeHMTxt.Size = new System.Drawing.Size(139, 65);
            this.TimeHMTxt.TabIndex = 5;
            this.TimeHMTxt.Text = "08:38";
            // 
            // SystemSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DayTxt);
            this.Controls.Add(this.DateTxt);
            this.Controls.Add(this.TimeSTxt);
            this.Controls.Add(this.TimeHMTxt);
            this.Name = "SystemSummary";
            this.Size = new System.Drawing.Size(210, 114);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DayTxt;
        private System.Windows.Forms.Label DateTxt;
        private System.Windows.Forms.Label TimeSTxt;
        private System.Windows.Forms.Label TimeHMTxt;
    }
}
