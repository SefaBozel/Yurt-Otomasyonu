namespace Yurt_Otomasyonu
{
    partial class IzinTalepleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzinTalepleri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_ıd = new System.Windows.Forms.TextBox();
            this.txt_ogrtc = new System.Windows.Forms.TextBox();
            this.txt_Ograd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Adres = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Yakinlik = new System.Windows.Forms.TextBox();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Izin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_Donus = new System.Windows.Forms.DateTimePicker();
            this.dtp_Ayrılma = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(464, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 569);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İzin Talep Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(596, 540);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_ıd);
            this.groupBox2.Controls.Add(this.txt_ogrtc);
            this.groupBox2.Controls.Add(this.txt_Ograd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_Adres);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_Yakinlik);
            this.groupBox2.Controls.Add(this.txt_AdSoyad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_Izin);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtp_Donus);
            this.groupBox2.Controls.Add(this.dtp_Ayrılma);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 569);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Bilgileri";
            // 
            // txt_ıd
            // 
            this.txt_ıd.Location = new System.Drawing.Point(333, 26);
            this.txt_ıd.Name = "txt_ıd";
            this.txt_ıd.Size = new System.Drawing.Size(100, 30);
            this.txt_ıd.TabIndex = 20;
            this.txt_ıd.TabStop = false;
            this.txt_ıd.Visible = false;
            // 
            // txt_ogrtc
            // 
            this.txt_ogrtc.Location = new System.Drawing.Point(168, 115);
            this.txt_ogrtc.Name = "txt_ogrtc";
            this.txt_ogrtc.Size = new System.Drawing.Size(265, 30);
            this.txt_ogrtc.TabIndex = 2;
            // 
            // txt_Ograd
            // 
            this.txt_Ograd.Location = new System.Drawing.Point(168, 79);
            this.txt_Ograd.Name = "txt_Ograd";
            this.txt_Ograd.Size = new System.Drawing.Size(265, 30);
            this.txt_Ograd.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "T.C No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Adı Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Öğrencinin;";
            // 
            // txt_Adres
            // 
            this.txt_Adres.Location = new System.Drawing.Point(168, 289);
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(265, 135);
            this.txt_Adres.TabIndex = 5;
            this.txt_Adres.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Kalacağı Kişinin;";
            // 
            // txt_Yakinlik
            // 
            this.txt_Yakinlik.Location = new System.Drawing.Point(168, 253);
            this.txt_Yakinlik.Name = "txt_Yakinlik";
            this.txt_Yakinlik.Size = new System.Drawing.Size(265, 30);
            this.txt_Yakinlik.TabIndex = 4;
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(168, 217);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(265, 30);
            this.txt_AdSoyad.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Adı Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-5, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yakınlık Derecesi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Açık Adresi:";
            // 
            // btn_Izin
            // 
            this.btn_Izin.Location = new System.Drawing.Point(114, 499);
            this.btn_Izin.Name = "btn_Izin";
            this.btn_Izin.Size = new System.Drawing.Size(205, 64);
            this.btn_Izin.TabIndex = 8;
            this.btn_Izin.Text = "izin Ver";
            this.btn_Izin.UseVisualStyleBackColor = true;
            this.btn_Izin.Click += new System.EventHandler(this.btn_Izin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Geri Geleceği Gün:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ayrılacağı Gün:";
            // 
            // dtp_Donus
            // 
            this.dtp_Donus.Location = new System.Drawing.Point(233, 466);
            this.dtp_Donus.Name = "dtp_Donus";
            this.dtp_Donus.Size = new System.Drawing.Size(200, 30);
            this.dtp_Donus.TabIndex = 7;
            // 
            // dtp_Ayrılma
            // 
            this.dtp_Ayrılma.Location = new System.Drawing.Point(233, 430);
            this.dtp_Ayrılma.Name = "dtp_Ayrılma";
            this.dtp_Ayrılma.Size = new System.Drawing.Size(200, 30);
            this.dtp_Ayrılma.TabIndex = 6;
            // 
            // IzinTalepleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1078, 593);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "IzinTalepleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İzin Talepleri";
            this.Load += new System.EventHandler(this.IzinTalepleri_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_ogrtc;
        private System.Windows.Forms.TextBox txt_Ograd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_Adres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Yakinlik;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Izin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_Donus;
        private System.Windows.Forms.DateTimePicker dtp_Ayrılma;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_ıd;
    }
}