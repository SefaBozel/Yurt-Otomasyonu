﻿namespace Yurt_Otomasyonu
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Odatalep = new System.Windows.Forms.Button();
            this.btn_Izintalep = new System.Windows.Forms.Button();
            this.btn_Izinliler = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 123);
            this.button1.TabIndex = 1;
            this.button1.Text = "Öğrenci Kayıt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 204);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(368, 123);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kayıtlı Öğrenciler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(48, 359);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(368, 123);
            this.button3.TabIndex = 3;
            this.button3.Text = "Oda Durum";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Odatalep
            // 
            this.btn_Odatalep.Location = new System.Drawing.Point(455, 359);
            this.btn_Odatalep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Odatalep.Name = "btn_Odatalep";
            this.btn_Odatalep.Size = new System.Drawing.Size(368, 123);
            this.btn_Odatalep.TabIndex = 6;
            this.btn_Odatalep.Text = "Oda Talepleri";
            this.btn_Odatalep.UseVisualStyleBackColor = true;
            this.btn_Odatalep.Click += new System.EventHandler(this.btn_Odatalep_Click);
            // 
            // btn_Izintalep
            // 
            this.btn_Izintalep.Location = new System.Drawing.Point(455, 49);
            this.btn_Izintalep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Izintalep.Name = "btn_Izintalep";
            this.btn_Izintalep.Size = new System.Drawing.Size(368, 123);
            this.btn_Izintalep.TabIndex = 4;
            this.btn_Izintalep.Text = "İzin Talepleri";
            this.btn_Izintalep.UseVisualStyleBackColor = true;
            this.btn_Izintalep.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_Izinliler
            // 
            this.btn_Izinliler.Location = new System.Drawing.Point(455, 204);
            this.btn_Izinliler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Izinliler.Name = "btn_Izinliler";
            this.btn_Izinliler.Size = new System.Drawing.Size(368, 123);
            this.btn_Izinliler.TabIndex = 5;
            this.btn_Izinliler.Text = "İzinli Öğrenciler";
            this.btn_Izinliler.UseVisualStyleBackColor = true;
            this.btn_Izinliler.Click += new System.EventHandler(this.btn_Izinliler_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(263, 492);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(368, 123);
            this.button4.TabIndex = 7;
            this.button4.Text = "Yurda Girmeyenler";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(879, 641);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Izinliler);
            this.Controls.Add(this.btn_Odatalep);
            this.Controls.Add(this.btn_Izintalep);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Odatalep;
        private System.Windows.Forms.Button btn_Izintalep;
        private System.Windows.Forms.Button btn_Izinliler;
        private System.Windows.Forms.Button button4;
    }
}