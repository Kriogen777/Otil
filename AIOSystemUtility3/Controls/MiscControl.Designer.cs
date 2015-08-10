namespace AIOSystemUtility3
{
    partial class MiscControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiscControl));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AboutTxt = new System.Windows.Forms.TextBox();
            this.ColourSchemePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddColorBtn = new System.Windows.Forms.Button();
            this.ColourSchemePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 65);
            this.label1.TabIndex = 16;
            this.label1.Text = "Miscellaneous";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 37);
            this.label2.TabIndex = 17;
            this.label2.Text = "Color Scheme:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 37);
            this.label7.TabIndex = 28;
            this.label7.Text = "About:";
            // 
            // AboutTxt
            // 
            this.AboutTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AboutTxt.Font = new System.Drawing.Font("Segoe UI Light", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutTxt.Location = new System.Drawing.Point(20, 327);
            this.AboutTxt.Multiline = true;
            this.AboutTxt.Name = "AboutTxt";
            this.AboutTxt.ReadOnly = true;
            this.AboutTxt.Size = new System.Drawing.Size(565, 323);
            this.AboutTxt.TabIndex = 29;
            this.AboutTxt.Text = resources.GetString("AboutTxt.Text");
            // 
            // ColourSchemePanel
            // 
            this.ColourSchemePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColourSchemePanel.Controls.Add(this.AddColorBtn);
            this.ColourSchemePanel.Location = new System.Drawing.Point(20, 152);
            this.ColourSchemePanel.Name = "ColourSchemePanel";
            this.ColourSchemePanel.Size = new System.Drawing.Size(565, 130);
            this.ColourSchemePanel.TabIndex = 30;
            // 
            // AddColorBtn
            // 
            this.AddColorBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddColorBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.AddColorBtn.FlatAppearance.BorderSize = 0;
            this.AddColorBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.AddColorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.AddColorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddColorBtn.Font = new System.Drawing.Font("Segoe UI Light", 21.25F);
            this.AddColorBtn.Location = new System.Drawing.Point(3, 3);
            this.AddColorBtn.Name = "AddColorBtn";
            this.AddColorBtn.Size = new System.Drawing.Size(116, 59);
            this.AddColorBtn.TabIndex = 1;
            this.AddColorBtn.Text = "Add";
            this.AddColorBtn.UseVisualStyleBackColor = false;
            this.AddColorBtn.Click += new System.EventHandler(this.AddColorBtn_Click);
            // 
            // MiscControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ColourSchemePanel);
            this.Controls.Add(this.AboutTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MiscControl";
            this.Size = new System.Drawing.Size(600, 726);
            this.ColourSchemePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AboutTxt;
        private System.Windows.Forms.FlowLayoutPanel ColourSchemePanel;
        private System.Windows.Forms.Button AddColorBtn;
    }
}
