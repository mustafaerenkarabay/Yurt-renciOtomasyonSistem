using System;
using System.Windows.Forms;

namespace YurtÖğrenciOtomasyonSistem
{
    public partial class GirisCikisTakipForm : Form
    {
        public GirisCikisTakipForm()
        {
            InitializeComponent();
        }

        private void btnGirisKaydi_Click(object sender, EventArgs e)
        {
            GirisKaydiForm form = new GirisKaydiForm();
            form.ShowDialog();
        }

        private void btnCikisKaydi_Click(object sender, EventArgs e)
        {
            CikisKaydiForm form = new CikisKaydiForm();
            form.ShowDialog();
        }

        private void btnGecKalanlar_Click(object sender, EventArgs e)
        {
            GecKalanlarForm form = new GecKalanlarForm();
            form.ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}