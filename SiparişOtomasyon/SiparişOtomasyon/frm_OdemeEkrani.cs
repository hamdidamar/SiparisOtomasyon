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
    public partial class frm_OdemeEkrani : Form
    {
        public frm_OdemeEkrani()
        {
            InitializeComponent();
        }


    
        Urun urun = new Urun();



        private void frm_HesapEkle_Load(object sender, EventArgs e)
       {
            
            Siparis.odeme_onay = false;
            lbl_Tutar.Text = Siparis.tutar.ToString();
            grpbx_Nakit.Visible = false;
            grpbx_KrediKarti.Visible = false;
            grpbx_Cekle.Visible = false;
            lbl_Tutar.Text = Siparis.tutar.ToString();
       }


        private void frm_OdemeEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {

            Siparis.odeme_onay = false;
            
        }

        private void bttn_OdemeYap_Click(object sender, EventArgs e)
        {
            Siparis.tutar = int.Parse(lbl_Tutar.Text);
            Siparis.Adres = txt_hessapekleadres.Text;
            Siparis.HesapID = txt_hessapekleid.Text;
            Siparis.CVV = txt_hessapeklecvv.Text;
            Siparis.Kartno = txt_hessapeklekartno.Text;
            Siparis.SKT = txt_hessapekleskt.Text;
            Siparis.TCKimlikNo = txt_hessapekletc.Text;
            Siparis.Telefon = txt_hessapekletel.Text;
            Siparis.Ad = txt_hessapeklead.Text;
            Siparis.Soyad = txt_hessapeklesoyad.Text;
            Siparis.TamAd = Siparis.Ad + Siparis.Soyad;
            

            
            

            if (DegerKontrol())
            {

             

                if (KrediKartKontrol() && CekKontrol())
                {
                    MessageBox.Show("Siparişiniz Alınmıştır!");
                    Siparis.odeme_onay = true;
                    Odemedeki_Bilgileri_Sakla();
                    Siparisi_Kaydet();
                    this.Close();
                    
                    
                }
                else
                {
                    MessageBox.Show("Bir Ödeme Yöntemindeki Bilgilerde Hatalı Girildi!");
                }
            }
            

        }

        private void chckbx_KrediKarti_CheckedChanged(object sender, EventArgs e)
        {

            grpbx_KrediKarti.Visible = chckbx_KrediKarti.Checked;
            
        }

        private void chckbx_Cekle_CheckedChanged(object sender, EventArgs e)
        {
            grpbx_Cekle.Visible = chckbx_Cekle.Checked;
        }

        private void chckbx_Nakit_CheckedChanged(object sender, EventArgs e)
        {
            grpbx_Nakit.Visible = chckbx_Nakit.Checked;
        }

        private bool KrediKartKontrol()
        {
            if (chckbx_KrediKarti.Checked == true)
            {
                string kartno = "1999-1999-1999-1999", skt = "01.19", cvv = "199";
                if (txt_hessapeklekartno.Text == kartno && txt_hessapekleskt.Text == skt && txt_hessapeklecvv.Text == cvv)
                {
                    return true;
                }
                else { MessageBox.Show("Kredi Kartı Bilgileri Yanlış"); return false; }
            }

            else return true;
        }

        private bool CekKontrol()
        {
            if (chckbx_Cekle.Checked == true)
            {
                string id = "1999", cekteki_isim = "Anonim";

                if (txt_hessapekleid.Text == id && txtbx_CektekiIsim.Text == cekteki_isim)
                {
                    return true;
                }

                else MessageBox.Show("Çekteki Bilgiler Yanlış"); return false;
            }

            else return true;
        }

        private bool DegerKontrol()
        {
            double sonuc = Convert.ToDouble(lbl_Tutar.Text);
            try { if (txtbx_LiraMiktar.Text != null && double.Parse(txtbx_LiraMiktar.Text) >= 0) { sonuc -= double.Parse(txtbx_LiraMiktar.Text); } } catch { }
            try { if (txtbx_KrediKartiMiktar.Text != null && double.Parse(txtbx_KrediKartiMiktar.Text) >= 0) { sonuc -= double.Parse(txtbx_KrediKartiMiktar.Text); } } catch { }
            try { if (txtbx_CekMiktar.Text != null && double.Parse(txtbx_CekMiktar.Text) >= 0) { sonuc -= double.Parse(txtbx_CekMiktar.Text); } } catch { }


            if (sonuc > 0) { MessageBox.Show("Yeterli Miktarı Girmediniz!"); return false; }
            else if (sonuc < 0) { MessageBox.Show("Fazla Miktar Girdiniz!"); return false; }
            else { return true; }


        }

        private void Odemedeki_Bilgileri_Sakla()
        {
            Siparis.TamAd = txt_hessapeklead.Text + " " + txt_hessapeklesoyad.Text;
            Siparis.Adres = txt_hessapekleadres.Text;
            Siparis.KargoyaVerilisTarihi = "Kargoya Verilmedi!";
        }

        private void Siparisi_Kaydet()
        {
            string[] urunbilgi = new string[7] {Siparis.TamAd,Siparis.UrunAdi,Siparis.UrunAdeti.ToString(),Siparis.tutar.ToString(),Siparis.Tarih,Siparis.Adres,Siparis.KargoyaVerilisTarihi };
            var item = new ListViewItem(urunbilgi);

            Siparis.Odenmis_Siparisler.Items.Add(item);

            string yazi = urun.DosyayaYazilacaklar(Siparis.Odenmis_Siparisler, Siparis.Odenmis_Siparisler.Columns.Count);
            urun.DosyayaYaz(yazi,"Siparişler.txt");



        }

    } 
}
