namespace YurtÖğrenciOtomasyonSistem
{
    partial class YatakAtamaForm
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblOgrenci = new System.Windows.Forms.Label();
            this.cmbOgrenciler = new System.Windows.Forms.ComboBox();
            this.btnAta = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.lblYatakBilgisi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblBaslik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(100, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(235, 24);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "YATAK ATAMA FORMU";
            // 
            // lblOgrenci
            // 
            this.lblOgrenci.AutoSize = true;
            this.lblOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenci.Location = new System.Drawing.Point(30, 100);
            this.lblOgrenci.Name = "lblOgrenci";
            this.lblOgrenci.Size = new System.Drawing.Size(111, 17);
            this.lblOgrenci.TabIndex = 1;
            this.lblOgrenci.Text = "Öğrenci Seçiniz:";
            // 
            // cmbOgrenciler
            // 
            this.cmbOgrenciler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgrenciler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOgrenciler.FormattingEnabled = true;
            this.cmbOgrenciler.Location = new System.Drawing.Point(150, 100);
            this.cmbOgrenciler.Name = "cmbOgrenciler";
            this.cmbOgrenciler.Size = new System.Drawing.Size(200, 24);
            this.cmbOgrenciler.TabIndex = 2;
            // 
            // btnAta
            // 
            this.btnAta.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAta.ForeColor = System.Drawing.Color.White;
            this.btnAta.Location = new System.Drawing.Point(150, 180);
            this.btnAta.Name = "btnAta";
            this.btnAta.Size = new System.Drawing.Size(100, 30);
            this.btnAta.TabIndex = 3;
            this.btnAta.Text = "Ata";
            this.btnAta.UseVisualStyleBackColor = false;
            this.btnAta.Click += new System.EventHandler(this.btnAta_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.IndianRed;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(260, 180);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(100, 30);
            this.btnIptal.TabIndex = 4;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // lblYatakBilgisi
            // 
            this.lblYatakBilgisi.AutoSize = true;
            this.lblYatakBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYatakBilgisi.Location = new System.Drawing.Point(30, 70);
            this.lblYatakBilgisi.Name = "lblYatakBilgisi";
            this.lblYatakBilgisi.Size = new System.Drawing.Size(52, 17);
            this.lblYatakBilgisi.TabIndex = 5;
            this.lblYatakBilgisi.Text = "label1";
            // 
            // YatakAtamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(400, 230);
            this.Controls.Add(this.lblYatakBilgisi);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnAta);
            this.Controls.Add(this.cmbOgrenciler);
            this.Controls.Add(this.lblOgrenci);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "YatakAtamaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yatak Atama";
            this.Load += new System.EventHandler(this.YatakAtamaForm_Load);
            this.Click += new System.EventHandler(this.YatakAtamaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblOgrenci;
        private System.Windows.Forms.ComboBox cmbOgrenciler;
        private System.Windows.Forms.Button btnAta;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label lblYatakBilgisi;
    }
}