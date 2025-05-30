using System;
using System.Data;
using System.Windows.Forms;
using YurtÖğrenciOtomasyonSistem;

namespace YurtÖğrenciOtomasyonSistem
{
    public partial class OgrenciIslemleriForm : Form
    {
        public OgrenciIslemleriForm()
        {
            InitializeComponent();
        }

        private void OgrenciIslemleriForm_Load(object sender, EventArgs e)
        {
            OgrencileriYukle();
        }

        private void OgrencileriYukle(string aramaKelimesi = "")
        {
            string query = "SELECT OgrenciID, TCKimlik, Ad, Soyad, DogumTarihi, CepTelefonu FROM Ogrenciler WHERE Aktif = 1";

            if (!string.IsNullOrEmpty(aramaKelimesi))
            {
                query += $" AND (Ad LIKE '%{aramaKelimesi}%' OR Soyad LIKE '%{aramaKelimesi}%' OR TCKimlik LIKE '%{aramaKelimesi}%')";
            }

            DataTable dt = Database.GetData(query);
            dgvOgrenciler.DataSource = dt;

            // Kolon başlıklarını Türkçeleştirme
            if (dgvOgrenciler.Columns.Count > 0)
            {
                dgvOgrenciler.Columns["OgrenciID"].HeaderText = "ID";
                dgvOgrenciler.Columns["TCKimlik"].HeaderText = "TC Kimlik";
                dgvOgrenciler.Columns["Ad"].HeaderText = "Adı";
                dgvOgrenciler.Columns["Soyad"].HeaderText = "Soyadı";
                dgvOgrenciler.Columns["DogumTarihi"].HeaderText = "Doğum Tarihi";
                dgvOgrenciler.Columns["CepTelefonu"].HeaderText = "Telefon";
            }
        }

        private void btnYeniOgrenci_Click(object sender, EventArgs e)
        {
            OgrenciEkleDuzenleForm ogrenciForm = new OgrenciEkleDuzenleForm();
            ogrenciForm.ShowDialog();
            OgrencileriYukle();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvOgrenciler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz öğrenciyi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ogrenciID = Convert.ToInt32(dgvOgrenciler.SelectedRows[0].Cells["OgrenciID"].Value);
            OgrenciEkleDuzenleForm ogrenciForm = new OgrenciEkleDuzenleForm(ogrenciID);
            ogrenciForm.ShowDialog();
            OgrencileriYukle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvOgrenciler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz öğrenciyi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Öğrenciyi silmek istediğinize emin misiniz?", "Silme Onayı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int ogrenciID = Convert.ToInt32(dgvOgrenciler.SelectedRows[0].Cells["OgrenciID"].Value);

                string query = $"UPDATE Ogrenciler SET Aktif = 0 WHERE OgrenciID = {ogrenciID}";
                int affectedRows = Database.ExecuteNonQuery(query);

                if (affectedRows > 0)
                {
                    MessageBox.Show("Öğrenci başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OgrencileriYukle();
                }
                else
                {
                    MessageBox.Show("Silme işlemi sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            OgrencileriYukle(txtAra.Text);
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            // Anlık arama için
            OgrencileriYukle(txtAra.Text);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}