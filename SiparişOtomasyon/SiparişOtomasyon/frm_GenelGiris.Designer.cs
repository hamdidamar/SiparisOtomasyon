namespace SiparişOtomasyon
{
    partial class frm_GenelGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GenelGiris));
            this.lbl_musterikullaniciadi = new System.Windows.Forms.Label();
            this.lbl_musterisifre = new System.Windows.Forms.Label();
            this.txt_musterikadi = new System.Windows.Forms.TextBox();
            this.txt_musterisifre = new System.Windows.Forms.TextBox();
            this.btn_musterigirisbuton = new System.Windows.Forms.Button();
            this.btn_yonetici = new System.Windows.Forms.Button();
            this.txt_yoneticisifre = new System.Windows.Forms.TextBox();
            this.txt_yoneticikadi = new System.Windows.Forms.TextBox();
            this.lbl_yoneticisifre = new System.Windows.Forms.Label();
            this.lbl_yonetici = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_musterikullaniciadi
            // 
            this.lbl_musterikullaniciadi.AutoSize = true;
            this.lbl_musterikullaniciadi.BackColor = System.Drawing.Color.Lime;
            this.lbl_musterikullaniciadi.Location = new System.Drawing.Point(24, 46);
            this.lbl_musterikullaniciadi.Name = "lbl_musterikullaniciadi";
            this.lbl_musterikullaniciadi.Size = new System.Drawing.Size(101, 13);
            this.lbl_musterikullaniciadi.TabIndex = 2;
            this.lbl_musterikullaniciadi.Text = "Müşteri Kullanıcı Adı";
            // 
            // lbl_musterisifre
            // 
            this.lbl_musterisifre.AutoSize = true;
            this.lbl_musterisifre.BackColor = System.Drawing.Color.Lime;
            this.lbl_musterisifre.Location = new System.Drawing.Point(60, 105);
            this.lbl_musterisifre.Name = "lbl_musterisifre";
            this.lbl_musterisifre.Size = new System.Drawing.Size(65, 13);
            this.lbl_musterisifre.TabIndex = 3;
            this.lbl_musterisifre.Text = "Müşteri Şifre";
            // 
            // txt_musterikadi
            // 
            this.txt_musterikadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_musterikadi.Location = new System.Drawing.Point(131, 43);
            this.txt_musterikadi.Name = "txt_musterikadi";
            this.txt_musterikadi.Size = new System.Drawing.Size(100, 20);
            this.txt_musterikadi.TabIndex = 4;
            // 
            // txt_musterisifre
            // 
            this.txt_musterisifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_musterisifre.Location = new System.Drawing.Point(131, 98);
            this.txt_musterisifre.Name = "txt_musterisifre";
            this.txt_musterisifre.Size = new System.Drawing.Size(100, 20);
            this.txt_musterisifre.TabIndex = 5;
            this.txt_musterisifre.UseSystemPasswordChar = true;
            this.txt_musterisifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_musterisifre_TextChanged);
            // 
            // btn_musterigirisbuton
            // 
            this.btn_musterigirisbuton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_musterigirisbuton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_musterigirisbuton.Location = new System.Drawing.Point(131, 150);
            this.btn_musterigirisbuton.Name = "btn_musterigirisbuton";
            this.btn_musterigirisbuton.Size = new System.Drawing.Size(100, 23);
            this.btn_musterigirisbuton.TabIndex = 6;
            this.btn_musterigirisbuton.Text = "Müsteri Giriş ";
            this.btn_musterigirisbuton.UseVisualStyleBackColor = false;
            this.btn_musterigirisbuton.Click += new System.EventHandler(this.btn_musterigirisbuton_Click);
            // 
            // btn_yonetici
            // 
            this.btn_yonetici.BackColor = System.Drawing.Color.Yellow;
            this.btn_yonetici.Location = new System.Drawing.Point(148, 150);
            this.btn_yonetici.Name = "btn_yonetici";
            this.btn_yonetici.Size = new System.Drawing.Size(100, 23);
            this.btn_yonetici.TabIndex = 11;
            this.btn_yonetici.Text = "Yönetici Giriş ";
            this.btn_yonetici.UseVisualStyleBackColor = false;
            this.btn_yonetici.Click += new System.EventHandler(this.btn_yonetici_Click);
            // 
            // txt_yoneticisifre
            // 
            this.txt_yoneticisifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_yoneticisifre.Location = new System.Drawing.Point(148, 98);
            this.txt_yoneticisifre.Name = "txt_yoneticisifre";
            this.txt_yoneticisifre.Size = new System.Drawing.Size(100, 20);
            this.txt_yoneticisifre.TabIndex = 10;
            this.txt_yoneticisifre.UseSystemPasswordChar = true;
            this.txt_yoneticisifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_yoneticisifre_TextChanged);
            // 
            // txt_yoneticikadi
            // 
            this.txt_yoneticikadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_yoneticikadi.Location = new System.Drawing.Point(148, 43);
            this.txt_yoneticikadi.Name = "txt_yoneticikadi";
            this.txt_yoneticikadi.Size = new System.Drawing.Size(100, 20);
            this.txt_yoneticikadi.TabIndex = 9;
            // 
            // lbl_yoneticisifre
            // 
            this.lbl_yoneticisifre.AutoSize = true;
            this.lbl_yoneticisifre.Location = new System.Drawing.Point(62, 105);
            this.lbl_yoneticisifre.Name = "lbl_yoneticisifre";
            this.lbl_yoneticisifre.Size = new System.Drawing.Size(69, 13);
            this.lbl_yoneticisifre.TabIndex = 8;
            this.lbl_yoneticisifre.Text = "Yönetici Şifre";
            // 
            // lbl_yonetici
            // 
            this.lbl_yonetici.AutoSize = true;
            this.lbl_yonetici.BackColor = System.Drawing.Color.Lime;
            this.lbl_yonetici.Location = new System.Drawing.Point(26, 46);
            this.lbl_yonetici.Name = "lbl_yonetici";
            this.lbl_yonetici.Size = new System.Drawing.Size(105, 13);
            this.lbl_yonetici.TabIndex = 7;
            this.lbl_yonetici.Text = "Yönetici Kullanıcı Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_musterikadi);
            this.groupBox1.Controls.Add(this.lbl_musterikullaniciadi);
            this.groupBox1.Controls.Add(this.lbl_musterisifre);
            this.groupBox1.Controls.Add(this.txt_musterisifre);
            this.groupBox1.Controls.Add(this.btn_musterigirisbuton);
            this.groupBox1.Location = new System.Drawing.Point(77, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 193);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Girişi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_yonetici);
            this.groupBox2.Controls.Add(this.lbl_yoneticisifre);
            this.groupBox2.Controls.Add(this.btn_yonetici);
            this.groupBox2.Controls.Add(this.txt_yoneticikadi);
            this.groupBox2.Controls.Add(this.txt_yoneticisifre);
            this.groupBox2.Location = new System.Drawing.Point(461, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 193);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yönetici Girişi";
            // 
            // frm_GenelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_GenelGiris";
            this.Text = "ALHADO TOPTAN BEYAZ EŞYA ";
            this.Load += new System.EventHandler(this.frm_GenelGiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_musterikullaniciadi;
        private System.Windows.Forms.Label lbl_musterisifre;
        private System.Windows.Forms.TextBox txt_musterikadi;
        private System.Windows.Forms.TextBox txt_musterisifre;
        private System.Windows.Forms.Button btn_musterigirisbuton;
        private System.Windows.Forms.Button btn_yonetici;
        private System.Windows.Forms.TextBox txt_yoneticisifre;
        private System.Windows.Forms.TextBox txt_yoneticikadi;
        private System.Windows.Forms.Label lbl_yoneticisifre;
        private System.Windows.Forms.Label lbl_yonetici;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}