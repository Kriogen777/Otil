namespace AIOSystemUtility3
{
    partial class MemModuleControl
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
            this.CapacityTxt = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.CoreNameTxt = new System.Windows.Forms.Label();
            this.SpeedTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FFactorTxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CapacityTxt
            // 
            this.CapacityTxt.AutoSize = true;
            this.CapacityTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapacityTxt.Location = new System.Drawing.Point(145, 25);
            this.CapacityTxt.Name = "CapacityTxt";
            this.CapacityTxt.Size = new System.Drawing.Size(20, 25);
            this.CapacityTxt.TabIndex = 88;
            this.CapacityTxt.Text = "-";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(27, 25);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(84, 25);
            this.label36.TabIndex = 87;
            this.label36.Text = "Capacity:";
            // 
            // CoreNameTxt
            // 
            this.CoreNameTxt.AutoSize = true;
            this.CoreNameTxt.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoreNameTxt.Location = new System.Drawing.Point(3, 0);
            this.CoreNameTxt.Name = "CoreNameTxt";
            this.CoreNameTxt.Size = new System.Drawing.Size(100, 25);
            this.CoreNameTxt.TabIndex = 86;
            this.CoreNameTxt.Text = "Module #8";
            // 
            // SpeedTxt
            // 
            this.SpeedTxt.AutoSize = true;
            this.SpeedTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedTxt.Location = new System.Drawing.Point(145, 75);
            this.SpeedTxt.Name = "SpeedTxt";
            this.SpeedTxt.Size = new System.Drawing.Size(20, 25);
            this.SpeedTxt.TabIndex = 94;
            this.SpeedTxt.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 93;
            this.label2.Text = "Speed:";
            // 
            // FFactorTxt
            // 
            this.FFactorTxt.AutoSize = true;
            this.FFactorTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FFactorTxt.Location = new System.Drawing.Point(145, 50);
            this.FFactorTxt.Name = "FFactorTxt";
            this.FFactorTxt.Size = new System.Drawing.Size(20, 25);
            this.FFactorTxt.TabIndex = 92;
            this.FFactorTxt.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 91;
            this.label4.Text = "Form Factor:";
            // 
            // MemModuleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SpeedTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FFactorTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CapacityTxt);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.CoreNameTxt);
            this.Name = "MemModuleControl";
            this.Size = new System.Drawing.Size(367, 111);
            this.MouseEnter += new System.EventHandler(this.MemModuleControl_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CapacityTxt;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label CoreNameTxt;
        private System.Windows.Forms.Label SpeedTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FFactorTxt;
        private System.Windows.Forms.Label label4;
    }
}
