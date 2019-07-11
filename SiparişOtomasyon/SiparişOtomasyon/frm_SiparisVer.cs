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
    public partial class frm_SiparisVer :Form
    {
        public frm_SiparisVer()
        {
            InitializeComponent();
        }

        private void frm_SiparisVer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        SiparisVer siparisVer = new SiparisVer();

        private void frm_SiparisVer_Load(object sender, EventArgs e)
        {

            siparisVer.DosyadanListeyeOku(listView1,listView1.Columns.Count,"Ürün.txt");
            Siparis.listView = listView1;
            siparisVer.Yenile(listView1,"Ürün.txt");
            //Combobox'a ürünlerin adları aktarıldı.
            siparisVer.ComboboxaUrunAta(listView1,cmbx_UrunAdlari);
            

            
        }

       
        private void btn_sepeteekle_Click(object sender, EventArgs e)
        {
            siparisVer.SepeteEkle(listView1, int.Parse(txt_urunadet.Text), cmbx_UrunAdlari);
            
           
        }

        private void txt_urunadet_TextChanged(object sender, KeyEventArgs e)//Entera Basınca Sepete Ekliyor
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_sepeteekle.PerformClick();

            }
        }
    }
}
