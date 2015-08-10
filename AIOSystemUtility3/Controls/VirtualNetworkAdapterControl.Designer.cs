namespace AIOSystemUtility3
{
    partial class VirtualNetworkAdapterControl
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
            this.TypeTxt = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PhysicalTxt = new System.Windows.Forms.Label();
            this.ManufacturerTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TypeTxt
            // 
            this.TypeTxt.AutoSize = true;
            this.TypeTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeTxt.Location = new System.Drawing.Point(175, 25);
            this.TypeTxt.Name = "TypeTxt";
            this.TypeTxt.Size = new System.Drawing.Size(20, 25);
            this.TypeTxt.TabIndex = 90;
            this.TypeTxt.Text = "-";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(3, 25);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(54, 25);
            this.label38.TabIndex = 89;
            this.label38.Text = "Type:";
            // 
            // NameTxt
            // 
            this.NameTxt.AutoSize = true;
            this.NameTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.Location = new System.Drawing.Point(175, 0);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(20, 25);
            this.NameTxt.TabIndex = 88;
            this.NameTxt.Text = "-";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(3, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(64, 25);
            this.label36.TabIndex = 87;
            this.label36.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 92;
            this.label2.Text = "Manufacturer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 93;
            this.label3.Text = "Physical Adapter:";
            // 
            // PhysicalTxt
            // 
            this.PhysicalTxt.AutoSize = true;
            this.PhysicalTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhysicalTxt.Location = new System.Drawing.Point(175, 75);
            this.PhysicalTxt.Name = "PhysicalTxt";
            this.PhysicalTxt.Size = new System.Drawing.Size(20, 25);
            this.PhysicalTxt.TabIndex = 104;
            this.PhysicalTxt.Text = "-";
            // 
            // ManufacturerTxt
            // 
            this.ManufacturerTxt.AutoSize = true;
            this.ManufacturerTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerTxt.Location = new System.Drawing.Point(175, 50);
            this.ManufacturerTxt.Name = "ManufacturerTxt";
            this.ManufacturerTxt.Size = new System.Drawing.Size(20, 25);
            this.ManufacturerTxt.TabIndex = 103;
            this.ManufacturerTxt.Text = "-";
            // 
            // VirtualNetworkAdapterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PhysicalTxt);
            this.Controls.Add(this.ManufacturerTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypeTxt);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.label36);
            this.Name = "VirtualNetworkAdapterControl";
            this.Size = new System.Drawing.Size(530, 105);
            this.MouseEnter += new System.EventHandler(this.PhysicalNetworkAdapterControl_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TypeTxt;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label NameTxt;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PhysicalTxt;
        private System.Windows.Forms.Label ManufacturerTxt;
    }
}
