using System;
using System.Data;
using System.Windows.Forms;
using YurtÖğrenciOtomasyonSistem;

namespace YurtÖğrenciOtomasyonSistem
{
    public partial class CikisKaydiForm : Form
    {
        public CikisKaydiForm()
        {
            InitializeComponent();
        }

        private void CikisKaydiForm_Load(object sender, EventArgs e)
        {
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
                int ogrenciID = Convert.ToInt32(cmbOgrenci.SelectedValue);
                string aciklama = txtAciklama.Text;

                // Önce son giriş kaydını bul
                string findQuery = $"SELECT TOP 1 KayitID FROM GirisCikisKayitlari WHERE OgrenciID={ogrenciID} AND CikisTarihi IS NULL ORDER BY GirisTarihi DESC";
                DataTable dt = Database.GetData(findQuery);

                if (dt != null && dt.Rows.Count > 0)
                {
                    int kayitID = Convert.ToInt32(dt.Rows[0]["KayitID"]);
                    string updateQuery = $"UPDATE GirisCikisKayitlari SET CikisTarihi=GETDATE(), Aciklama='{aciklama}' WHERE KayitID={kayitID}";

                    int result = Database.ExecuteNonQuery(updateQuery);

                    if (result > 0)
                    {
                        MessageBox.Show("Çıkış kaydı başarıyla oluşturuldu.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt işlemi başarısız oldu.");
                    }
                }
                else
                {
                    MessageBox.Show("Bu öğrencinin aktif bir giriş kaydı bulunamadı.");
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