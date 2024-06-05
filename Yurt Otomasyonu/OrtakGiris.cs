using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yurt_Otomasyonu
{
    public partial class OrtakGiris : Form
    {
        public OrtakGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris yg = new Giris();
            yg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgrenciGiris og = new OgrenciGiris();
            og.Show();
            this.Hide();
        }

        private void btn_Guvenlik_Click(object sender, EventArgs e)
        {
            GuvenlikGiris gg = new GuvenlikGiris();
            gg.Show();
            this.Hide();
        }
    }
}
