namespace Yurt_Otomasyonu
{
    partial class OrtakGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrtakGiris));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Guvenlik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 125);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yetkili Girişi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 125);
            this.button2.TabIndex = 1;
            this.button2.Text = "Öğrenci Girişi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Guvenlik
            // 
            this.btn_Guvenlik.Location = new System.Drawing.Point(69, 295);
            this.btn_Guvenlik.Name = "btn_Guvenlik";
            this.btn_Guvenlik.Size = new System.Drawing.Size(261, 125);
            this.btn_Guvenlik.TabIndex = 2;
            this.btn_Guvenlik.Text = "Güvenlik Girişi";
            this.btn_Guvenlik.UseVisualStyleBackColor = true;
            this.btn_Guvenlik.Click += new System.EventHandler(this.btn_Guvenlik_Click);
            // 
            // OrtakGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(399, 439);
            this.Controls.Add(this.btn_Guvenlik);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "OrtakGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ortak Giriş";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Guvenlik;
    }
}