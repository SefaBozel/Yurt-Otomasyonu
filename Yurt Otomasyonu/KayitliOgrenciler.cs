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
    public partial class KayitliOgrenciler : Form
    {
        public KayitliOgrenciler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void KayitliOgrenciler_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Ogrenci",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_ID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_TC.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_Tel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            dtp_Dogum.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            dtp_Kayit.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txt_Oda.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txt_Sifre.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update Ogrenci Set AdSoyad=@g1,TCNo=@g2,TelNo=@g3,DogumTarih=@g4,KayitTarih=@g5,OdaNo=@g6,Sifre=@g8 where ID=@g7",bgl.baglanti());
            string dogum = dtp_Dogum.Value.ToString("yyyy-MM-dd");
            string kayit = dtp_Kayit.Value.ToString("yyyy-MM-dd");
            guncelle.Parameters.AddWithValue("@g1", txt_Ad.Text);
            guncelle.Parameters.AddWithValue("@g2", txt_TC.Text);
            guncelle.Parameters.AddWithValue("@g3", txt_Tel.Text);
            guncelle.Parameters.AddWithValue("@g4", dogum);
            guncelle.Parameters.AddWithValue("@g5", kayit);
            guncelle.Parameters.AddWithValue("@g6", txt_Oda.Text);
            guncelle.Parameters.AddWithValue("@g7", txt_ID.Text);
            guncelle.Parameters.AddWithValue("@g8", txt_Sifre.Text);
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Kayıt başarıyla güncellenmiştir.");

            SqlCommand guncelle2 = new SqlCommand("update YurdaGiris Set AdSoyad=@g1,TCNo=@g2,TelNo=@g3,OdaNo=@g4,Durum=@g5 where ID=@g6", bgl.baglanti());
            guncelle2.Parameters.AddWithValue("@g1", txt_Ad.Text);
            guncelle2.Parameters.AddWithValue("@g2", txt_TC.Text);
            guncelle2.Parameters.AddWithValue("@g3", txt_Tel.Text);
            guncelle2.Parameters.AddWithValue("@g4", txt_Oda.Text);
            guncelle2.Parameters.AddWithValue("@g5", "False");
            guncelle2.Parameters.AddWithValue("@g6", txt_ID.Text);
            guncelle2.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Ogrenci", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("delete from Ogrenci where ID=@s1", bgl.baglanti());
            sil.Parameters.AddWithValue("@s1", txt_ID.Text);
            sil.ExecuteNonQuery();
            MessageBox.Show("Kayıt başarıyla silinmiştir.");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Ogrenci", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
