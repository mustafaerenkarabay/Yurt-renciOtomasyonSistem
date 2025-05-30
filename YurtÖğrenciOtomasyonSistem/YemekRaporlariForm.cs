using System;
using System.Data;
using System.Windows.Forms;
using YurtÖğrenciOtomasyonSistem;

namespace YurtÖğrenciOtomasyonSistem
{
    public partial class YemekRaporlariForm : Form
    {
        public YemekRaporlariForm()
        {
            InitializeComponent();
        }

        private void YemekRaporlariForm_Load(object sender, EventArgs e)
        {
            dtpBaslangic.Value = DateTime.Today.AddDays(-7);
            dtpBitis.Value = DateTime.Today;
            RaporGetir();
        }

        private void RaporGetir()
        {
            try
            {
                string baslangic = dtpBaslangic.Value.ToString("yyyy-MM-dd");
                string bitis = dtpBitis.Value.ToString("yyyy-MM-dd");

                string query = $@"SELECT 
                                y.YemekTarihi,
                                CASE y.YemekTipi 
                                    WHEN 1 THEN 'Kahvaltı' 
                                    WHEN 2 THEN 'Öğle Yemeği' 
                                    WHEN 3 THEN 'Akşam Yemeği' 
                                END AS YemekTipi,
                                o.Ad + ' ' + o.Soyad AS AdSoyad,
                                y.KayitZamani
                                FROM YemekKayitlari y
                                INNER JOIN Ogrenciler o ON y.OgrenciID = o.OgrenciID
                                WHERE y.YemekTarihi BETWEEN '{baslangic}' AND '{bitis}'
                                ORDER BY y.YemekTarihi DESC, y.YemekTipi";

                DataTable dt = Database.GetData(query);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor getirilirken hata oluştu: " + ex.Message);
            }
        }

        private void btnRaporGetir_Click(object sender, EventArgs e)
        {
            RaporGetir();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}