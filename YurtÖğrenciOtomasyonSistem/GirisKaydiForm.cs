using System;
using System.Data;
using System.Windows.Forms;
using YurtÖğrenciOtomasyonSistem;

namespace YurtÖğrenciOtomasyonSistem
{
    public partial class GirisKaydiForm : Form
    {
        public GirisKaydiForm()
        {
            InitializeComponent();
        }

        private void GirisKaydiForm_Load(object sender, EventArgs e)
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
                bool izinli = chkIzinli.Checked;
                string aciklama = txtAciklama.Text;

                string query = $"INSERT INTO GirisCikisKayitlari (OgrenciID, GirisTarihi, IzinliMi, Aciklama) " +
                              $"VALUES ({ogrenciID}, GETDATE(), {(izinli ? 1 : 0)}, '{aciklama}')";

                int result = Database.ExecuteNonQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Giriş kaydı başarıyla oluşturuldu.");
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