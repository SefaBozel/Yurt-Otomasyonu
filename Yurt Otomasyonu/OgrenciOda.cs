﻿using System;
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
    public partial class OgrenciOda : Form
    {
        public OgrenciOda()
        {
            InitializeComponent();
            Button[] buttons = { btn_100, btn_101, btn_102, btn_103, btn_104, btn_105, btn_200, btn_201, btn_202, btn_203, btn_204, btn_205, btn_300, btn_301, btn_302, btn_303, btn_304, btn_305, btn_400, btn_401, btn_402, btn_403, btn_404, btn_405, btn_500, btn_501, btn_502, btn_503, btn_504, btn_505 };
            string connectionString = "Data Source=DESKTOP-S59HMG2\\MSSQLSERVER03;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True;Encrypt=False;";
            foreach (Button button in buttons)
            {
                string odaNo = button.Text;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Kapasite FROM Oda WHERE OdaNo = @OdaNo";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@OdaNo", odaNo);

                    object kapasiteObject = command.ExecuteScalar();
                    int kapasite = 0;

                    if (kapasiteObject != null && kapasiteObject != DBNull.Value)
                    {
                        kapasite = Convert.ToInt32(kapasiteObject);
                    }

                    string countQuery = "SELECT COUNT(OdaNo) FROM Ogrenci WHERE OdaNo = @OdaNo";
                    SqlCommand countCommand = new SqlCommand(countQuery, connection);
                    countCommand.Parameters.AddWithValue("@OdaNo", odaNo);

                    int odaCount = (int)countCommand.ExecuteScalar();

                    if (odaCount >= kapasite)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
        }
        public string bilgi;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void OgrenciOda_Load(object sender, EventArgs e)
        {
            txt_AdSoyad.Text = bilgi;
            SqlCommand tc = new SqlCommand("select TCNo,OdaNo from Ogrenci where AdSoyad=@t1",bgl.baglanti());
            tc.Parameters.AddWithValue("@t1", txt_AdSoyad.Text);
            SqlDataReader dr = tc.ExecuteReader();
            while (dr.Read())
            {
                txt_TC.Text = dr[0].ToString();
                txt_Mevcut.Text = dr[1].ToString();
            }        
        }
        private void btn_100_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "100";
        }

        private void btn_101_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "101";
        }

        private void btn_102_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "102";
        }

        private void btn_103_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "103";
        }

        private void btn_104_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "104";
        }

        private void btn_105_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "105";
        }

        private void btn_200_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "200";
        }

        private void btn_201_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "201";
        }

        private void btn_202_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "202";
        }

        private void btn_203_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "203";
        }

        private void btn_204_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "204";
        }

        private void btn_205_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "205";
        }

        private void btn_300_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "300";
        }

        private void btn_301_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "301";
        }

        private void btn_302_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "302";
        }

        private void btn_303_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "303";
        }

        private void btn_304_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "304";
        }

        private void btn_305_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "305";
        }

        private void btn_400_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "400";
        }

        private void btn_401_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "401";
        }

        private void btn_402_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "402";
        }

        private void btn_403_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "403";
        }

        private void btn_404_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "404";
        }

        private void btn_405_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "405";
        }

        private void btn_500_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "500";
        }

        private void btn_501_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "501";
        }

        private void btn_502_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "502";

        }

        private void btn_503_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "503";

        }

        private void btn_504_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "504";

        }

        private void btn_505_Click(object sender, EventArgs e)
        {
            txt_Oda.Text = "505";
        }

        private void btn_Talep_Click(object sender, EventArgs e)
        {
            SqlCommand talep = new SqlCommand("insert into OdaTalep (AdSoyad, TCNo, MevcutOda, IstedigiOda, Sebep) values (@t1,@t2,@t3,@t4,@t5)", bgl.baglanti());
            talep.Parameters.AddWithValue("@t1", txt_AdSoyad.Text);
            talep.Parameters.AddWithValue("@t2", txt_TC.Text);
            talep.Parameters.AddWithValue("@t3", txt_Mevcut.Text);
            talep.Parameters.AddWithValue("@t4", txt_Oda.Text);
            talep.Parameters.AddWithValue("@t5", richTextBox1.Text);
            talep.ExecuteNonQuery();
            MessageBox.Show("Talebiniz başarıyla gönderilmiştir. En kısa sürede geri dönüş sağlanılacaktır.");
        }
    }
}
