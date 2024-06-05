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
    public partial class IzinTalepleri : Form
    {
        public IzinTalepleri()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void IzinTalepleri_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from IzinTalep",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_ıd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_Ograd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_ogrtc.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_AdSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_Yakinlik.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_Adres.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            dtp_Ayrılma.Value = Convert.ToDateTime(dataGridView1.Rows[secilen].Cells[6].Value);
            dtp_Donus.Value = Convert.ToDateTime(dataGridView1.Rows[secilen].Cells[7].Value);
        }

        private void btn_Izin_Click(object sender, EventArgs e)
        {
            SqlCommand onay = new SqlCommand("insert into Izin (AdSoyad, TCNo, KalacakAdSoyad, KalacakYakinlik, KalacakAdres, CikisTarih, DonusTarih) values (@t1,@t2,@t3,@t4,@t5,@t6,@t7)", bgl.baglanti());
            string ayrilma = dtp_Ayrılma.Value.ToString("yyyy-MM-dd");
            string donus = dtp_Donus.Value.ToString("yyyy-MM-dd");
            onay.Parameters.AddWithValue("@t1", txt_Ograd.Text);
            onay.Parameters.AddWithValue("@t2", txt_ogrtc.Text);
            onay.Parameters.AddWithValue("@t3", txt_AdSoyad.Text);
            onay.Parameters.AddWithValue("@t4", txt_Yakinlik.Text);
            onay.Parameters.AddWithValue("@t5", txt_Adres.Text);
            onay.Parameters.AddWithValue("@t6", ayrilma);
            onay.Parameters.AddWithValue("@t7", donus);
            onay.ExecuteNonQuery();
            MessageBox.Show("İşlem başarıyla gerçekleşti.");

            SqlCommand temizle = new SqlCommand("delete from IzinTalep where ID=@s1",bgl.baglanti());
            temizle.Parameters.AddWithValue("@s1", txt_ıd.Text);
            temizle.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from IzinTalep", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
