using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yurt_Otomasyonu
{
    public partial class GuvenlikGiris : Form
    {
        public GuvenlikGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Guvenlik where AdSoyad=@k1 and Sifre=@k2", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_Kadi.Text);
            komut.Parameters.AddWithValue("@k2", txt_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                GuvenlikSistemi yg = new GuvenlikSistemi();
                yg.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı veri girişi yaptınız.");
            }
        }
    }
}
