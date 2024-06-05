namespace Yurt_Otomasyonu
{
    partial class OdaTalepleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdaTalepleri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bilgiler = new System.Windows.Forms.GroupBox();
            this.txt_ıd = new System.Windows.Forms.TextBox();
            this.btn_Kabul = new System.Windows.Forms.Button();
            this.btn_Reddet = new System.Windows.Forms.Button();
            this.txt_Sebep = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_gececegi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mevcut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Tc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Bilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(375, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 569);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Değişiklik Talepleri";
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
            this.dataGridView1.Size = new System.Drawing.Size(685, 540);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Bilgiler
            // 
            this.Bilgiler.Controls.Add(this.txt_ıd);
            this.Bilgiler.Controls.Add(this.btn_Kabul);
            this.Bilgiler.Controls.Add(this.btn_Reddet);
            this.Bilgiler.Controls.Add(this.txt_Sebep);
            this.Bilgiler.Controls.Add(this.label5);
            this.Bilgiler.Controls.Add(this.txt_gececegi);
            this.Bilgiler.Controls.Add(this.label4);
            this.Bilgiler.Controls.Add(this.txt_mevcut);
            this.Bilgiler.Controls.Add(this.label3);
            this.Bilgiler.Controls.Add(this.txt_Tc);
            this.Bilgiler.Controls.Add(this.label2);
            this.Bilgiler.Controls.Add(this.txt_AdSoyad);
            this.Bilgiler.Controls.Add(this.label1);
            this.Bilgiler.Location = new System.Drawing.Point(12, 12);
            this.Bilgiler.Name = "Bilgiler";
            this.Bilgiler.Size = new System.Drawing.Size(357, 569);
            this.Bilgiler.TabIndex = 1;
            this.Bilgiler.TabStop = false;
            this.Bilgiler.Text = "Öğrenci Bilgileri";
            // 
            // txt_ıd
            // 
            this.txt_ıd.Location = new System.Drawing.Point(241, 29);
            this.txt_ıd.Name = "txt_ıd";
            this.txt_ıd.Size = new System.Drawing.Size(100, 30);
            this.txt_ıd.TabIndex = 13;
            this.txt_ıd.TabStop = false;
            this.txt_ıd.Visible = false;
            // 
            // btn_Kabul
            // 
            this.btn_Kabul.Location = new System.Drawing.Point(66, 417);
            this.btn_Kabul.Name = "btn_Kabul";
            this.btn_Kabul.Size = new System.Drawing.Size(182, 62);
            this.btn_Kabul.TabIndex = 6;
            this.btn_Kabul.Text = "Kabul Et";
            this.btn_Kabul.UseVisualStyleBackColor = true;
            this.btn_Kabul.Click += new System.EventHandler(this.btn_Kabul_Click);
            // 
            // btn_Reddet
            // 
            this.btn_Reddet.Location = new System.Drawing.Point(66, 485);
            this.btn_Reddet.Name = "btn_Reddet";
            this.btn_Reddet.Size = new System.Drawing.Size(182, 62);
            this.btn_Reddet.TabIndex = 7;
            this.btn_Reddet.Text = "Reddet";
            this.btn_Reddet.UseVisualStyleBackColor = true;
            this.btn_Reddet.Click += new System.EventHandler(this.btn_Reddet_Click);
            // 
            // txt_Sebep
            // 
            this.txt_Sebep.Location = new System.Drawing.Point(156, 217);
            this.txt_Sebep.Name = "txt_Sebep";
            this.txt_Sebep.Size = new System.Drawing.Size(185, 177);
            this.txt_Sebep.TabIndex = 5;
            this.txt_Sebep.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sebep:";
            // 
            // txt_gececegi
            // 
            this.txt_gececegi.Location = new System.Drawing.Point(156, 181);
            this.txt_gececegi.Name = "txt_gececegi";
            this.txt_gececegi.Size = new System.Drawing.Size(185, 30);
            this.txt_gececegi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Geçeceği Oda:";
            // 
            // txt_mevcut
            // 
            this.txt_mevcut.Location = new System.Drawing.Point(156, 145);
            this.txt_mevcut.Name = "txt_mevcut";
            this.txt_mevcut.Size = new System.Drawing.Size(185, 30);
            this.txt_mevcut.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mevcut Oda:";
            // 
            // txt_Tc
            // 
            this.txt_Tc.Location = new System.Drawing.Point(156, 109);
            this.txt_Tc.Name = "txt_Tc";
            this.txt_Tc.Size = new System.Drawing.Size(185, 30);
            this.txt_Tc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "T.C No:";
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(156, 73);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(185, 30);
            this.txt_AdSoyad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // OdaTalepleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1078, 593);
            this.Controls.Add(this.Bilgiler);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "OdaTalepleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda Değişim Talepleri";
            this.Load += new System.EventHandler(this.OdaTalepleri_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Bilgiler.ResumeLayout(false);
            this.Bilgiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Bilgiler;
        private System.Windows.Forms.Button btn_Kabul;
        private System.Windows.Forms.Button btn_Reddet;
        private System.Windows.Forms.RichTextBox txt_Sebep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_gececegi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mevcut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Tc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_ıd;
    }
}