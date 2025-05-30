using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YurtÖğrenciOtomasyonSistem;

namespace YurtÖğrenciOtomasyonSistem
{
    public partial class OdaDolulukRaporuForm : Form
    {
        public OdaDolulukRaporuForm()
        {
            InitializeComponent();
        }


        private void OdaDolulukRaporuForm_Load(object sender, EventArgs e)
        {
            RaporuYukle();
        }

        private void RaporuYukle()
        {
            try
            {
                string query = @"SELECT 
                               o.OdaNo, 
                               o.Blok, 
                               o.Kat, 
                               o.Kapasite, 
                               o.DoluYatakSayisi,
                               (o.Kapasite - o.DoluYatakSayisi) AS BosYatakSayisi,
                               CASE 
                                   WHEN o.DoluYatakSayisi = 0 THEN 'BOŞ'
                                   WHEN o.DoluYatakSayisi = o.Kapasite THEN 'DOLU'
                                   ELSE 'KISMİ DOLU' 
                               END AS Durum
                               FROM Odalar o
                               ORDER BY o.Blok, o.Kat, o.OdaNo";

                DataTable dt = Database.GetData(query);
                dgvOdaRapor.DataSource = dt;

                // Kolon başlıklarını Türkçeleştirme
                dgvOdaRapor.Columns["OdaNo"].HeaderText = "Oda No";
                dgvOdaRapor.Columns["Blok"].HeaderText = "Blok";
                dgvOdaRapor.Columns["Kat"].HeaderText = "Kat";
                dgvOdaRapor.Columns["Kapasite"].HeaderText = "Kapasite";
                dgvOdaRapor.Columns["DoluYatakSayisi"].HeaderText = "Dolu Yatak";
                dgvOdaRapor.Columns["BosYatakSayisi"].HeaderText = "Boş Yatak";
                dgvOdaRapor.Columns["Durum"].HeaderText = "Durum";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            RaporuYukle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}