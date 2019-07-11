namespace SiparişOtomasyon
{
    partial class frm_Siparis
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
            this.list_musteriSepetSiparisler = new System.Windows.Forms.ListView();
            this.list_GelenSiparisad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_GelenSiparisuadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_GelenSiparisuaded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_GelenSiparisuucret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_GelenSiparistarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_GelenSiparisadres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_KargoyaVerilisTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dttmpckr_KargoyaVerilisTarih = new System.Windows.Forms.DateTimePicker();
            this.bttn_KargoyaVer = new System.Windows.Forms.Button();
            this.bttn_Yenile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_musteriSepetSiparisler
            // 
            this.list_musteriSepetSiparisler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_GelenSiparisad,
            this.list_GelenSiparisuadi,
            this.list_GelenSiparisuaded,
            this.list_GelenSiparisuucret,
            this.list_GelenSiparistarih,
            this.list_GelenSiparisadres,
            this.list_KargoyaVerilisTarihi});
            this.list_musteriSepetSiparisler.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            this.list_musteriSepetSiparisler.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.list_musteriSepetSiparisler.Location = new System.Drawing.Point(12, 11);
            this.list_musteriSepetSiparisler.Name = "list_musteriSepetSiparisler";
            this.list_musteriSepetSiparisler.Size = new System.Drawing.Size(1268, 331);
            this.list_musteriSepetSiparisler.TabIndex = 2;
            this.list_musteriSepetSiparisler.UseCompatibleStateImageBehavior = false;
            this.list_musteriSepetSiparisler.View = System.Windows.Forms.View.Details;
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
            // dttmpckr_KargoyaVerilisTarih
            // 
            this.dttmpckr_KargoyaVerilisTarih.Location = new System.Drawing.Point(343, 350);
            this.dttmpckr_KargoyaVerilisTarih.Margin = new System.Windows.Forms.Padding(2);
            this.dttmpckr_KargoyaVerilisTarih.Name = "dttmpckr_KargoyaVerilisTarih";
            this.dttmpckr_KargoyaVerilisTarih.Size = new System.Drawing.Size(151, 20);
            this.dttmpckr_KargoyaVerilisTarih.TabIndex = 3;
            // 
            // bttn_KargoyaVer
            // 
            this.bttn_KargoyaVer.Location = new System.Drawing.Point(148, 347);
            this.bttn_KargoyaVer.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_KargoyaVer.Name = "bttn_KargoyaVer";
            this.bttn_KargoyaVer.Size = new System.Drawing.Size(175, 23);
            this.bttn_KargoyaVer.TabIndex = 4;
            this.bttn_KargoyaVer.Text = "Kargoya Verildi İşaretle";
            this.bttn_KargoyaVer.UseVisualStyleBackColor = true;
            this.bttn_KargoyaVer.Click += new System.EventHandler(this.bttn_KargoyaVer_Click);
            // 
            // bttn_Yenile
            // 
            this.bttn_Yenile.Location = new System.Drawing.Point(11, 347);
            this.bttn_Yenile.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_Yenile.Name = "bttn_Yenile";
            this.bttn_Yenile.Size = new System.Drawing.Size(133, 23);
            this.bttn_Yenile.TabIndex = 5;
            this.bttn_Yenile.Text = "Yenile!";
            this.bttn_Yenile.UseVisualStyleBackColor = true;
            this.bttn_Yenile.Click += new System.EventHandler(this.bttn_Yenile_Click);
            // 
            // frm_Siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1305, 502);
            this.Controls.Add(this.bttn_Yenile);
            this.Controls.Add(this.bttn_KargoyaVer);
            this.Controls.Add(this.dttmpckr_KargoyaVerilisTarih);
            this.Controls.Add(this.list_musteriSepetSiparisler);
            this.Name = "frm_Siparis";
            this.Text = "Sipariş";
            this.Load += new System.EventHandler(this.frm_GelenSiparis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list_musteriSepetSiparisler;
        private System.Windows.Forms.ColumnHeader list_GelenSiparisuadi;
        private System.Windows.Forms.ColumnHeader list_GelenSiparisuaded;
        private System.Windows.Forms.ColumnHeader list_GelenSiparisuucret;
        private System.Windows.Forms.ColumnHeader list_GelenSiparistarih;
        private System.Windows.Forms.ColumnHeader list_GelenSiparisad;
        private System.Windows.Forms.ColumnHeader list_GelenSiparisadres;
        private System.Windows.Forms.DateTimePicker dttmpckr_KargoyaVerilisTarih;
        private System.Windows.Forms.ColumnHeader list_KargoyaVerilisTarihi;
        private System.Windows.Forms.Button bttn_KargoyaVer;
        private System.Windows.Forms.Button bttn_Yenile;
    }
}