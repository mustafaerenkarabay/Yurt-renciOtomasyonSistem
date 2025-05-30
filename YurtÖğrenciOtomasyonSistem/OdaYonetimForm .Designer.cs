namespace YurtÖğrenciOtomasyonSistem
{
    partial class OdaYonetimForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.dgvOdalar = new System.Windows.Forms.DataGridView();
            this.dgvYataklar = new System.Windows.Forms.DataGridView();
            this.btnOdaEkle = new System.Windows.Forms.Button();
            this.btnOdaDuzenle = new System.Windows.Forms.Button();
            this.btnOdaSil = new System.Windows.Forms.Button();
            this.btnYatakAta = new System.Windows.Forms.Button();
            this.btnYatakBosalt = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblOdalar = new System.Windows.Forms.Label();
            this.lblYataklar = new System.Windows.Forms.Label();
            this.cmbBlokFiltre = new System.Windows.Forms.ComboBox();
            this.lblBlokFiltre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYataklar)).BeginInit();
            this.SuspendLayout();

            // panel1
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblBaslik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 70);
            this.panel1.TabIndex = 0;

            // lblBaslik
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(350, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(284, 26);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "ODA VE YATAK YÖNETİMİ";

            // dgvOdalar
            this.dgvOdalar.AllowUserToAddRows = false;
            this.dgvOdalar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvOdalar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOdalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOdalar.BackgroundColor = System.Drawing.Color.White;
            this.dgvOdalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdalar.Location = new System.Drawing.Point(12, 120);
            this.dgvOdalar.MultiSelect = false;
            this.dgvOdalar.Name = "dgvOdalar";
            this.dgvOdalar.ReadOnly = true;
            this.dgvOdalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOdalar.Size = new System.Drawing.Size(460, 300);
            this.dgvOdalar.TabIndex = 1;
            this.dgvOdalar.SelectionChanged += new System.EventHandler(this.dgvOdalar_SelectionChanged);

            // dgvYataklar
            this.dgvYataklar.AllowUserToAddRows = false;
            this.dgvYataklar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvYataklar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvYataklar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYataklar.BackgroundColor = System.Drawing.Color.White;
            this.dgvYataklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYataklar.Location = new System.Drawing.Point(500, 120);
            this.dgvYataklar.MultiSelect = false;
            this.dgvYataklar.Name = "dgvYataklar";
            this.dgvYataklar.ReadOnly = true;
            this.dgvYataklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYataklar.Size = new System.Drawing.Size(460, 300);
            this.dgvYataklar.TabIndex = 2;

            // btnOdaEkle
            this.btnOdaEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOdaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaEkle.ForeColor = System.Drawing.Color.White;
            this.btnOdaEkle.Location = new System.Drawing.Point(12, 430);
            this.btnOdaEkle.Name = "btnOdaEkle";
            this.btnOdaEkle.Size = new System.Drawing.Size(120, 40);
            this.btnOdaEkle.TabIndex = 3;
            this.btnOdaEkle.Text = "Oda Ekle";
            this.btnOdaEkle.UseVisualStyleBackColor = false;
            this.btnOdaEkle.Click += new System.EventHandler(this.btnOdaEkle_Click);

            // btnOdaDuzenle
            this.btnOdaDuzenle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOdaDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnOdaDuzenle.Location = new System.Drawing.Point(142, 430);
            this.btnOdaDuzenle.Name = "btnOdaDuzenle";
            this.btnOdaDuzenle.Size = new System.Drawing.Size(120, 40);
            this.btnOdaDuzenle.TabIndex = 4;
            this.btnOdaDuzenle.Text = "Oda Düzenle";
            this.btnOdaDuzenle.UseVisualStyleBackColor = false;
            this.btnOdaDuzenle.Click += new System.EventHandler(this.btnOdaDuzenle_Click);

            // btnOdaSil
            this.btnOdaSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnOdaSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaSil.ForeColor = System.Drawing.Color.White;
            this.btnOdaSil.Location = new System.Drawing.Point(272, 430);
            this.btnOdaSil.Name = "btnOdaSil";
            this.btnOdaSil.Size = new System.Drawing.Size(120, 40);
            this.btnOdaSil.TabIndex = 5;
            this.btnOdaSil.Text = "Oda Sil";
            this.btnOdaSil.UseVisualStyleBackColor = false;
            this.btnOdaSil.Click += new System.EventHandler(this.btnOdaSil_Click);

            // btnYatakAta
            this.btnYatakAta.BackColor = System.Drawing.Color.SteelBlue;
            this.btnYatakAta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYatakAta.ForeColor = System.Drawing.Color.White;
            this.btnYatakAta.Location = new System.Drawing.Point(500, 430);
            this.btnYatakAta.Name = "btnYatakAta";
            this.btnYatakAta.Size = new System.Drawing.Size(120, 40);
            this.btnYatakAta.TabIndex = 6;
            this.btnYatakAta.Text = "Yatak Ata";
            this.btnYatakAta.UseVisualStyleBackColor = false;
            this.btnYatakAta.Click += new System.EventHandler(this.btnYatakAta_Click);

            // btnYatakBosalt
            this.btnYatakBosalt.BackColor = System.Drawing.Color.IndianRed;
            this.btnYatakBosalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYatakBosalt.ForeColor = System.Drawing.Color.White;
            this.btnYatakBosalt.Location = new System.Drawing.Point(630, 430);
            this.btnYatakBosalt.Name = "btnYatakBosalt";
            this.btnYatakBosalt.Size = new System.Drawing.Size(120, 40);
            this.btnYatakBosalt.TabIndex = 7;
            this.btnYatakBosalt.Text = "Yatak Boşalt";
            this.btnYatakBosalt.UseVisualStyleBackColor = false;
            this.btnYatakBosalt.Click += new System.EventHandler(this.btnYatakBosalt_Click);

            // btnGeri
            this.btnGeri.BackColor = System.Drawing.Color.Gray;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.Location = new System.Drawing.Point(840, 430);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(120, 40);
            this.btnGeri.TabIndex = 8;
            this.btnGeri.Text = "Geri Dön";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);

            // lblOdalar
            this.lblOdalar.AutoSize = true;
            this.lblOdalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdalar.Location = new System.Drawing.Point(12, 100);
            this.lblOdalar.Name = "lblOdalar";
            this.lblOdalar.Size = new System.Drawing.Size(58, 17);
            this.lblOdalar.TabIndex = 9;
            this.lblOdalar.Text = "Odalar";

            // lblYataklar
            this.lblYataklar.AutoSize = true;
            this.lblYataklar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYataklar.Location = new System.Drawing.Point(500, 100);
            this.lblYataklar.Name = "lblYataklar";
            this.lblYataklar.Size = new System.Drawing.Size(67, 17);
            this.lblYataklar.TabIndex = 10;
            this.lblYataklar.Text = "Yataklar";

            // cmbBlokFiltre
            this.cmbBlokFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlokFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBlokFiltre.FormattingEnabled = true;
            this.cmbBlokFiltre.Location = new System.Drawing.Point(650, 70);
            this.cmbBlokFiltre.Name = "cmbBlokFiltre";
            this.cmbBlokFiltre.Size = new System.Drawing.Size(150, 24);
            this.cmbBlokFiltre.TabIndex = 11;
            this.cmbBlokFiltre.SelectedIndexChanged += new System.EventHandler(this.cmbBlokFiltre_SelectedIndexChanged);

            // lblBlokFiltre
            this.lblBlokFiltre.AutoSize = true;
            this.lblBlokFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBlokFiltre.Location = new System.Drawing.Point(500, 73);
            this.lblBlokFiltre.Name = "lblBlokFiltre";
            this.lblBlokFiltre.Size = new System.Drawing.Size(144, 17);
            this.lblBlokFiltre.TabIndex = 12;
            this.lblBlokFiltre.Text = "Blok Filtreleme Seçin:";

            // OdaYonetimForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 481);
            this.Controls.Add(this.lblBlokFiltre);
            this.Controls.Add(this.cmbBlokFiltre);
            this.Controls.Add(this.lblYataklar);
            this.Controls.Add(this.lblOdalar);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnYatakBosalt);
            this.Controls.Add(this.btnYatakAta);
            this.Controls.Add(this.btnOdaSil);
            this.Controls.Add(this.btnOdaDuzenle);
            this.Controls.Add(this.btnOdaEkle);
            this.Controls.Add(this.dgvYataklar);
            this.Controls.Add(this.dgvOdalar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OdaYonetimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda ve Yatak Yönetimi";
            this.Load += new System.EventHandler(this.OdaYonetimForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYataklar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.DataGridView dgvOdalar;
        private System.Windows.Forms.DataGridView dgvYataklar;
        private System.Windows.Forms.Button btnOdaEkle;
        private System.Windows.Forms.Button btnOdaDuzenle;
        private System.Windows.Forms.Button btnOdaSil;
        private System.Windows.Forms.Button btnYatakAta;
        private System.Windows.Forms.Button btnYatakBosalt;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblOdalar;
        private System.Windows.Forms.Label lblYataklar;
        private System.Windows.Forms.ComboBox cmbBlokFiltre;
        private System.Windows.Forms.Label lblBlokFiltre;
    }
}