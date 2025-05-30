using System;
using System.Windows.Forms;

namespace YurtÖğrenciOtomasyonSistem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            OgrenciIslemleriForm ogrenciForm = new OgrenciIslemleriForm();
            ogrenciForm.Show();
            this.Hide();
        }

        private void btnOda_Click(object sender, EventArgs e)
        {
            OdaYonetimForm form = new OdaYonetimForm(); // Projenizdeki asıl adı bu olmalı
            form.Show();
            this.Hide();
        }

        private void btnGirisCikis_Click(object sender, EventArgs e)
        {
            GirisCikisTakipForm form = new GirisCikisTakipForm(); // Var olan form
            form.Show();
            this.Hide();
        }

        private void btnYemek_Click(object sender, EventArgs e)
        {
            YemekTakipForm yemekForm = new YemekTakipForm();
            yemekForm.Show();
            this.Hide();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            RaporlarForm form = new RaporlarForm();
            form.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak istediğinize emin misiniz?",
                "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}