namespace SiparişOtomasyon
{
    partial class frm_Urun
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.Btn_Yenile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Cikar = new System.Windows.Forms.Button();
            this.txtbx_UrunStokAdeti = new System.Windows.Forms.TextBox();
            this.txtbx_UrunTuru = new System.Windows.Forms.TextBox();
            this.lbl_UrunTuru = new System.Windows.Forms.Label();
            this.Btn_UrunEkle = new System.Windows.Forms.Button();
            this.lbl_UrunFiyati = new System.Windows.Forms.Label();
            this.txtbx_UrunFiyati = new System.Windows.Forms.TextBox();
            this.lbl_UrunStokAdeti = new System.Windows.Forms.Label();
            this.txtbx_UrunKodu = new System.Windows.Forms.TextBox();
            this.lbl_UrunKodu = new System.Windows.Forms.Label();
            this.txtbx_UrunAgirligi = new System.Windows.Forms.TextBox();
            this.lbl_UrunAdi = new System.Windows.Forms.Label();
            this.grpbx_Girdi = new System.Windows.Forms.GroupBox();
            this.Rdobttn_eylemsiz = new System.Windows.Forms.RadioButton();
            this.Rdobttn_Sil = new System.Windows.Forms.RadioButton();
            this.Rdobttn_UrunEkle = new System.Windows.Forms.RadioButton();
            this.Rdobttn_UrunDuzenle = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lstview_UrunKodu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstview_UrunStokAdeti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstview_UrunFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstview_UrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstview_UrunAgirligi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpbx_Girdi.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Yenile
            // 
            this.Btn_Yenile.Location = new System.Drawing.Point(349, 282);
            this.Btn_Yenile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Yenile.Name = "Btn_Yenile";
            this.Btn_Yenile.Size = new System.Drawing.Size(98, 28);
            this.Btn_Yenile.TabIndex = 4;
            this.Btn_Yenile.Text = "Yenile!";
            this.Btn_Yenile.UseVisualStyleBackColor = true;
            this.Btn_Yenile.Click += new System.EventHandler(this.Btn_Yenile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ürünler";
            // 
            // Btn_Cikar
            // 
            this.Btn_Cikar.Location = new System.Drawing.Point(451, 282);
            this.Btn_Cikar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Cikar.Name = "Btn_Cikar";
            this.Btn_Cikar.Size = new System.Drawing.Size(107, 28);
            this.Btn_Cikar.TabIndex = 7;
            this.Btn_Cikar.Text = "Çıkar!";
            this.Btn_Cikar.UseVisualStyleBackColor = true;
            this.Btn_Cikar.Click += new System.EventHandler(this.Btn_Cikar_Click);
            // 
            // txtbx_UrunStokAdeti
            // 
            this.txtbx_UrunStokAdeti.Location = new System.Drawing.Point(140, 63);
            this.txtbx_UrunStokAdeti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_UrunStokAdeti.Name = "txtbx_UrunStokAdeti";
            this.txtbx_UrunStokAdeti.Size = new System.Drawing.Size(151, 20);
            this.txtbx_UrunStokAdeti.TabIndex = 33;
            // 
            // txtbx_UrunTuru
            // 
            this.txtbx_UrunTuru.Location = new System.Drawing.Point(140, 128);
            this.txtbx_UrunTuru.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_UrunTuru.Name = "txtbx_UrunTuru";
            this.txtbx_UrunTuru.Size = new System.Drawing.Size(151, 20);
            this.txtbx_UrunTuru.TabIndex = 32;
            // 
            // lbl_UrunTuru
            // 
            this.lbl_UrunTuru.AutoSize = true;
            this.lbl_UrunTuru.Location = new System.Drawing.Point(83, 128);
            this.lbl_UrunTuru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UrunTuru.Name = "lbl_UrunTuru";
            this.lbl_UrunTuru.Size = new System.Drawing.Size(48, 13);
            this.lbl_UrunTuru.TabIndex = 31;
            this.lbl_UrunTuru.Text = "Ürün Adı";
            // 
            // Btn_UrunEkle
            // 
            this.Btn_UrunEkle.Location = new System.Drawing.Point(140, 197);
            this.Btn_UrunEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_UrunEkle.Name = "Btn_UrunEkle";
            this.Btn_UrunEkle.Size = new System.Drawing.Size(150, 29);
            this.Btn_UrunEkle.TabIndex = 30;
            this.Btn_UrunEkle.Text = "Ekle!";
            this.Btn_UrunEkle.UseVisualStyleBackColor = true;
            this.Btn_UrunEkle.Click += new System.EventHandler(this.Btn_UrunEkle_Click);
            // 
            // lbl_UrunFiyati
            // 
            this.lbl_UrunFiyati.AutoSize = true;
            this.lbl_UrunFiyati.Location = new System.Drawing.Point(79, 95);
            this.lbl_UrunFiyati.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UrunFiyati.Name = "lbl_UrunFiyati";
            this.lbl_UrunFiyati.Size = new System.Drawing.Size(57, 13);
            this.lbl_UrunFiyati.TabIndex = 25;
            this.lbl_UrunFiyati.Text = "Ürün Fiyatı";
            // 
            // txtbx_UrunFiyati
            // 
            this.txtbx_UrunFiyati.Location = new System.Drawing.Point(140, 95);
            this.txtbx_UrunFiyati.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_UrunFiyati.Name = "txtbx_UrunFiyati";
            this.txtbx_UrunFiyati.Size = new System.Drawing.Size(151, 20);
            this.txtbx_UrunFiyati.TabIndex = 24;
            // 
            // lbl_UrunStokAdeti
            // 
            this.lbl_UrunStokAdeti.AutoSize = true;
            this.lbl_UrunStokAdeti.Location = new System.Drawing.Point(56, 63);
            this.lbl_UrunStokAdeti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UrunStokAdeti.Name = "lbl_UrunStokAdeti";
            this.lbl_UrunStokAdeti.Size = new System.Drawing.Size(82, 13);
            this.lbl_UrunStokAdeti.TabIndex = 23;
            this.lbl_UrunStokAdeti.Text = "Ürün Stok Adeti";
            // 
            // txtbx_UrunKodu
            // 
            this.txtbx_UrunKodu.Location = new System.Drawing.Point(140, 30);
            this.txtbx_UrunKodu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_UrunKodu.Name = "txtbx_UrunKodu";
            this.txtbx_UrunKodu.Size = new System.Drawing.Size(151, 20);
            this.txtbx_UrunKodu.TabIndex = 22;
            // 
            // lbl_UrunKodu
            // 
            this.lbl_UrunKodu.AutoSize = true;
            this.lbl_UrunKodu.Location = new System.Drawing.Point(79, 30);
            this.lbl_UrunKodu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UrunKodu.Name = "lbl_UrunKodu";
            this.lbl_UrunKodu.Size = new System.Drawing.Size(58, 13);
            this.lbl_UrunKodu.TabIndex = 21;
            this.lbl_UrunKodu.Text = "Ürün Kodu";
            // 
            // txtbx_UrunAgirligi
            // 
            this.txtbx_UrunAgirligi.Location = new System.Drawing.Point(140, 160);
            this.txtbx_UrunAgirligi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_UrunAgirligi.Name = "txtbx_UrunAgirligi";
            this.txtbx_UrunAgirligi.Size = new System.Drawing.Size(151, 20);
            this.txtbx_UrunAgirligi.TabIndex = 20;
            // 
            // lbl_UrunAdi
            // 
            this.lbl_UrunAdi.AutoSize = true;
            this.lbl_UrunAdi.Location = new System.Drawing.Point(74, 162);
            this.lbl_UrunAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UrunAdi.Name = "lbl_UrunAdi";
            this.lbl_UrunAdi.Size = new System.Drawing.Size(63, 13);
            this.lbl_UrunAdi.TabIndex = 19;
            this.lbl_UrunAdi.Text = "Ürün Ağırlığı";
            // 
            // grpbx_Girdi
            // 
            this.grpbx_Girdi.Controls.Add(this.Btn_UrunEkle);
            this.grpbx_Girdi.Controls.Add(this.txtbx_UrunStokAdeti);
            this.grpbx_Girdi.Controls.Add(this.lbl_UrunAdi);
            this.grpbx_Girdi.Controls.Add(this.txtbx_UrunTuru);
            this.grpbx_Girdi.Controls.Add(this.txtbx_UrunAgirligi);
            this.grpbx_Girdi.Controls.Add(this.lbl_UrunTuru);
            this.grpbx_Girdi.Controls.Add(this.lbl_UrunKodu);
            this.grpbx_Girdi.Controls.Add(this.txtbx_UrunKodu);
            this.grpbx_Girdi.Controls.Add(this.lbl_UrunStokAdeti);
            this.grpbx_Girdi.Controls.Add(this.txtbx_UrunFiyati);
            this.grpbx_Girdi.Controls.Add(this.lbl_UrunFiyati);
            this.grpbx_Girdi.Location = new System.Drawing.Point(11, 282);
            this.grpbx_Girdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbx_Girdi.Name = "grpbx_Girdi";
            this.grpbx_Girdi.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbx_Girdi.Size = new System.Drawing.Size(321, 246);
            this.grpbx_Girdi.TabIndex = 34;
            this.grpbx_Girdi.TabStop = false;
            this.grpbx_Girdi.Text = "Bilgileri Giriniz:";
            // 
            // Rdobttn_eylemsiz
            // 
            this.Rdobttn_eylemsiz.AutoSize = true;
            this.Rdobttn_eylemsiz.Location = new System.Drawing.Point(22, 9);
            this.Rdobttn_eylemsiz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rdobttn_eylemsiz.Name = "Rdobttn_eylemsiz";
            this.Rdobttn_eylemsiz.Size = new System.Drawing.Size(109, 17);
            this.Rdobttn_eylemsiz.TabIndex = 35;
            this.Rdobttn_eylemsiz.TabStop = true;
            this.Rdobttn_eylemsiz.Text = "Hiçbir Şey Yapma";
            this.Rdobttn_eylemsiz.UseVisualStyleBackColor = true;
            this.Rdobttn_eylemsiz.CheckedChanged += new System.EventHandler(this.Rdobttn_eylemsiz_CheckedChanged);
            // 
            // Rdobttn_Sil
            // 
            this.Rdobttn_Sil.AutoSize = true;
            this.Rdobttn_Sil.Location = new System.Drawing.Point(130, 10);
            this.Rdobttn_Sil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rdobttn_Sil.Name = "Rdobttn_Sil";
            this.Rdobttn_Sil.Size = new System.Drawing.Size(62, 17);
            this.Rdobttn_Sil.TabIndex = 36;
            this.Rdobttn_Sil.TabStop = true;
            this.Rdobttn_Sil.Text = "Ürün Sil";
            this.Rdobttn_Sil.UseVisualStyleBackColor = true;
            this.Rdobttn_Sil.CheckedChanged += new System.EventHandler(this.Rdobttn_Sil_CheckedChanged);
            // 
            // Rdobttn_UrunEkle
            // 
            this.Rdobttn_UrunEkle.AutoSize = true;
            this.Rdobttn_UrunEkle.Location = new System.Drawing.Point(200, 10);
            this.Rdobttn_UrunEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rdobttn_UrunEkle.Name = "Rdobttn_UrunEkle";
            this.Rdobttn_UrunEkle.Size = new System.Drawing.Size(72, 17);
            this.Rdobttn_UrunEkle.TabIndex = 37;
            this.Rdobttn_UrunEkle.TabStop = true;
            this.Rdobttn_UrunEkle.Text = "Ürün Ekle";
            this.Rdobttn_UrunEkle.UseVisualStyleBackColor = true;
            this.Rdobttn_UrunEkle.CheckedChanged += new System.EventHandler(this.Rdobttn_UrunEkle_CheckedChanged);
            // 
            // Rdobttn_UrunDuzenle
            // 
            this.Rdobttn_UrunDuzenle.AutoSize = true;
            this.Rdobttn_UrunDuzenle.Location = new System.Drawing.Point(284, 10);
            this.Rdobttn_UrunDuzenle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rdobttn_UrunDuzenle.Name = "Rdobttn_UrunDuzenle";
            this.Rdobttn_UrunDuzenle.Size = new System.Drawing.Size(90, 17);
            this.Rdobttn_UrunDuzenle.TabIndex = 38;
            this.Rdobttn_UrunDuzenle.TabStop = true;
            this.Rdobttn_UrunDuzenle.Text = "Ürün Düzenle";
            this.Rdobttn_UrunDuzenle.UseVisualStyleBackColor = true;
            this.Rdobttn_UrunDuzenle.CheckedChanged += new System.EventHandler(this.Rdobttn_UrunDuzenle_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstview_UrunKodu,
            this.lstview_UrunStokAdeti,
            this.lstview_UrunFiyati,
            this.lstview_UrunAdi,
            this.lstview_UrunAgirligi});
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(11, 94);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(547, 184);
            this.listView1.TabIndex = 41;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lstview_UrunKodu
            // 
            this.lstview_UrunKodu.Text = "Ürün Kodu";
            this.lstview_UrunKodu.Width = 90;
            // 
            // lstview_UrunStokAdeti
            // 
            this.lstview_UrunStokAdeti.Text = "Ürün Stok Adeti";
            this.lstview_UrunStokAdeti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstview_UrunStokAdeti.Width = 108;
            // 
            // lstview_UrunFiyati
            // 
            this.lstview_UrunFiyati.Text = "Ürün Fiyatı";
            this.lstview_UrunFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstview_UrunFiyati.Width = 83;
            // 
            // lstview_UrunAdi
            // 
            this.lstview_UrunAdi.Text = "Ürün Adı";
            this.lstview_UrunAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstview_UrunAdi.Width = 150;
            // 
            // lstview_UrunAgirligi
            // 
            this.lstview_UrunAgirligi.Text = "Ürün Ağırlığı";
            this.lstview_UrunAgirligi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstview_UrunAgirligi.Width = 111;
            // 
            // Urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 548);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Rdobttn_UrunDuzenle);
            this.Controls.Add(this.Rdobttn_UrunEkle);
            this.Controls.Add(this.Rdobttn_Sil);
            this.Controls.Add(this.Rdobttn_eylemsiz);
            this.Controls.Add(this.grpbx_Girdi);
            this.Controls.Add(this.Btn_Cikar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Yenile);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Urun";
            this.Text = "frm_Urun";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Urun_FormClosing);
            this.Load += new System.EventHandler(this.Urun_Load);
            this.grpbx_Girdi.ResumeLayout(false);
            this.grpbx_Girdi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Yenile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Cikar;
        private System.Windows.Forms.TextBox txtbx_UrunStokAdeti;
        private System.Windows.Forms.TextBox txtbx_UrunTuru;
        private System.Windows.Forms.Label lbl_UrunTuru;
        private System.Windows.Forms.Button Btn_UrunEkle;
        private System.Windows.Forms.Label lbl_UrunFiyati;
        private System.Windows.Forms.TextBox txtbx_UrunFiyati;
        private System.Windows.Forms.Label lbl_UrunStokAdeti;
        private System.Windows.Forms.TextBox txtbx_UrunKodu;
        private System.Windows.Forms.Label lbl_UrunKodu;
        private System.Windows.Forms.TextBox txtbx_UrunAgirligi;
        private System.Windows.Forms.Label lbl_UrunAdi;
        private System.Windows.Forms.GroupBox grpbx_Girdi;
        private System.Windows.Forms.RadioButton Rdobttn_eylemsiz;
        private System.Windows.Forms.RadioButton Rdobttn_Sil;
        private System.Windows.Forms.RadioButton Rdobttn_UrunEkle;
        private System.Windows.Forms.RadioButton Rdobttn_UrunDuzenle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader lstview_UrunKodu;
        private System.Windows.Forms.ColumnHeader lstview_UrunStokAdeti;
        private System.Windows.Forms.ColumnHeader lstview_UrunFiyati;
        private System.Windows.Forms.ColumnHeader lstview_UrunAdi;
        private System.Windows.Forms.ColumnHeader lstview_UrunAgirligi;
    }
}

