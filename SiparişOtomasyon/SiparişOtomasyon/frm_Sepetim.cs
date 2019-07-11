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
{/*Hamdi DAMAR 172802029*/
    public partial class frm_Sepetim : Form
    {
        public frm_Sepetim()
        {
            InitializeComponent();
        }

        frm_SiparisVer siparisformu = new frm_SiparisVer();
        frm_OdemeEkrani odemeekrani = new frm_OdemeEkrani();

        private void frm_Sepetim_Load(object sender, EventArgs e)
        {

            SepetYenile();
            
        }

        private void frm_Sepetim_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }



        private void btn_sepettenciar_Click(object sender, EventArgs e)
        {
            odemeiptal();
        }

        private void SepetYenile()
        {
            list_SepetSiparisler.FullRowSelect = true;
            list_SepetSiparisler.Items.Clear();

            for (int y = 0; y < Siparis.siparis.Count; y++)
            {
                //Sipariş listesindeki ayıraçlar kaldırıldı ve liste dizisine aktarıldı. 
                string[] bolunme_temp = Siparis.siparis[y].Split('|');//Sipariş listesindekiler bölündü.

                //Gerekenler siparisler_dizisine Ürün Adı - Adeti - Fiyatı aktarıldı.
                string[] siparisler_dizisi = new string[3] { bolunme_temp[3], bolunme_temp[1], (Convert.ToInt32(bolunme_temp[2]) * Convert.ToInt32(bolunme_temp[1])).ToString() };
                
                var listsiparis = new ListViewItem(siparisler_dizisi);
                
                list_SepetSiparisler.Items.Add(listsiparis);
                
            }
        }

        private void btnn_Yenile_Click(object sender, EventArgs e)
        {

            SepetYenile();
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {


            try
            {   //İndekse göre atama yapıldı.
                Siparis.UrunAdi = list_SepetSiparisler.Items[list_SepetSiparisler.SelectedItems[0].Index].SubItems[0].Text;
                
                Siparis.UrunAdeti=Convert.ToInt32(list_SepetSiparisler.Items[list_SepetSiparisler.SelectedItems[0].Index].SubItems[1].Text);
                var item = Siparis.listView.FindItemWithText(Siparis.UrunAdi);

                int siparis_edilecek_urun_indeksi = Siparis.listView.Items.IndexOf(item);

                //KDV+Kargo Fiyatı + Ürün Masrafı Eklendi.
                Siparis.tutar = Convert.ToDouble(list_SepetSiparisler.Items[list_SepetSiparisler.SelectedItems[0].Index].SubItems[2].Text);
                Siparis.tutar = Siparis.tutar * 108 / 100;
                Siparis.tutar = Siparis.tutar + Siparis.kargo.KargoFiyati(siparis_edilecek_urun_indeksi, Siparis.UrunAdeti);
                SepettekiBilgileriSakla();
                odemeekrani.Show();
                this.Hide();


            }

            catch { MessageBox.Show("Lütfen Ürün Seçiniz!"); }
        }

        private void odemeiptal()
        {
            try
            {   //Ödeme iptal edilirse indekse göre sipariş listesinden kaldırılıyor.
                string cikarilacak_urun = list_SepetSiparisler.Items[list_SepetSiparisler.SelectedItems[0].Index].SubItems[0].Text;
                int cikarilacak_urun_adeti = Convert.ToInt32(list_SepetSiparisler.Items[list_SepetSiparisler.SelectedItems[0].Index].SubItems[1].Text);
                var item = Siparis.listView.FindItemWithText(cikarilacak_urun);

                int eklenecek_liste_index = Siparis.listView.Items.IndexOf(item);
                int eklenecek_urun_adeti = Convert.ToInt32(Siparis.listView.Items[eklenecek_liste_index].SubItems[1].Text);

                Siparis.listView.Items[eklenecek_liste_index].SubItems[1].Text = (eklenecek_urun_adeti + cikarilacak_urun_adeti).ToString();


                Siparis.siparis.RemoveAt(list_SepetSiparisler.SelectedItems[0].Index);

                SepetYenile();
            }

            catch { MessageBox.Show("Lütfen Ürün Seçiniz!"); }
        }

        private void SepettekiBilgileriSakla()
        {
            Siparis.UrunAdi = list_SepetSiparisler.Items[list_SepetSiparisler.SelectedItems[0].Index].SubItems[0].Text;
            Siparis.UrunAdeti = Convert.ToInt32(list_SepetSiparisler.Items[list_SepetSiparisler.SelectedItems[0].Index].SubItems[1].Text);
            Siparis.Tarih = dttmpckr_SiparisTarihi.Text.ToString();
        }

       
    }
}
