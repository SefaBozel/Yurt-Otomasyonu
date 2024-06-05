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
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand giris = new SqlCommand("select * from Ogrenci where AdSoyad=@g1 and Sifre=@g2", bgl.baglanti());
            giris.Parameters.AddWithValue("@g1", txt_Kadi.Text);
            giris.Parameters.AddWithValue("@g2", txt_Sifre.Text);
            SqlDataReader dr = giris.ExecuteReader();
            if (dr.Read())
            {
                OgrenciAnaSayfa it = new OgrenciAnaSayfa();
                it.AdSoyad = txt_Kadi.Text;
                it.Show();
                this.Hide();
            }
        }
    }
}
