namespace SiparişOtomasyon
{
    partial class frm_SiparisVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SiparisVer));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.cmbx_UrunAdlari = new System.Windows.Forms.ComboBox();
            this.lbl_urunsec = new System.Windows.Forms.Label();
            this.lbl_urunadet = new System.Windows.Forms.Label();
            this.txt_urunadet = new System.Windows.Forms.TextBox();
            this.btn_sepeteekle = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lstview_UrunKodu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstview_UrunStokAdeti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstview_UrunFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstview_UrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstview_UrunAgirligi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cmbx_UrunAdlari
            // 
            this.cmbx_UrunAdlari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_UrunAdlari.FormattingEnabled = true;
            this.cmbx_UrunAdlari.Location = new System.Drawing.Point(107, 175);
            this.cmbx_UrunAdlari.Name = "cmbx_UrunAdlari";
            this.cmbx_UrunAdlari.Size = new System.Drawing.Size(121, 21);
            this.cmbx_UrunAdlari.TabIndex = 0;
            // 
            // lbl_urunsec
            // 
            this.lbl_urunsec.AutoSize = true;
            this.lbl_urunsec.Location = new System.Drawing.Point(12, 178);
            this.lbl_urunsec.Name = "lbl_urunsec";
            this.lbl_urunsec.Size = new System.Drawing.Size(67, 13);
            this.lbl_urunsec.TabIndex = 1;
            this.lbl_urunsec.Text = "Ürün Seçiniz";
            // 
            // lbl_urunadet
            // 
            this.lbl_urunadet.AutoSize = true;
            this.lbl_urunadet.Location = new System.Drawing.Point(12, 212);
            this.lbl_urunadet.Name = "lbl_urunadet";
            this.lbl_urunadet.Size = new System.Drawing.Size(88, 13);
            this.lbl_urunadet.TabIndex = 2;
            this.lbl_urunadet.Text = "Ürün Adeti Giriniz";
            // 
            // txt_urunadet
            // 
            this.txt_urunadet.Location = new System.Drawing.Point(107, 205);
            this.txt_urunadet.Name = "txt_urunadet";
            this.txt_urunadet.Size = new System.Drawing.Size(121, 20);
            this.txt_urunadet.TabIndex = 3;
            this.txt_urunadet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_urunadet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_urunadet_TextChanged);
            // 
            // btn_sepeteekle
            // 
            this.btn_sepeteekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sepeteekle.BackgroundImage")));
            this.btn_sepeteekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sepeteekle.Location = new System.Drawing.Point(250, 175);
            this.btn_sepeteekle.Name = "btn_sepeteekle";
            this.btn_sepeteekle.Size = new System.Drawing.Size(93, 50);
            this.btn_sepeteekle.TabIndex = 4;
            this.btn_sepeteekle.UseVisualStyleBackColor = true;
            this.btn_sepeteekle.Click += new System.EventHandler(this.btn_sepeteekle_Click);
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
            this.listView1.Location = new System.Drawing.Point(11, 11);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(547, 159);
            this.listView1.TabIndex = 42;
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
            // frm_SiparisVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(575, 253);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_sepeteekle);
            this.Controls.Add(this.txt_urunadet);
            this.Controls.Add(this.lbl_urunadet);
            this.Controls.Add(this.lbl_urunsec);
            this.Controls.Add(this.cmbx_UrunAdlari);
            this.Name = "frm_SiparisVer";
            this.Text = "frm_SiparisVer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_SiparisVer_FormClosing);
            this.Load += new System.EventHandler(this.frm_SiparisVer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbx_UrunAdlari;
        private System.Windows.Forms.Label lbl_urunsec;
        private System.Windows.Forms.Label lbl_urunadet;
        private System.Windows.Forms.TextBox txt_urunadet;
        private System.Windows.Forms.Button btn_sepeteekle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader lstview_UrunKodu;
        private System.Windows.Forms.ColumnHeader lstview_UrunStokAdeti;
        private System.Windows.Forms.ColumnHeader lstview_UrunFiyati;
        private System.Windows.Forms.ColumnHeader lstview_UrunAdi;
        private System.Windows.Forms.ColumnHeader lstview_UrunAgirligi;
    }
}