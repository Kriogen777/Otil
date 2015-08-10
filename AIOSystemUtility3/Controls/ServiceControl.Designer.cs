namespace AIOSystemUtility3
{
    partial class ServiceControl
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
            this.SystemBtn = new System.Windows.Forms.Button();
            this.IsRunningTxt = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PIDTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartModeTxt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SystemBtn
            // 
            this.SystemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemBtn.BackColor = System.Drawing.SystemColors.Control;
            this.SystemBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SystemBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.SystemBtn.FlatAppearance.BorderSize = 0;
            this.SystemBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.SystemBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.SystemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SystemBtn.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.SystemBtn.Location = new System.Drawing.Point(349, 80);
            this.SystemBtn.Name = "SystemBtn";
            this.SystemBtn.Size = new System.Drawing.Size(173, 35);
            this.SystemBtn.TabIndex = 87;
            this.SystemBtn.Text = "Start / Stop Service";
            this.SystemBtn.UseVisualStyleBackColor = false;
            this.SystemBtn.Click += new System.EventHandler(this.SystemBtn_Click);
            // 
            // IsRunningTxt
            // 
            this.IsRunningTxt.AutoSize = true;
            this.IsRunningTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsRunningTxt.Location = new System.Drawing.Point(209, 85);
            this.IsRunningTxt.Name = "IsRunningTxt";
            this.IsRunningTxt.Size = new System.Drawing.Size(20, 25);
            this.IsRunningTxt.TabIndex = 86;
            this.IsRunningTxt.Text = "-";
            // 
            // NameTxt
            // 
            this.NameTxt.AutoSize = true;
            this.NameTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.Location = new System.Drawing.Point(209, 10);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(20, 25);
            this.NameTxt.TabIndex = 83;
            this.NameTxt.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 82;
            this.label5.Text = "Name:";
            // 
            // PIDTxt
            // 
            this.PIDTxt.AutoSize = true;
            this.PIDTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIDTxt.Location = new System.Drawing.Point(209, 35);
            this.PIDTxt.Name = "PIDTxt";
            this.PIDTxt.Size = new System.Drawing.Size(20, 25);
            this.PIDTxt.TabIndex = 81;
            this.PIDTxt.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 80;
            this.label3.Text = "PID:";
            // 
            // StartModeTxt
            // 
            this.StartModeTxt.AutoSize = true;
            this.StartModeTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartModeTxt.Location = new System.Drawing.Point(209, 60);
            this.StartModeTxt.Name = "StartModeTxt";
            this.StartModeTxt.Size = new System.Drawing.Size(20, 25);
            this.StartModeTxt.TabIndex = 79;
            this.StartModeTxt.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 78;
            this.label7.Text = "Is Running:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 77;
            this.label6.Text = "Start Mode:";
            // 
            // ServiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SystemBtn);
            this.Controls.Add(this.IsRunningTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PIDTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartModeTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "ServiceControl";
            this.Size = new System.Drawing.Size(525, 118);
            this.MouseEnter += new System.EventHandler(this.ServiceControl_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SystemBtn;
        private System.Windows.Forms.Label IsRunningTxt;
        private System.Windows.Forms.Label NameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PIDTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StartModeTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}
