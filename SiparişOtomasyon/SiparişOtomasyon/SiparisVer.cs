using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SiparişOtomasyon
{
    class SiparisVer : Urun
    { 
        public void ComboboxaUrunAta(ListView liste,ComboBox cmbx_UrunAdlari)
        {
            int son_index = liste.Items.Count;

            for (int index = 0; index < son_index; index++)
            {

                ListViewItem satir = liste.Items[index];

                string urunadi = satir.SubItems[3].Text;

                cmbx_UrunAdlari.Items.Add(urunadi);
            }

        }

        public void SepeteEkle(ListView liste, int istenen_adet, ComboBox cmbx_UrunAdlari)
        {
            try
            {
                ListViewItem satir = liste.Items[cmbx_UrunAdlari.SelectedIndex];
 
                if (istenen_adet <= Convert.ToInt32(satir.SubItems[1].Text) && istenen_adet != 0)
                {

                    string siparis_bilgisi1 = "";
                    for (int i = 0; i < 5; i++)
                    { // Ürün listesindeki ürün stok adeti ile müşterinin sipariş adetinin yer değiştirmesi için.

                        if (i != 1) { siparis_bilgisi1 += satir.SubItems[i].Text + "|"; }//Ürün bilgilerinin ayrı gözükmesi için "|" ayıraç konuldu.
                        else { siparis_bilgisi1 += istenen_adet.ToString() + "|"; }//Kaç adet seçtiği yazıldı.

                    }

                    Siparis.siparis.Add(siparis_bilgisi1);//Sipariş sınıfındaki sipariş listesine, ödeme işlemi yapılmamış sipariş eklendi.

                    //Dosyaya yazıldı.
                    satir.SubItems[1].Text = (Convert.ToInt32(satir.SubItems[1].Text) - Convert.ToInt32(istenen_adet.ToString())).ToString();
                    
                    string yazi = DosyayaYazilacaklar(liste, liste.Columns.Count);
                    DosyayaYaz(yazi, "Ürün.txt");
                    Yenile(liste, "Ürün.txt");
                    Siparis.listView = liste;
                    //Static listView güncellendi.
                    


                }

                else { MessageBox.Show("Bu kadar ürünümüz yok :)"); }
            }
            catch { MessageBox.Show("Eksik veya hatalı bilgi girdiniz!"); }

        }

    }
}
