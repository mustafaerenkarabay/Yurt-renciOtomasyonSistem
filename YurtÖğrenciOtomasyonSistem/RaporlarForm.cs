using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtÖğrenciOtomasyonSistem
{
    public partial class RaporlarForm : Form
    {
        public RaporlarForm()
        {
            InitializeComponent();
        }

        private void btnOgrenciRapor_Click(object sender, EventArgs e)
        {
            OgrenciListesiRaporuForm form = new OgrenciListesiRaporuForm();
            form.ShowDialog();
        }

        private void btnOdaRapor_Click(object sender, EventArgs e)
        {
            OdaDolulukRaporuForm form = new OdaDolulukRaporuForm();
            form.ShowDialog();
        }

        private void btnYemekRapor_Click(object sender, EventArgs e)
        {
            YemekRaporlariForm form = new YemekRaporlariForm(); // Zaten var
            form.ShowDialog();
        }

        private void btnGirisCikisRapor_Click(object sender, EventArgs e)
        {
            GirisCikisRaporlariForm form = new GirisCikisRaporlariForm();
            form.ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
