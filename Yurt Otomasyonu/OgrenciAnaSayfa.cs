using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yurt_Otomasyonu
{
    public partial class OgrenciAnaSayfa : Form
    {
        public OgrenciAnaSayfa()
        {
            InitializeComponent();
        }
        public string AdSoyad;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void OgrenciAnaSayfa_Load(object sender, EventArgs e)
        {
            txt_Ad.Text = AdSoyad;
        }

        private void btn_Izin_Click(object sender, EventArgs e)
        {
            OgrenciİzinTalep it = new OgrenciİzinTalep();
            it.Ad = txt_Ad.Text;
            it.Show();
        }

        private void btn_Degis_Click(object sender, EventArgs e)
        {
            OgrenciOda oo = new OgrenciOda();
            oo.bilgi = txt_Ad.Text;
            oo.Show();
        }
    }
}
