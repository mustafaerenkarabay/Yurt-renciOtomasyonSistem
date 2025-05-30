namespace YurtÖğrenciOtomasyonSistem
{
    partial class GirisCikisTakipForm
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
            this.btnGirisKaydi = new System.Windows.Forms.Button();
            this.btnCikisKaydi = new System.Windows.Forms.Button();
            this.btnGecKalanlar = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGirisKaydi
            // 
            this.btnGirisKaydi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisKaydi.Location = new System.Drawing.Point(50, 50);
            this.btnGirisKaydi.Name = "btnGirisKaydi";
            this.btnGirisKaydi.Size = new System.Drawing.Size(200, 80);
            this.btnGirisKaydi.TabIndex = 0;
            this.btnGirisKaydi.Text = "Giriş Kaydı";
            this.btnGirisKaydi.UseVisualStyleBackColor = true;
            this.btnGirisKaydi.Click += new System.EventHandler(this.btnGirisKaydi_Click);
            // 
            // btnCikisKaydi
            // 
            this.btnCikisKaydi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikisKaydi.Location = new System.Drawing.Point(300, 50);
            this.btnCikisKaydi.Name = "btnCikisKaydi";
            this.btnCikisKaydi.Size = new System.Drawing.Size(200, 80);
            this.btnCikisKaydi.TabIndex = 1;
            this.btnCikisKaydi.Text = "Çıkış Kaydı";
            this.btnCikisKaydi.UseVisualStyleBackColor = true;
            this.btnCikisKaydi.Click += new System.EventHandler(this.btnCikisKaydi_Click);
            // 
            // btnGecKalanlar
            // 
            this.btnGecKalanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGecKalanlar.Location = new System.Drawing.Point(50, 150);
            this.btnGecKalanlar.Name = "btnGecKalanlar";
            this.btnGecKalanlar.Size = new System.Drawing.Size(200, 80);
            this.btnGecKalanlar.TabIndex = 2;
            this.btnGecKalanlar.Text = "Geç Kalanlar Listesi";
            this.btnGecKalanlar.UseVisualStyleBackColor = true;
            this.btnGecKalanlar.Click += new System.EventHandler(this.btnGecKalanlar_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(300, 150);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(200, 80);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // GirisCikisTakipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 300);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnGecKalanlar);
            this.Controls.Add(this.btnCikisKaydi);
            this.Controls.Add(this.btnGirisKaydi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GirisCikisTakipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş-Çıkış Takip Sistemi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGirisKaydi;
        private System.Windows.Forms.Button btnCikisKaydi;
        private System.Windows.Forms.Button btnGecKalanlar;
        private System.Windows.Forms.Button btnKapat;
    }
}