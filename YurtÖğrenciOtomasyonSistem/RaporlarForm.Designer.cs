namespace YurtÖğrenciOtomasyonSistem
{
    partial class RaporlarForm
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
            this.btnOgrenciRapor = new System.Windows.Forms.Button();
            this.btnOdaRapor = new System.Windows.Forms.Button();
            this.btnYemekRapor = new System.Windows.Forms.Button();
            this.btnGirisCikisRapor = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(600, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "RAPOR MENÜSÜ";
            // 
            // btnOgrenciRapor
            // 
            this.btnOgrenciRapor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOgrenciRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciRapor.ForeColor = System.Drawing.Color.White;
            this.btnOgrenciRapor.Location = new System.Drawing.Point(50, 100);
            this.btnOgrenciRapor.Name = "btnOgrenciRapor";
            this.btnOgrenciRapor.Size = new System.Drawing.Size(200, 60);
            this.btnOgrenciRapor.TabIndex = 1;
            this.btnOgrenciRapor.Text = "Öğrenci Listesi Raporu";
            this.btnOgrenciRapor.UseVisualStyleBackColor = false;
            this.btnOgrenciRapor.Click += new System.EventHandler(this.btnOgrenciRapor_Click);
            // 
            // btnOdaRapor
            // 
            this.btnOdaRapor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOdaRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaRapor.ForeColor = System.Drawing.Color.White;
            this.btnOdaRapor.Location = new System.Drawing.Point(300, 100);
            this.btnOdaRapor.Name = "btnOdaRapor";
            this.btnOdaRapor.Size = new System.Drawing.Size(200, 60);
            this.btnOdaRapor.TabIndex = 2;
            this.btnOdaRapor.Text = "Oda Doluluk Raporu";
            this.btnOdaRapor.UseVisualStyleBackColor = false;
            this.btnOdaRapor.Click += new System.EventHandler(this.btnOdaRapor_Click);
            // 
            // btnYemekRapor
            // 
            this.btnYemekRapor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnYemekRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYemekRapor.ForeColor = System.Drawing.Color.White;
            this.btnYemekRapor.Location = new System.Drawing.Point(50, 200);
            this.btnYemekRapor.Name = "btnYemekRapor";
            this.btnYemekRapor.Size = new System.Drawing.Size(200, 60);
            this.btnYemekRapor.TabIndex = 3;
            this.btnYemekRapor.Text = "Yemek Raporları";
            this.btnYemekRapor.UseVisualStyleBackColor = false;
            this.btnYemekRapor.Click += new System.EventHandler(this.btnYemekRapor_Click);
            // 
            // btnGirisCikisRapor
            // 
            this.btnGirisCikisRapor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGirisCikisRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisCikisRapor.ForeColor = System.Drawing.Color.White;
            this.btnGirisCikisRapor.Location = new System.Drawing.Point(300, 200);
            this.btnGirisCikisRapor.Name = "btnGirisCikisRapor";
            this.btnGirisCikisRapor.Size = new System.Drawing.Size(200, 60);
            this.btnGirisCikisRapor.TabIndex = 4;
            this.btnGirisCikisRapor.Text = "Giriş-Çıkış Raporları";
            this.btnGirisCikisRapor.UseVisualStyleBackColor = false;
            this.btnGirisCikisRapor.Click += new System.EventHandler(this.btnGirisCikisRapor_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.IndianRed;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(175, 300);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(200, 60);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // RaporlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnGirisCikisRapor);
            this.Controls.Add(this.btnYemekRapor);
            this.Controls.Add(this.btnOdaRapor);
            this.Controls.Add(this.btnOgrenciRapor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RaporlarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor Menüsü";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOgrenciRapor;
        private System.Windows.Forms.Button btnOdaRapor;
        private System.Windows.Forms.Button btnYemekRapor;
        private System.Windows.Forms.Button btnGirisCikisRapor;
        private System.Windows.Forms.Button btnKapat;
    }
}