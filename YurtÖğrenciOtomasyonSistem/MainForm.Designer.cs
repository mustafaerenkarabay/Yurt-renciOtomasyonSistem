namespace YurtÖğrenciOtomasyonSistem
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnOda = new System.Windows.Forms.Button();
            this.btnGirisCikis = new System.Windows.Forms.Button();
            this.btnYemek = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(150, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "YURT OTOMASYON SİSTEMİ";
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenci.Location = new System.Drawing.Point(50, 120);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(180, 60);
            this.btnOgrenci.TabIndex = 1;
            this.btnOgrenci.Text = "Öğrenci İşlemleri";
            this.btnOgrenci.UseVisualStyleBackColor = false;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnOda
            // 
            this.btnOda.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda.Location = new System.Drawing.Point(250, 120);
            this.btnOda.Name = "btnOda";
            this.btnOda.Size = new System.Drawing.Size(180, 60);
            this.btnOda.TabIndex = 2;
            this.btnOda.Text = "Oda İşlemleri";
            this.btnOda.UseVisualStyleBackColor = false;
            this.btnOda.Click += new System.EventHandler(this.btnOda_Click);
            // 
            // btnGirisCikis
            // 
            this.btnGirisCikis.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGirisCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisCikis.Location = new System.Drawing.Point(450, 120);
            this.btnGirisCikis.Name = "btnGirisCikis";
            this.btnGirisCikis.Size = new System.Drawing.Size(180, 60);
            this.btnGirisCikis.TabIndex = 3;
            this.btnGirisCikis.Text = "Giriş-Çıkış İşlemleri";
            this.btnGirisCikis.UseVisualStyleBackColor = false;
            this.btnGirisCikis.Click += new System.EventHandler(this.btnGirisCikis_Click);
            // 
            // btnYemek
            // 
            this.btnYemek.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnYemek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYemek.Location = new System.Drawing.Point(50, 220);
            this.btnYemek.Name = "btnYemek";
            this.btnYemek.Size = new System.Drawing.Size(180, 60);
            this.btnYemek.TabIndex = 4;
            this.btnYemek.Text = "Yemek Takip";
            this.btnYemek.UseVisualStyleBackColor = false;
            this.btnYemek.Click += new System.EventHandler(this.btnYemek_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapor.Location = new System.Drawing.Point(250, 220);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(180, 60);
            this.btnRapor.TabIndex = 5;
            this.btnRapor.Text = "Raporlar";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.IndianRed;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(450, 220);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(180, 60);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnYemek);
            this.Controls.Add(this.btnGirisCikis);
            this.Controls.Add(this.btnOda);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yurt Öğrenci Otomasyon Sistemi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnOda;
        private System.Windows.Forms.Button btnGirisCikis;
        private System.Windows.Forms.Button btnYemek;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnCikis;
    }
}