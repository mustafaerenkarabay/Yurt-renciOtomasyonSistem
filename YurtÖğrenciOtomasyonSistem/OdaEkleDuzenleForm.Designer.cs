namespace YurtÖğrenciOtomasyonSistem
{
    partial class OdaEkleDuzenleForm
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
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.lblKat = new System.Windows.Forms.Label();
            this.numKat = new System.Windows.Forms.NumericUpDown();
            this.lblKapasite = new System.Windows.Forms.Label();
            this.numKapasite = new System.Windows.Forms.NumericUpDown();
            this.lblBlok = new System.Windows.Forms.Label();
            this.cmbBlok = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKapasite)).BeginInit();
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
            this.lblBaslik.Location = new System.Drawing.Point(120, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(198, 24);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "ODA KAYIT FORMU";
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaNo.Location = new System.Drawing.Point(30, 80);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(61, 17);
            this.lblOdaNo.TabIndex = 1;
            this.lblOdaNo.Text = "Oda No:";
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdaNo.Location = new System.Drawing.Point(150, 80);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(200, 23);
            this.txtOdaNo.TabIndex = 2;
            // 
            // lblKat
            // 
            this.lblKat.AutoSize = true;
            this.lblKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKat.Location = new System.Drawing.Point(30, 120);
            this.lblKat.Name = "lblKat";
            this.lblKat.Size = new System.Drawing.Size(33, 17);
            this.lblKat.TabIndex = 3;
            this.lblKat.Text = "Kat:";
            // 
            // numKat
            // 
            this.numKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numKat.Location = new System.Drawing.Point(150, 120);
            this.numKat.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numKat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKat.Name = "numKat";
            this.numKat.Size = new System.Drawing.Size(200, 23);
            this.numKat.TabIndex = 4;
            this.numKat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblKapasite
            // 
            this.lblKapasite.AutoSize = true;
            this.lblKapasite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKapasite.Location = new System.Drawing.Point(30, 160);
            this.lblKapasite.Name = "lblKapasite";
            this.lblKapasite.Size = new System.Drawing.Size(67, 17);
            this.lblKapasite.TabIndex = 5;
            this.lblKapasite.Text = "Kapasite:";
            // 
            // numKapasite
            // 
            this.numKapasite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numKapasite.Location = new System.Drawing.Point(150, 160);
            this.numKapasite.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numKapasite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKapasite.Name = "numKapasite";
            this.numKapasite.Size = new System.Drawing.Size(200, 23);
            this.numKapasite.TabIndex = 6;
            this.numKapasite.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // lblBlok
            // 
            this.lblBlok.AutoSize = true;
            this.lblBlok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBlok.Location = new System.Drawing.Point(30, 200);
            this.lblBlok.Name = "lblBlok";
            this.lblBlok.Size = new System.Drawing.Size(39, 17);
            this.lblBlok.TabIndex = 7;
            this.lblBlok.Text = "Blok:";
            // 
            // cmbBlok
            // 
            this.cmbBlok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBlok.FormattingEnabled = true;
            this.cmbBlok.Items.AddRange(new object[] {
            "A Blok",
            "B Blok",
            "C Blok",
            "D Blok"});
            this.cmbBlok.Location = new System.Drawing.Point(150, 200);
            this.cmbBlok.Name = "cmbBlok";
            this.cmbBlok.Size = new System.Drawing.Size(200, 24);
            this.cmbBlok.TabIndex = 8;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.SteelBlue;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(150, 240);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 30);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.IndianRed;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(260, 240);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(100, 30);
            this.btnIptal.TabIndex = 10;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // OdaEkleDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(400, 290);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbBlok);
            this.Controls.Add(this.lblBlok);
            this.Controls.Add(this.numKapasite);
            this.Controls.Add(this.lblKapasite);
            this.Controls.Add(this.numKat);
            this.Controls.Add(this.lblKat);
            this.Controls.Add(this.txtOdaNo);
            this.Controls.Add(this.lblOdaNo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OdaEkleDuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda Kayıt";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKapasite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.Label lblKat;
        private System.Windows.Forms.NumericUpDown numKat;
        private System.Windows.Forms.Label lblKapasite;
        private System.Windows.Forms.NumericUpDown numKapasite;
        private System.Windows.Forms.Label lblBlok;
        private System.Windows.Forms.ComboBox cmbBlok;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
}