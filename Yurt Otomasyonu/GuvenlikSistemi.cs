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
    public partial class GuvenlikSistemi : Form
    {
        public GuvenlikSistemi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void YurdaGirmeyenler_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from YurdaGiris", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_Geldi_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update YurdaGiris set Durum=@k1 where AdSoyad=@k2", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", '1');
            komut.Parameters.AddWithValue("@k2", txt_AdSoyad.Text);
            komut.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from YurdaGiris", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_AdSoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_TC.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_OdaNo.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }
    }
}
