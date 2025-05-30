using System;
using System.Data;
using System.Windows.Forms;
using YurtÖğrenciOtomasyonSistem;

namespace YurtÖğrenciOtomasyonSistem
{
    public partial class OgrenciEkleDuzenleForm : Form
    {
        private int ogrenciID = -1; // -1 yeni kayıt anlamına gelir

        public OgrenciEkleDuzenleForm()
        {
            InitializeComponent();
            this.Text = "Yeni Öğrenci Ekle";
        }

        public OgrenciEkleDuzenleForm(int ogrenciID)
        {
            InitializeComponent();
            this.ogrenciID = ogrenciID;
            this.Text = "Öğrenci Düzenle";
            OgrenciBilgileriniYukle();
        }

        private void OgrenciBilgileriniYukle()
        {
            string query = $"SELECT * FROM Ogrenciler WHERE OgrenciID = {ogrenciID}";
            DataTable dt = Database.GetData(query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtTCKimlik.Text = row["TCKimlik"].ToString();
                txtAd.Text = row["Ad"].ToString();
                txtSoyad.Text = row["Soyad"].ToString();
                dtpDogumTarihi.Value = Convert.ToDateTime(row["DogumTarihi"]);
                txtCepTelefonu.Text = row["CepTelefonu"].ToString();
                txtAileTelefonu.Text = row["AileTelefonu"].ToString();
                txtEmail.Text = row["Email"].ToString();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!KontrolleriYap()) return;

            string query;
            if (ogrenciID == -1) // Yeni kayıt
            {
                query = $@"INSERT INTO Ogrenciler (TCKimlik, Ad, Soyad, DogumTarihi, CepTelefonu, AileTelefonu, Email)
                 VALUES ('{txtTCKimlik.Text}', '{txtAd.Text}', '{txtSoyad.Text}', 
                         '{dtpDogumTarihi.Value:yyyy-MM-dd}', '{txtCepTelefonu.Text}', 
                         '{txtAileTelefonu.Text}', '{txtEmail.Text}')";
            }
            else // Güncelleme
            {
                query = $@"UPDATE Ogrenciler SET 
                  TCKimlik='{txtTCKimlik.Text}', Ad='{txtAd.Text}', Soyad='{txtSoyad.Text}',
                  DogumTarihi='{dtpDogumTarihi.Value:yyyy-MM-dd}', CepTelefonu='{txtCepTelefonu.Text}',
                  AileTelefonu='{txtAileTelefonu.Text}', Email='{txtEmail.Text}'
                  WHERE OgrenciID={ogrenciID}";
            }

            int result = Database.ExecuteNonQuery(query);
            if (result > 0)
            {
                MessageBox.Show("İşlem başarılı!");
                this.Close();
            }
        }

        private bool KontrolleriYap()
        {
            if (string.IsNullOrWhiteSpace(txtTCKimlik.Text) || txtTCKimlik.Text.Length != 11)
            {
                MessageBox.Show("Geçerli bir TC Kimlik No giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                MessageBox.Show("Öğrenci adını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Öğrenci soyadını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCepTelefonu.Text))
            {
                MessageBox.Show("Cep telefonu numarasını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}