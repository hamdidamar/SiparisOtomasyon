using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparişOtomasyon
{
    public class Siparis : Musteri
    {
        public static ListView listView;
        public static Kargo kargo = new Kargo();
        public static List<string> siparis = new List<string>();
        public static bool odeme_onay;
        public static double tutar;
        public static ListView Odenmis_Siparisler;
        //ÖdenmişSiparişler listesine göndermek için
        public static string TamAd;
        public static string UrunAdi;
        public static int UrunAdeti;
        public static string Tarih;
        public static string Adres;
        public static string KargoyaVerilisTarihi;


    }
}
