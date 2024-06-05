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
    public partial class OgrenciİzinTalep : Form
    {
        public OgrenciİzinTalep()
        {
            InitializeComponent();
        }
        public string Ad;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void İzinTakip_Load(object sender, EventArgs e)
        {
            txt_Ad.Text = Ad;
            SqlCommand tc = new SqlCommand("select TCNo from Ogrenci where AdSoyad=@t1", bgl.baglanti());
            tc.Parameters.AddWithValue("@t1", txt_Ad.Text);
            SqlDataReader dr = tc.ExecuteReader();
            while (dr.Read())
            {
                txt_TC.Text = dr[0].ToString();
            }
        }
        private void btn_Izin_Click(object sender, EventArgs e)
        {
            string Ayrılma = dtp_Ayrılma.Value.ToString("yyyy-MM-dd");
            string Donus = dtp_Donus.Value.ToString("yyyy-MM-dd");
            SqlCommand izin = new SqlCommand("insert into IzinTalep (AdSoyad, TCNo, KalacakAdSoyad, KalacakYakinlik, KalacakAdres, CikisTarih, DonusTarih) values (@k1,@k2,@k3,@k4,@k5,@k6,@k7)",bgl.baglanti());
            izin.Parameters.AddWithValue("@k1", txt_Ad.Text);
            izin.Parameters.AddWithValue("@k2", txt_TC.Text);
            izin.Parameters.AddWithValue("@k3", txt_AdSoyad.Text);
            izin.Parameters.AddWithValue("@k4", txt_Yakinlik.Text);
            izin.Parameters.AddWithValue("@k5", txt_Adres.Text);
            izin.Parameters.AddWithValue("@k6", Ayrılma);
            izin.Parameters.AddWithValue("@k7", Donus);
            izin.ExecuteNonQuery();
            MessageBox.Show("İzin talebiniz görevliye iletilmiştir.");
        }
    }
}
