namespace AIOSystemUtility3
{
    partial class CPUCoreControl
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
            this.MultiplierTxt = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.SpeedTxt = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.CoreNameTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MultiplierTxt
            // 
            this.MultiplierTxt.AutoSize = true;
            this.MultiplierTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplierTxt.Location = new System.Drawing.Point(125, 50);
            this.MultiplierTxt.Name = "MultiplierTxt";
            this.MultiplierTxt.Size = new System.Drawing.Size(20, 25);
            this.MultiplierTxt.TabIndex = 85;
            this.MultiplierTxt.Text = "-";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(27, 50);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(92, 25);
            this.label38.TabIndex = 84;
            this.label38.Text = "Multiplier:";
            // 
            // SpeedTxt
            // 
            this.SpeedTxt.AutoSize = true;
            this.SpeedTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedTxt.Location = new System.Drawing.Point(125, 25);
            this.SpeedTxt.Name = "SpeedTxt";
            this.SpeedTxt.Size = new System.Drawing.Size(20, 25);
            this.SpeedTxt.TabIndex = 83;
            this.SpeedTxt.Text = "-";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(27, 25);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(67, 25);
            this.label36.TabIndex = 82;
            this.label36.Text = "Speed:";
            // 
            // CoreNameTxt
            // 
            this.CoreNameTxt.AutoSize = true;
            this.CoreNameTxt.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoreNameTxt.Location = new System.Drawing.Point(3, 0);
            this.CoreNameTxt.Name = "CoreNameTxt";
            this.CoreNameTxt.Size = new System.Drawing.Size(77, 25);
            this.CoreNameTxt.TabIndex = 81;
            this.CoreNameTxt.Text = "Core #8";
            // 
            // CPUCoreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MultiplierTxt);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.SpeedTxt);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.CoreNameTxt);
            this.Name = "CPUCoreControl";
            this.Size = new System.Drawing.Size(320, 81);
            this.MouseEnter += new System.EventHandler(this.CPUCoreControl_MouseEnter);
            this.Resize += new System.EventHandler(this.CPUCoreControl_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MultiplierTxt;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label SpeedTxt;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label CoreNameTxt;
    }
}
