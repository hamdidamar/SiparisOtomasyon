using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparişOtomasyon
{
    public class Yonetici :  Kisi
    {

        public int UrunAgirlik { get; set; }
        public double UrunFiyat { get; set; }
        public int UrunKodu { get; set; }
        public int UrunStokAdet { get; set; }
        public string Urunturu { get; set; }
    }
}
