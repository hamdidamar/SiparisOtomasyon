namespace SiparişOtomasyon
{
    partial class frm_OncekiSiparislerim
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.lstvw_MusteriTakip = new System.Windows.Forms.ListView();
            this.list_GelenSiparisad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_GelenSiparisuadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_GelenSiparisuaded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_GelenSiparisuucret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_GelenSiparistarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_GelenSiparisadres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_KargoyaVerilisTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstvw_MusteriTakip
            // 
            this.lstvw_MusteriTakip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstvw_MusteriTakip.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_GelenSiparisad,
            this.list_GelenSiparisuadi,
            this.list_GelenSiparisuaded,
            this.list_GelenSiparisuucret,
            this.list_GelenSiparistarih,
            this.list_GelenSiparisadres,
            this.list_KargoyaVerilisTarihi});
            this.lstvw_MusteriTakip.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            this.lstvw_MusteriTakip.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstvw_MusteriTakip.Location = new System.Drawing.Point(1, 12);
            this.lstvw_MusteriTakip.Name = "lstvw_MusteriTakip";
            this.lstvw_MusteriTakip.Size = new System.Drawing.Size(1258, 331);
            this.lstvw_MusteriTakip.TabIndex = 7;
            this.lstvw_MusteriTakip.UseCompatibleStateImageBehavior = false;
            this.lstvw_MusteriTakip.View = System.Windows.Forms.View.Details;
            // 
            // list_GelenSiparisad
            // 
            this.list_GelenSiparisad.Text = "          Tam Ad";
            this.list_GelenSiparisad.Width = 167;
            // 
            // list_GelenSiparisuadi
            // 
            this.list_GelenSiparisuadi.Text = "Ürün Adı";
            this.list_GelenSiparisuadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_GelenSiparisuadi.Width = 257;
            // 
            // list_GelenSiparisuaded
            // 
            this.list_GelenSiparisuaded.Text = "Ürün Adedi";
            this.list_GelenSiparisuaded.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_GelenSiparisuaded.Width = 96;
            // 
            // list_GelenSiparisuucret
            // 
            this.list_GelenSiparisuucret.Text = "Sipariş Tutarı";
            this.list_GelenSiparisuucret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_GelenSiparisuucret.Width = 108;
            // 
            // list_GelenSiparistarih
            // 
            this.list_GelenSiparistarih.Text = "Tarih";
            this.list_GelenSiparistarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_GelenSiparistarih.Width = 201;
            // 
            // list_GelenSiparisadres
            // 
            this.list_GelenSiparisadres.Text = "Adres";
            this.list_GelenSiparisadres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_GelenSiparisadres.Width = 239;
            // 
            // list_KargoyaVerilisTarihi
            // 
            this.list_KargoyaVerilisTarihi.Text = "Kargoya Veriliş Tarihi";
            this.list_KargoyaVerilisTarihi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_KargoyaVerilisTarihi.Width = 190;
            // 
            // OncekiSiparislerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 384);
            this.Controls.Add(this.lstvw_MusteriTakip);
            this.Name = "OncekiSiparislerim";
            this.Text = "OncekiSiparislerim";
            this.Load += new System.EventHandler(this.OncekiSiparislerim_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstvw_MusteriTakip;
        private System.Windows.Forms.ColumnHeader list_GelenSiparisad;
        private System.Windows.Forms.ColumnHeader list_GelenSiparisuadi;
        private System.Windows.Forms.ColumnHeader list_GelenSiparisuaded;
        private System.Windows.Forms.ColumnHeader list_GelenSiparisuucret;
        private System.Windows.Forms.ColumnHeader list_GelenSiparistarih;
        private System.Windows.Forms.ColumnHeader list_GelenSiparisadres;
        private System.Windows.Forms.ColumnHeader list_KargoyaVerilisTarihi;
    }
}