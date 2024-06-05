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
    public partial class OdaTalepleri : Form
    {
        public OdaTalepleri()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btn_Kabul_Click(object sender, EventArgs e)
        {
            SqlCommand onay = new SqlCommand("update Ogrenci set OdaNo=@o1 where AdSoyad=@o2",bgl.baglanti());
            onay.Parameters.AddWithValue("@o1", txt_gececegi.Text);
            onay.Parameters.AddWithValue("@o2", txt_AdSoyad.Text);
            onay.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Talep başarıyla onaylandı.");

            SqlCommand temizle = new SqlCommand("delete from OdaTalep where ID=@s1",bgl.baglanti());
            temizle.Parameters.AddWithValue("@s1", txt_ıd.Text);
            temizle.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from OdaTalep", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void OdaTalepleri_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from OdaTalep", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_ıd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_AdSoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_Tc.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_mevcut.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_gececegi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_Sebep.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btn_Reddet_Click(object sender, EventArgs e)
        {
            SqlCommand temizle = new SqlCommand("delete from OdaTalep where ID=@s1",bgl.baglanti());
            temizle.Parameters.AddWithValue("@s1", txt_ıd.Text);
            temizle.ExecuteNonQuery();
            MessageBox.Show("Talep başarıyla reddedildi.");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from OdaTalep", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
