using System;
using System.Data;
using System.Windows.Forms;
using YurtÖğrenciOtomasyonSistem;

namespace YurtÖğrenciOtomasyonSistem
{
    public partial class GirisCikisRaporlariForm : Form
    {
        public GirisCikisRaporlariForm()
        {
            InitializeComponent();
        }

        private void GirisCikisRaporlariForm_Load(object sender, EventArgs e)
        {
            string query = @"SELECT o.Ad + ' ' + o.Soyad AS AdSoyad, 
                           g.GirisTarihi, g.CikisTarihi, 
                           CASE WHEN g.IzinliMi = 1 THEN 'EVET' ELSE 'HAYIR' END AS Izinli,
                           g.Aciklama
                           FROM GirisCikisKayitlari g
                           INNER JOIN Ogrenciler o ON g.OgrenciID = o.OgrenciID
                           ORDER BY g.GirisTarihi DESC";
            dataGridView1.DataSource = Database.GetData(query);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}