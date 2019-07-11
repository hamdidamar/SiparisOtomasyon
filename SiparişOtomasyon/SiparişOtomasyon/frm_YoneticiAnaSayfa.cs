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
    public partial class frm_YoneticiAnaSayfa : Form
    {


        frm_Urun urun = new frm_Urun();
        frm_Siparis siparis = new frm_Siparis();

        public frm_YoneticiAnaSayfa()
        {
            InitializeComponent();
        }

        private void gelenSiparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siparis.MdiParent = this;
            siparis.Show();       
        }

        private void frm_YoneticiAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void ürünToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            urun.MdiParent = this;
            urun.Show();
        }

    }
}
