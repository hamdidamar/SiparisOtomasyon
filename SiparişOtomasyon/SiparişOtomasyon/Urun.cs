using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace SiparişOtomasyon
{/*Hamdi DAMAR 172802029*/
    public  class Urun : Yonetici
    {
     
        //Metine yazdırılırken bir nesneyle diğer nesne karışmasın diye yapıldı.
        /*Örnek:
         1
         12
         300
         Makine
         13
         ------------------------------
         */
        public string urunayiraci = "------------------------------";
        
        public void DosyadanListeyeOku(ListView liste, int elemansayisi, string dosyayolu)
        {   //while koşulunun kontrol eden değişken tanımlandı.
            int whilekosulukontrolu = 0;
            //çekilecek bilgi hem tanımlandı hem sıfırlandı.
            string[] xbilgi = new string[elemansayisi];
            //Başka ürünle karışmaması için sayaç tanılandı ve sıfırlandı.
            int urun_bilgisisonu_sayac = 0;
            //Dizinin indisleri sırasıyla Ürünün;türü adı,kodu,adeti,geliş tarihi
            FileStream fileStream = new FileStream(dosyayolu, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //dosyadan satır satır okuyup listbox içine yazıdırıyoruz
            //Türkçe karaktere uygun hale getirildi ve okuyucu tanımlandı.
            using (StreamReader reader = new StreamReader(fileStream, Encoding.GetEncoding("iso-8859-9")))

            {
                while (true)//Sürekli devam etsin diye
                {
                    string satir = reader.ReadLine();//Dizideki satırı okudu.
                    if (satir != urunayiraci && satir != null)//Satırdakiler eğer satır ayıracıysa veya hiçbir şey yazmıyorsa 
                    {
                        if (urun_bilgisisonu_sayac < elemansayisi)//Okunan bir ürün bilgisinin sonuna ulaşmamışsa burada.
                        {
                            xbilgi[urun_bilgisisonu_sayac] = satir;
                            urun_bilgisisonu_sayac++;//Okunan bir ürün bilgisinin sonuna 1 adım yaklaştırıldı.
                        }

                    }

                    else if (satir == urunayiraci)
                    {   //Eğer okunan satır ürünayıracına eşitse
                        urun_bilgisisonu_sayac = 0;//Sıfırlama işlemleri.

                        var ekle = new ListViewItem(xbilgi);
                        liste.Items.Add(ekle);
                        if (dosyayolu == "Ürün.txt") Siparis.listView = liste;
                        else { Siparis.Odenmis_Siparisler = liste; }

                    }

                    else break;//eğer satırda hiçbir şey yazmıyorsa yani nullsa

                    /*SONSUZ DÖNGÜDE TAKILIRSA DİYE HEM DÖNGÜDEN ÇIKARTAN HEM DE KULLANICIYA BİLGİ VEREN BİR KONTROL TANIMLANDI!*/
                    whilekosulukontrolu++;
                    if (whilekosulukontrolu > 1000) { MessageBox.Show("HATA KODU 0:LÜTFEN BİZİMLE İLETİŞİME GEÇİNİZ!"); break; }
                }
                reader.Close();//Okuyucu kapatıldı.
            }
            fileStream.Close();//Dosya işlemi kapatıldı.


        }


        public string DosyayaYazilacaklar(ListView liste, int elemansayisi)
        {
            //while koşulunun kontrol eden değişken tanımlandı.
            int whilekosulukontrolu = 0;

            //yazilar hem tanımlandı hem sıfırlandı.
            string yazilar = "";


            //Dizinin indisleri sırasıyla Ürünün;türü adı,kodu,adeti,geliş tarihi

            //indeks 0 yapıldı ve listenin sonuncu elemanının indeksi tanımlandı.
            int index = 0, son_index = liste.Items.Count;

            //dosyadan satır satır okuyup listbox içine yazıdırıyoruz
            while (true)
            {

                //Listedeki bilgileri indeks bilgisine göre alınıyor.
                ListViewItem satir = liste.Items[index];

                string[] bilgiler = new string[elemansayisi];

                for (int i = 0; i < elemansayisi; i++)
                {
                    bilgiler[i] = satir.SubItems[i].Text;
                }

                foreach (string bilgi in bilgiler)
                {
                    //Bölünmüş bilgiler yazilar değişkenine atandı.
                    yazilar += bilgi + "\n";

                }
                //En sonunda ürün ayıracı eklendi.
                yazilar += urunayiraci + "\n";


                index++;

                if (son_index == index) { break; }//Sonuncu indekse gelinmişse döngüden çıkıyor.


                /*SONSUZ DÖNGÜDE TAKILIRSA DİYE HEM DÖNGÜDEN ÇIKARTAN HEM DE KULLANICIYA BİLGİ VEREN BİR KONTROL TANIMLANDI!*/
                whilekosulukontrolu++;
                if (whilekosulukontrolu > 1000) { MessageBox.Show("HATA KODU 0:LÜTFEN BİZİMLE İLETİŞİME GEÇİNİZ!"); break; }
            }

            return yazilar;


        }


        public void DosyayaYaz(string yazilacaklar, string dosyayolu)
        {
            //Dosyaya yazılması istenenler yazilacaklar(string) değişkeniyle yazıldı.  
            File.WriteAllText(dosyayolu, yazilacaklar, Encoding.GetEncoding("iso-8859-9"));

            MessageBox.Show("İşlem Yapıldı!");

        }

        public void Yenile(ListView liste, string dosyayolu)
        {
            //Liste yenilendiği için seçilen ürün - ismini aldı. 
            //Liste sıfırlandı.
            liste.Items.Clear();
            //Listede ürünler görüntülenmesi için fonksiyon çalıştırıldı.
            DosyadanListeyeOku(liste, liste.Columns.Count, dosyayolu);
        }

        
    }
}
