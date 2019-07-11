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
    public partial class frm_Siparis : Form
    {
        public frm_Siparis()
        {
            InitializeComponent();

        
        }
        Urun urun = new Urun();
        Siparis siparis = new Siparis();


        private void frm_GelenSiparis_Load(object sender, EventArgs e)
        {
            urun.DosyadanListeyeOku(list_musteriSepetSiparisler, list_musteriSepetSiparisler.Columns.Count, "Siparişler.txt");

            urun.Yenile(list_musteriSepetSiparisler, "Siparişler.txt");



        }

        private void bttn_KargoyaVer_Click(object sender, EventArgs e)
        {
            // Kargoya verilmedi yazısıyla datetimepickerdaki tarih bilgisi yazısı yer değiştirildi.
            list_musteriSepetSiparisler.SelectedItems[0].SubItems[6].Text = dttmpckr_KargoyaVerilisTarih.Text.ToString();
            string yazi = urun.DosyayaYazilacaklar(list_musteriSepetSiparisler, list_musteriSepetSiparisler.Columns.Count);
            urun.DosyayaYaz(yazi, "Siparişler.txt");
            
        }

        private void bttn_Yenile_Click(object sender, EventArgs e)
        {
            urun.Yenile(list_musteriSepetSiparisler, "Siparişler.txt");
        }

    }
}
