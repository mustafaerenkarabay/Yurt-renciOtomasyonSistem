using System;
using System.Data;
using System.Windows.Forms;
using YurtÖğrenciOtomasyonSistem;

namespace YurtÖğrenciOtomasyonSistem
{
    public partial class GunlukYemekKaydiForm : Form
    {
        public GunlukYemekKaydiForm()
        {
            InitializeComponent();
        }

        private void GunlukYemekKaydiForm_Load(object sender, EventArgs e)
        {
            dtpTarih.Value = DateTime.Today;
            cmbYemekTipi.SelectedIndex = 0;
            OgrenciListele();
        }

        private void OgrenciListele()
        {
            try
            {
                string query = "SELECT OgrenciID, Ad + ' ' + Soyad as AdSoyad FROM Ogrenciler WHERE Aktif=1";
                DataTable dt = Database.GetData(query);

                cmbOgrenci.DataSource = dt;
                cmbOgrenci.DisplayMember = "AdSoyad";
                cmbOgrenci.ValueMember = "OgrenciID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci listesi yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tarih = dtpTarih.Value.Date;
                int yemekTipi = cmbYemekTipi.SelectedIndex + 1; // 1: Kahvaltı, 2: Öğle, 3: Akşam
                int ogrenciID = Convert.ToInt32(cmbOgrenci.SelectedValue);

                // Aynı öğrencinin aynı gün aynı yemeği yiyip yemediğini kontrol et
                string kontrolQuery = $"SELECT COUNT(*) FROM YemekKayitlari WHERE OgrenciID={ogrenciID} AND YemekTarihi='{tarih.ToString("yyyy-MM-dd")}' AND YemekTipi={yemekTipi}";
                DataTable kontrolDt = Database.GetData(kontrolQuery);

                if (kontrolDt != null && Convert.ToInt32(kontrolDt.Rows[0][0]) > 0)
                {
                    MessageBox.Show("Bu öğrenci zaten bu öğünü yemiş olarak kayıtlı!");
                    return;
                }

                string query = $"INSERT INTO YemekKayitlari (OgrenciID, YemekTarihi, YemekTipi, YendiMi) " +
                              $"VALUES ({ogrenciID}, '{tarih.ToString("yyyy-MM-dd")}', {yemekTipi}, 1)";

                int result = Database.ExecuteNonQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Yemek kaydı başarıyla oluşturuldu.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kayıt işlemi başarısız oldu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}