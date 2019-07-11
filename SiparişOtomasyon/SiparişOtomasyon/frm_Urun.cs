using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SiparişOtomasyon;

namespace SiparişOtomasyon
{/*Hamdi DAMAR 172802029*/

    public partial class frm_Urun : Form
    {
        Urun urun = new Urun();
        public frm_Urun()
        {
            InitializeComponent();
        }
        //Ürünlerin tutulduğu dosya yolu değişkene atandı

        private void Urun_Load(object sender, EventArgs e)
        {
            //En başta kullanıcının hiçbir işlem yapmadığı varsayıldı.
            Rdobttn_eylemsiz.Select();
            //Listede ürünler görüntülenmesi için işlev çalıştırıldı.
           urun.DosyadanListeyeOku(listView1,listView1.Columns.Count,"Ürün.txt");
            urun.Yenile(listView1,"Ürün.txt");//En başta boş indeks olduğu için yeniletildi.
            Siparis.listView = listView1;


        }

        private void Btn_Yenile_Click(object sender, EventArgs e)
        {
            urun.Yenile(Siparis.listView,"Ürün.txt");
        }

        private void Btn_Cikar_Click(object sender, EventArgs e)
        {

            //Çıkarılacak nesne ilk önce listeden silindi.
            try { listView1.Items.RemoveAt(listView1.SelectedItems[0].Index); }
            catch { MessageBox.Show("Ürün Seçilmedi!"); }

            //lstbx_Urunler.Items.RemoveAt(lstbx_Urunler.SelectedIndex);
            //Sonra listedeki bütün her şeyi dosyaya yazdıran DosyayaYazilacaklar() komutu çalıştırıldı ve yazılacaklar "yazi" değişkenine atandı.
            Siparis.listView = listView1;
            string yazi = urun.DosyayaYazilacaklar(Siparis.listView,listView1.Columns.Count);
            //"yazi" değişkenindekiler dosyaya yazıldı.
            urun.DosyayaYaz(yazi,"Ürün.txt");

        }


        private void Btn_UrunEkle_Click(object sender, EventArgs e)
        {

            /*"Düzenle"de de "ekle"de de aynı öznitelikler olduğu için kullanıcının seçtiği işleme göre buton ismi değiştirildi.*/
            var halef = new ListViewItem(GirdidekiYazilariUygunYap());
            //Eğer butonda ekle yazılıyorsa:
            if (Btn_UrunEkle.Text == "Ekle!")
            {

                    //Girdideki yazilar uygun hale getirildi.
                    //Eklenecek yazı listeye eklendi.
                    listView1.Items.Add(halef);
                //Dosyaya yazılacaklar "yazi" değişkenine atandı.
                Siparis.listView = listView1;
                string yazi = urun.DosyayaYazilacaklar(Siparis.listView, listView1.Columns.Count);
                //"yazi" değişkenindekiler dosyaya yazıldı.
                urun.DosyayaYaz(yazi,"Ürün.txt");
                
            }
            // İlk koşul olmazsa butonun ismi "Düzenle!" olacağı için:
            else
            {
                try
                {
                    //Girdideki yazilar uygun hale getirildi.

                    //Girdi listedeki seçili olan elemanın yazısı haline getirildi.
                    listView1.Items[listView1.SelectedItems[0].Index] = halef;
                    //Dosyaya yazılacaklar "yazi" değişkenine atandı.
                    Siparis.listView = listView1;
                    string yazi = urun.DosyayaYazilacaklar(Siparis.listView, listView1.Columns.Count);
                    //"yazi" değişkenindekiler dosyaya yazıldı.
                    urun.DosyayaYaz(yazi,"Ürün.txt");
                }

                catch { MessageBox.Show("Ürün Seçilmedi!"); }

            }
        }

        
        /*Tüm radyo butonları için, seçime göre nesnenin görünürlüğü değiştirildi.*/
        private void Rdobttn_eylemsiz_CheckedChanged(object sender, EventArgs e)
        {
            grpbx_Girdi.Visible = false;
            Btn_Cikar.Visible = false;

        }

        private void Rdobttn_Sil_CheckedChanged(object sender, EventArgs e)
        {
            Btn_Cikar.Visible = true;
            grpbx_Girdi.Visible = false;
        }

        private void Rdobttn_UrunEkle_CheckedChanged(object sender, EventArgs e)
        {
            //Ürün ekle seçilidiği için butonun ismi "Ekle!" ile değiştirildi.
            Btn_UrunEkle.Text = "Ekle!";
            grpbx_Girdi.Visible = true;
            Btn_Cikar.Visible = false;
        }

        private void Rdobttn_UrunDuzenle_CheckedChanged(object sender, EventArgs e)
        {   //Ürün ekle seçilidiği için butonun ismi "Düzenle!" ile değiştirildi.
            Btn_UrunEkle.Text = "Düzenle!";
            grpbx_Girdi.Visible = true;
            Btn_Cikar.Visible = false;
        }
        public string[] GirdidekiYazilariUygunYap()
        {
            urun.UrunKodu =int.Parse( txtbx_UrunKodu.Text);
            urun.UrunStokAdet = int.Parse(txtbx_UrunStokAdeti.Text);
            urun.UrunFiyat = double.Parse(txtbx_UrunFiyati.Text);
            urun.Urunturu = txtbx_UrunTuru.Text;
            urun.UrunAgirlik = int.Parse(txtbx_UrunAgirligi.Text);
            

            string[] eklenecek = { urun.UrunKodu.ToString(),urun.UrunStokAdet.ToString(), urun.UrunFiyat.ToString(), urun.Urunturu,urun.UrunAgirlik.ToString()};


            return eklenecek;
        }

        private void Urun_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

       
    }
}


