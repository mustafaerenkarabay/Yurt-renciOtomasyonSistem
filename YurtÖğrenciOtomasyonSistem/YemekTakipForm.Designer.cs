namespace YurtÖğrenciOtomasyonSistem
{
    partial class YemekTakipForm
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
            this.btnGunlukYemek = new System.Windows.Forms.Button();
            this.btnYemekRapor = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGunlukYemek
            // 
            this.btnGunlukYemek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGunlukYemek.Location = new System.Drawing.Point(50, 50);
            this.btnGunlukYemek.Name = "btnGunlukYemek";
            this.btnGunlukYemek.Size = new System.Drawing.Size(200, 80);
            this.btnGunlukYemek.TabIndex = 0;
            this.btnGunlukYemek.Text = "Günlük Yemek Kaydı";
            this.btnGunlukYemek.UseVisualStyleBackColor = true;
            this.btnGunlukYemek.Click += new System.EventHandler(this.btnGunlukYemek_Click);
            // 
            // btnYemekRapor
            // 
            this.btnYemekRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYemekRapor.Location = new System.Drawing.Point(300, 50);
            this.btnYemekRapor.Name = "btnYemekRapor";
            this.btnYemekRapor.Size = new System.Drawing.Size(200, 80);
            this.btnYemekRapor.TabIndex = 1;
            this.btnYemekRapor.Text = "Yemek Raporları";
            this.btnYemekRapor.UseVisualStyleBackColor = true;
            this.btnYemekRapor.Click += new System.EventHandler(this.btnYemekRapor_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(175, 150);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(200, 80);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // YemekTakipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 300);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnYemekRapor);
            this.Controls.Add(this.btnGunlukYemek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YemekTakipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yemek Takip Sistemi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGunlukYemek;
        private System.Windows.Forms.Button btnYemekRapor;
        private System.Windows.Forms.Button btnKapat;
    }
}