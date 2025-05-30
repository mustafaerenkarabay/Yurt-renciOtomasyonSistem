using System;
using System.Windows.Forms;

namespace YurtÖğrenciOtomasyonSistem
{
    public partial class YemekTakipForm : Form
    {
        public YemekTakipForm()
        {
            InitializeComponent();
        }

        private void btnGunlukYemek_Click(object sender, EventArgs e)
        {
            GunlukYemekKaydiForm form = new GunlukYemekKaydiForm();
            form.ShowDialog();
        }

        private void btnYemekRapor_Click(object sender, EventArgs e)
        {
            YemekRaporlariForm form = new YemekRaporlariForm();
            form.ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}