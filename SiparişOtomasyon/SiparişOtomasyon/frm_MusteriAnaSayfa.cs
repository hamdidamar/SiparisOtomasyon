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
{
    public partial class frm_MusteriAnaSayfa : Form
    {
        /*Hamdi DAMAR 172802029*/
        public frm_MusteriAnaSayfa()
        {
            InitializeComponent();
        }

        frm_SiparisVer SiparisVer = new frm_SiparisVer();
        frm_Sepetim Sepetim = new frm_Sepetim();
        frm_OdemeEkrani HesapEkle = new frm_OdemeEkrani();
        frm_OncekiSiparislerim OncekiSiparis = new frm_OncekiSiparislerim();
        frm_Urun urun = new frm_Urun();
 

        private void frm_MusteriAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void siparişVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisVer.MdiParent = this;
            SiparisVer.Show();
            
            
        }

        private void sepetimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sepetim.MdiParent = this;
            Sepetim.Show();
            
        }

        private void öncekiSiparişlerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            OncekiSiparis.MdiParent = this;
            OncekiSiparis.Show();
        }

        private void frm_MusteriAnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
