namespace AIOSystemUtility3
{
    partial class ColourSchemeSelector
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
            this.components = new System.ComponentModel.Container();
            this.ColTxt = new System.Windows.Forms.Label();
            this.ColBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeColourSchemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColTxt
            // 
            this.ColTxt.AutoSize = true;
            this.ColTxt.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColTxt.Location = new System.Drawing.Point(3, 0);
            this.ColTxt.Name = "ColTxt";
            this.ColTxt.Size = new System.Drawing.Size(109, 23);
            this.ColTxt.TabIndex = 21;
            this.ColTxt.Text = "Content Text";
            // 
            // ColBtn
            // 
            this.ColBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ColBtn.FlatAppearance.BorderSize = 0;
            this.ColBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColBtn.Location = new System.Drawing.Point(4, 26);
            this.ColBtn.Name = "ColBtn";
            this.ColBtn.Size = new System.Drawing.Size(108, 29);
            this.ColBtn.TabIndex = 20;
            this.ColBtn.Text = "Button Text";
            this.ColBtn.UseVisualStyleBackColor = false;
            this.ColBtn.Click += new System.EventHandler(this.ColBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeColourSchemeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(202, 26);
            // 
            // removeColourSchemeToolStripMenuItem
            // 
            this.removeColourSchemeToolStripMenuItem.Name = "removeColourSchemeToolStripMenuItem";
            this.removeColourSchemeToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.removeColourSchemeToolStripMenuItem.Text = "Remove Colour Scheme";
            this.removeColourSchemeToolStripMenuItem.Click += new System.EventHandler(this.removeColourSchemeToolStripMenuItem_Click);
            // 
            // ColourSchemeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.ColTxt);
            this.Controls.Add(this.ColBtn);
            this.Name = "ColourSchemeSelector";
            this.Size = new System.Drawing.Size(116, 59);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ColTxt;
        private System.Windows.Forms.Button ColBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeColourSchemeToolStripMenuItem;
    }
}
