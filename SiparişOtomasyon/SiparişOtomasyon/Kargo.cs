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
    public class Kargo
    {

        public double KargoFiyati(int index,int adet)
        {   //Kargo ağırlığı listviewden alınıyor. kargo fiyatı tanımlandı.
            double kargo_agirlik = Convert.ToDouble(Siparis.listView.Items[index].SubItems[4].Text),kargo_fiyati;
            //Kargo fiyatı belirlendi.
            kargo_fiyati = kargo_agirlik * 0.2 * adet;


            return kargo_fiyati;
        }

       


    }
}
