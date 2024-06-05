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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciKayit ok = new OgrenciKayit();
            ok.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OdaDurum od = new OdaDurum();
            od.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayitliOgrenciler ko = new KayitliOgrenciler();
            ko.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IzinTalepleri it = new IzinTalepleri();
            it.Show();
        }

        private void btn_Odatalep_Click(object sender, EventArgs e)
        {
            OdaTalepleri ot = new OdaTalepleri();
            ot.Show();
        }

        private void btn_Izinliler_Click(object sender, EventArgs e)
        {
            IzinliOgrenciler ıo = new IzinliOgrenciler();
            ıo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            YurdaGirmeyenler yg = new YurdaGirmeyenler();
            yg.Show();
        }
    }
}
