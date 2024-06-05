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
    public partial class Giris : Form
    {

        public Giris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Giris_Load(object sender, EventArgs e)
        {
           
        }    
    private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Kullanıcılar where KullaniciAdi=@k1 and Sifre=@k2", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_Kadi.Text);
            komut.Parameters.AddWithValue("@k2", txt_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) 
            {
                Anasayfa anas = new Anasayfa();
                anas.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı veri girişi yaptınız.");
            }
        }
    }
}
