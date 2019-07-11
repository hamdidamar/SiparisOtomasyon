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
    public partial class frm_OncekiSiparislerim : Form
    {
        Urun urun = new Urun();
        public frm_OncekiSiparislerim()
        {
            InitializeComponent();
        }

        private void OncekiSiparislerim_Load(object sender, EventArgs e)
        {

            lstvw_MusteriTakip.Items.Clear();
            urun.DosyadanListeyeOku(lstvw_MusteriTakip, lstvw_MusteriTakip.Columns.Count, "Siparişler.txt");
            urun.Yenile(lstvw_MusteriTakip, "Siparişler.txt");

            for (int i = 0; i < lstvw_MusteriTakip.Items.Count; i++)
            {   //Sadece kişinin adının ve soyadının bulunduğu ürünleri görebiliyor.
                if (Kisi.Ad != lstvw_MusteriTakip.Items[i].SubItems[0].Text) { lstvw_MusteriTakip.Items.RemoveAt(i); }
            }
        }
    }
}
