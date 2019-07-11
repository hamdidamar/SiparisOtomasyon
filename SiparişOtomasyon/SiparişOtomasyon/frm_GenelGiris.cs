using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SiparişOtomasyon
{
    /*Hamdi DAMAR 172802029*/
    public partial class frm_GenelGiris : Form
    {
        frm_YoneticiAnaSayfa YonAnaSayfa = new frm_YoneticiAnaSayfa();
        frm_MusteriAnaSayfa MusAnaSayfa = new frm_MusteriAnaSayfa();
        public frm_GenelGiris()
        {
            InitializeComponent();
        }

        private void btn_musterigirisbuton_Click(object sender, EventArgs e)
        {
            if (txt_musterikadi.Text =="Musteri" && txt_musterisifre.Text =="1234")
            {
                Kisi.Ad = "Alparslan ÇAY";
                MusAnaSayfa.Show();
                this.Hide();
            }
            else
            { MessageBox.Show("Sayın Müşteri Hatalı Bilgi Girişi!"); }

            
        }

        private void btn_yonetici_Click(object sender, EventArgs e)
        {
            if(txt_yoneticikadi.Text == "Admin" && txt_yoneticisifre.Text== "0000")
            {
                Kisi.Ad = "Dogan Kasas";
                YonAnaSayfa.Show();
                this.Hide();
            }
            else
            { MessageBox.Show("Sayın Yönetici Hatalı Bilgi Girişi!"); }
        }

        private void frm_GenelGiris_Load(object sender, EventArgs e)
        {
            
            Siparis_listesine_kolon_ata();
            

        }

        private void Siparis_listesine_kolon_ata()
        {
            ListView Odenmis_Siparisler_temp = new ListView();

            Odenmis_Siparisler_temp.Columns.Add("Tam Ad");
            Odenmis_Siparisler_temp.Columns.Add("Ürün Adı");
            Odenmis_Siparisler_temp.Columns.Add("Ürün Adeti");
            Odenmis_Siparisler_temp.Columns.Add("Sipariş Adeti");
            Odenmis_Siparisler_temp.Columns.Add("Tarih");
            Odenmis_Siparisler_temp.Columns.Add("Adres");
            Odenmis_Siparisler_temp.Columns.Add("Kargoya Veriliş Tarihi");

            Siparis.Odenmis_Siparisler = Odenmis_Siparisler_temp;
        }

        private void txt_musterisifre_TextChanged(object sender, KeyEventArgs e)//Enter İle Musteriye Gİrsin Diye
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_musterigirisbuton.PerformClick();
            }

        }

        private void txt_yoneticisifre_TextChanged(object sender, KeyEventArgs e)//Enter İle Yöneticiye girsin Diye
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_yonetici.PerformClick();
            }
        }
    }
}
