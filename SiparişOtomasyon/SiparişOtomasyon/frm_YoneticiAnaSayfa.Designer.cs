namespace SiparişOtomasyon
{
    partial class frm_YoneticiAnaSayfa
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.siparişDetayıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelenSiparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişDetayıToolStripMenuItem,
            this.ürünToolStripMenuItem,
            this.ürünToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // siparişDetayıToolStripMenuItem
            // 
            this.siparişDetayıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelenSiparişlerToolStripMenuItem});
            this.siparişDetayıToolStripMenuItem.Name = "siparişDetayıToolStripMenuItem";
            this.siparişDetayıToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.siparişDetayıToolStripMenuItem.Text = "Sipariş Detayı";
            // 
            // gelenSiparişlerToolStripMenuItem
            // 
            this.gelenSiparişlerToolStripMenuItem.Name = "gelenSiparişlerToolStripMenuItem";
            this.gelenSiparişlerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.gelenSiparişlerToolStripMenuItem.Text = "Gelen Siparişler";
            this.gelenSiparişlerToolStripMenuItem.Click += new System.EventHandler(this.gelenSiparişlerToolStripMenuItem_Click);
            // 
            // ürünToolStripMenuItem
            // 
            this.ürünToolStripMenuItem.Name = "ürünToolStripMenuItem";
            this.ürünToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // ürünToolStripMenuItem1
            // 
            this.ürünToolStripMenuItem1.Name = "ürünToolStripMenuItem1";
            this.ürünToolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
            this.ürünToolStripMenuItem1.Text = "Ürün";
            this.ürünToolStripMenuItem1.Click += new System.EventHandler(this.ürünToolStripMenuItem1_Click);
            // 
            // frm_YoneticiAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(632, 199);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frm_YoneticiAnaSayfa";
            this.Text = "frm_YoneticiAnaSayfa";
            this.Load += new System.EventHandler(this.frm_YoneticiAnaSayfa_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem siparişDetayıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelenSiparişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünToolStripMenuItem1;
    }
}



