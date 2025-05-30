using System;
using System.Data;
using System.Windows.Forms;
using YurtÖğrenciOtomasyonSistem;

namespace YurtÖğrenciOtomasyonSistem
{
    public partial class OdaEkleDuzenleForm : Form
    {
        private int odaID = -1; // -1 ise yeni oda

        public OdaEkleDuzenleForm()
        {
            InitializeComponent();
            this.Text = "Yeni Oda Ekle";
        }

        public OdaEkleDuzenleForm(int odaID)
        {
            InitializeComponent();
            this.odaID = odaID;
            this.Text = "Oda Düzenle";
            OdaBilgileriniYukle();
        }

        private void OdaBilgileriniYukle()
        {
            string query = $"SELECT * FROM Odalar WHERE OdaID = {odaID}";
            DataTable dt = Database.GetData(query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtOdaNo.Text = row["OdaNo"].ToString();
                numKat.Value = Convert.ToInt32(row["Kat"]);
                numKapasite.Value = Convert.ToInt32(row["Kapasite"]);
                cmbBlok.Text = row["Blok"].ToString();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!KontrolleriYap()) return;

            string query;
            if (odaID == -1) // Yeni oda ekleme
            {
                // Oda numarası kontrolü
                string kontrolQuery = $"SELECT COUNT(*) FROM Odalar WHERE OdaNo = '{txtOdaNo.Text}'";
                int kayitSayisi = Convert.ToInt32(Database.GetData(kontrolQuery).Rows[0][0]);

                if (kayitSayisi > 0)
                {
                    MessageBox.Show("Bu oda numarası zaten kayıtlı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                query = $"INSERT INTO Odalar (OdaNo, Kat, Kapasite, Blok) VALUES (" +
                        $"'{txtOdaNo.Text}', {numKat.Value}, {numKapasite.Value}, '{cmbBlok.Text}')";
            }
            else // Oda güncelleme
            {
                query = $"UPDATE Odalar SET " +
                        $"OdaNo = '{txtOdaNo.Text}', " +
                        $"Kat = {numKat.Value}, " +
                        $"Kapasite = {numKapasite.Value}, " +
                        $"Blok = '{cmbBlok.Text}' " +
                        $"WHERE OdaID = {odaID}";
            }

            int affectedRows = Database.ExecuteNonQuery(query);

            if (affectedRows > 0)
            {
                if (odaID == -1)
                {
                    // Yeni oda için yatakları oluştur
                    int yeniOdaID = Convert.ToInt32(Database.GetData("SELECT SCOPE_IDENTITY()").Rows[0][0]);
                    YataklariOlustur(yeniOdaID, (int)numKapasite.Value);
                }

                MessageBox.Show("İşlem başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void YataklariOlustur(int odaID, int kapasite)
        {
            for (int i = 1; i <= kapasite; i++)
            {
                string query = $"INSERT INTO Yataklar (OdaID, YatakNo, Durum) VALUES ({odaID}, '{i}', 0)";
                Database.ExecuteNonQuery(query);
            }
        }

        private bool KontrolleriYap()
        {
            if (string.IsNullOrWhiteSpace(txtOdaNo.Text))
            {
                MessageBox.Show("Oda numarasını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbBlok.SelectedIndex == -1)
            {
                MessageBox.Show("Blok seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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