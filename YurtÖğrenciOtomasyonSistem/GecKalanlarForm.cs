using System;
using System.Data;
using System.Windows.Forms;
using YurtÖğrenciOtomasyonSistem;

namespace YurtÖğrenciOtomasyonSistem
{
    public partial class GecKalanlarForm : Form
    {
        public GecKalanlarForm()
        {
            InitializeComponent();
        }

        private void GecKalanlarForm_Load(object sender, EventArgs e)
        {
            GecKalanlariListele();
        }

        private void GecKalanlariListele()
        {
            try
            {
                string query = @"SELECT o.Ad + ' ' + o.Soyad as AdSoyad, o.CepTelefonu, o.AileTelefonu, 
                               g.GirisTarihi, g.Aciklama
                               FROM Ogrenciler o
                               LEFT JOIN GirisCikisKayitlari g ON o.OgrenciID = g.OgrenciID
                               WHERE o.Aktif=1 AND 
                               (g.GirisTarihi IS NULL OR 
                               (CONVERT(TIME, g.GirisTarihi) > '23:00:00' AND g.IzinliMi=0))";

                DataTable dt = Database.GetData(query);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            GecKalanlariListele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}