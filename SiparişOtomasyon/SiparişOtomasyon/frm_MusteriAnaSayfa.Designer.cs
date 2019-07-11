namespace SiparişOtomasyon
{
    partial class frm_MusteriAnaSayfa
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.siparişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öncekiSiparişlerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişToolStripMenuItem,
            this.öncekiSiparişlerimToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(345, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // siparişToolStripMenuItem
            // 
            this.siparişToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişVerToolStripMenuItem,
            this.sepetimToolStripMenuItem});
            this.siparişToolStripMenuItem.Name = "siparişToolStripMenuItem";
            this.siparişToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.siparişToolStripMenuItem.Text = "Sipariş";
            // 
            // siparişVerToolStripMenuItem
            // 
            this.siparişVerToolStripMenuItem.Name = "siparişVerToolStripMenuItem";
            this.siparişVerToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.siparişVerToolStripMenuItem.Text = "Sipariş ver";
            this.siparişVerToolStripMenuItem.Click += new System.EventHandler(this.siparişVerToolStripMenuItem_Click);
            // 
            // sepetimToolStripMenuItem
            // 
            this.sepetimToolStripMenuItem.Name = "sepetimToolStripMenuItem";
            this.sepetimToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sepetimToolStripMenuItem.Text = "Sepetim";
            this.sepetimToolStripMenuItem.Click += new System.EventHandler(this.sepetimToolStripMenuItem_Click);
            // 
            // öncekiSiparişlerimToolStripMenuItem
            // 
            this.öncekiSiparişlerimToolStripMenuItem.Name = "öncekiSiparişlerimToolStripMenuItem";
            this.öncekiSiparişlerimToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.öncekiSiparişlerimToolStripMenuItem.Text = "Önceki Siparişlerim";
            this.öncekiSiparişlerimToolStripMenuItem.Click += new System.EventHandler(this.öncekiSiparişlerimToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 450);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(345, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // frm_MusteriAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 472);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frm_MusteriAnaSayfa";
            this.Text = "MusteriAnaSayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_MusteriAnaSayfa_FormClosing);
            this.Load += new System.EventHandler(this.frm_MusteriAnaSayfa_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem siparişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öncekiSiparişlerimToolStripMenuItem;
    }
}



