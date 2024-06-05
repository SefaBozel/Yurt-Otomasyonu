namespace Yurt_Otomasyonu
{
    partial class OgrenciAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciAnaSayfa));
            this.btn_Izin = new System.Windows.Forms.Button();
            this.btn_Degis = new System.Windows.Forms.Button();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Izin
            // 
            this.btn_Izin.Location = new System.Drawing.Point(72, 86);
            this.btn_Izin.Name = "btn_Izin";
            this.btn_Izin.Size = new System.Drawing.Size(248, 110);
            this.btn_Izin.TabIndex = 1;
            this.btn_Izin.Text = "İzin Al";
            this.btn_Izin.UseVisualStyleBackColor = true;
            this.btn_Izin.Click += new System.EventHandler(this.btn_Izin_Click);
            // 
            // btn_Degis
            // 
            this.btn_Degis.Location = new System.Drawing.Point(72, 213);
            this.btn_Degis.Name = "btn_Degis";
            this.btn_Degis.Size = new System.Drawing.Size(248, 110);
            this.btn_Degis.TabIndex = 2;
            this.btn_Degis.Text = "Oda Değişikliği";
            this.btn_Degis.UseVisualStyleBackColor = true;
            this.btn_Degis.Click += new System.EventHandler(this.btn_Degis_Click);
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(287, 12);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(100, 30);
            this.txt_Ad.TabIndex = 2;
            this.txt_Ad.TabStop = false;
            this.txt_Ad.Visible = false;
            // 
            // OgrenciAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(399, 429);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.btn_Degis);
            this.Controls.Add(this.btn_Izin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "OgrenciAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.OgrenciAnaSayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Izin;
        private System.Windows.Forms.Button btn_Degis;
        private System.Windows.Forms.TextBox txt_Ad;
    }
}