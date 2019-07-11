namespace SiparişOtomasyon
{
    partial class frm_Sepetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sepetim));
            this.btn_sepettenciar = new System.Windows.Forms.Button();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.dttmpckr_SiparisTarihi = new System.Windows.Forms.DateTimePicker();
            this.urunadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunadedi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunucret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_SepetSiparisler = new System.Windows.Forms.ListView();
            this.btnn_Yenile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sepettenciar
            // 
            this.btn_sepettenciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sepettenciar.BackgroundImage")));
            this.btn_sepettenciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sepettenciar.Location = new System.Drawing.Point(87, 222);
            this.btn_sepettenciar.Name = "btn_sepettenciar";
            this.btn_sepettenciar.Size = new System.Drawing.Size(70, 33);
            this.btn_sepettenciar.TabIndex = 1;
            this.btn_sepettenciar.UseVisualStyleBackColor = true;
            this.btn_sepettenciar.Click += new System.EventHandler(this.btn_sepettenciar_Click);
            // 
            // btn_onayla
            // 
            this.btn_onayla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_onayla.BackgroundImage")));
            this.btn_onayla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_onayla.Location = new System.Drawing.Point(11, 222);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(70, 33);
            this.btn_onayla.TabIndex = 2;
            this.btn_onayla.UseVisualStyleBackColor = true;
            this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // dttmpckr_SiparisTarihi
            // 
            this.dttmpckr_SiparisTarihi.Location = new System.Drawing.Point(11, 260);
            this.dttmpckr_SiparisTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dttmpckr_SiparisTarihi.Name = "dttmpckr_SiparisTarihi";
            this.dttmpckr_SiparisTarihi.Size = new System.Drawing.Size(172, 20);
            this.dttmpckr_SiparisTarihi.TabIndex = 3;
            // 
            // urunadi
            // 
            this.urunadi.Text = "                      Ürün Adı";
            this.urunadi.Width = 188;
            // 
            // urunadedi
            // 
            this.urunadedi.Text = "Ürün Adedi";
            this.urunadedi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.urunadedi.Width = 140;
            // 
            // urunucret
            // 
            this.urunucret.Text = "Sipariş Tutarı";
            this.urunucret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.urunucret.Width = 177;
            // 
            // list_SepetSiparisler
            // 
            this.list_SepetSiparisler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.urunadi,
            this.urunadedi,
            this.urunucret});
            this.list_SepetSiparisler.GridLines = true;
            this.list_SepetSiparisler.Location = new System.Drawing.Point(11, 1);
            this.list_SepetSiparisler.Name = "list_SepetSiparisler";
            this.list_SepetSiparisler.Size = new System.Drawing.Size(511, 215);
            this.list_SepetSiparisler.TabIndex = 0;
            this.list_SepetSiparisler.UseCompatibleStateImageBehavior = false;
            this.list_SepetSiparisler.View = System.Windows.Forms.View.Details;
            // 
            // btnn_Yenile
            // 
            this.btnn_Yenile.Location = new System.Drawing.Point(177, 221);
            this.btnn_Yenile.Margin = new System.Windows.Forms.Padding(2);
            this.btnn_Yenile.Name = "btnn_Yenile";
            this.btnn_Yenile.Size = new System.Drawing.Size(98, 34);
            this.btnn_Yenile.TabIndex = 4;
            this.btnn_Yenile.Text = "Yenile!";
            this.btnn_Yenile.UseVisualStyleBackColor = true;
            this.btnn_Yenile.Click += new System.EventHandler(this.btnn_Yenile_Click);
            // 
            // frm_Sepetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(546, 305);
            this.Controls.Add(this.btnn_Yenile);
            this.Controls.Add(this.dttmpckr_SiparisTarihi);
            this.Controls.Add(this.btn_onayla);
            this.Controls.Add(this.btn_sepettenciar);
            this.Controls.Add(this.list_SepetSiparisler);
            this.Name = "frm_Sepetim";
            this.Text = "frm_Sepetim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Sepetim_FormClosing);
            this.Load += new System.EventHandler(this.frm_Sepetim_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_sepettenciar;
        private System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.DateTimePicker dttmpckr_SiparisTarihi;
        private System.Windows.Forms.ColumnHeader urunadi;
        private System.Windows.Forms.ColumnHeader urunadedi;
        private System.Windows.Forms.ColumnHeader urunucret;
        private System.Windows.Forms.ListView list_SepetSiparisler;
        private System.Windows.Forms.Button btnn_Yenile;
    }
}