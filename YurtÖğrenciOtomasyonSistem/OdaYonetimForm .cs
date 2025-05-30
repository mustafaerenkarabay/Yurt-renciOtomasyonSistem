using System;
using System.Data;
using System.Windows.Forms;
using YurtÖğrenciOtomasyonSistem;

namespace YurtÖğrenciOtomasyonSistem
{
    public partial class OdaYonetimForm : Form
    {
        public OdaYonetimForm()
        {
            InitializeComponent();
        }

        private void OdaYonetimForm_Load(object sender, EventArgs e)
        {
            BloklariYukle();
            OdalariYukle();
        }

        private void BloklariYukle()
        {
            cmbBlokFiltre.Items.Clear();
            cmbBlokFiltre.Items.Add("Tüm Bloklar");

            string query = "SELECT DISTINCT Blok FROM Odalar WHERE Blok IS NOT NULL";
            DataTable dt = Database.GetData(query);

            foreach (DataRow row in dt.Rows)
            {
                cmbBlokFiltre.Items.Add(row["Blok"].ToString());
            }

            cmbBlokFiltre.SelectedIndex = 0;
        }

        private void OdalariYukle()
        {
            string query = "SELECT OdaID, OdaNo, Kat, Kapasite, DoluYatakSayisi, Blok FROM Odalar";

            if (cmbBlokFiltre.SelectedIndex > 0)
            {
                query += $" WHERE Blok = '{cmbBlokFiltre.SelectedItem}'";
            }

            DataTable dt = Database.GetData(query);
            dgvOdalar.DataSource = dt;

            // Kolon başlıklarını düzenle
            if (dgvOdalar.Columns.Count > 0)
            {
                dgvOdalar.Columns["OdaID"].Visible = false;
                dgvOdalar.Columns["OdaNo"].HeaderText = "Oda No";
                dgvOdalar.Columns["Kat"].HeaderText = "Kat";
                dgvOdalar.Columns["Kapasite"].HeaderText = "Kapasite";
                dgvOdalar.Columns["DoluYatakSayisi"].HeaderText = "Dolu Yatak";
                dgvOdalar.Columns["Blok"].HeaderText = "Blok";
            }
        }

        private void dgvOdalar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOdalar.SelectedRows.Count > 0)
            {
                int odaID = Convert.ToInt32(dgvOdalar.SelectedRows[0].Cells["OdaID"].Value);
                YataklariYukle(odaID);
            }
        }

        private void YataklariYukle(int odaID)
        {
            string query = $@"SELECT y.YatakID, y.YatakNo, 
                            CASE WHEN y.Durum = 1 THEN 'Dolu' ELSE 'Boş' END AS Durum,
                            ISNULL(o.Ad + ' ' + o.Soyad, '') AS Ogrenci
                            FROM Yataklar y
                            LEFT JOIN Ogrenciler o ON y.OgrenciID = o.OgrenciID
                            WHERE y.OdaID = {odaID}";
            DataTable dt = Database.GetData(query);
            dgvYataklar.DataSource = dt;

            // Kolon başlıklarını düzenle
            if (dgvYataklar.Columns.Count > 0)
            {
                dgvYataklar.Columns["YatakID"].Visible = false;
                dgvYataklar.Columns["YatakNo"].HeaderText = "Yatak No";
                dgvYataklar.Columns["Durum"].HeaderText = "Durum";
                dgvYataklar.Columns["Ogrenci"].HeaderText = "Öğrenci";
            }
        }

        private void btnOdaEkle_Click(object sender, EventArgs e)
        {
            OdaEkleDuzenleForm form = new OdaEkleDuzenleForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                OdalariYukle();
            }
        }

        private void btnOdaDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvOdalar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz odayı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int odaID = Convert.ToInt32(dgvOdalar.SelectedRows[0].Cells["OdaID"].Value);
            OdaEkleDuzenleForm form = new OdaEkleDuzenleForm(odaID);
            if (form.ShowDialog() == DialogResult.OK)
            {
                OdalariYukle();
            }
        }

        private void btnOdaSil_Click(object sender, EventArgs e)
        {
            if (dgvOdalar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz odayı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int odaID = Convert.ToInt32(dgvOdalar.SelectedRows[0].Cells["OdaID"].Value);
            string odaNo = dgvOdalar.SelectedRows[0].Cells["OdaNo"].Value.ToString();

            // Oda dolu mu kontrolü
            string kontrolQuery = $"SELECT COUNT(*) FROM Yataklar WHERE OdaID = {odaID} AND Durum = 1";
            int doluYatakSayisi = Convert.ToInt32(Database.GetData(kontrolQuery).Rows[0][0]);

            if (doluYatakSayisi > 0)
            {
                MessageBox.Show($"Bu oda silinemez çünkü {doluYatakSayisi} adet dolu yatağı var.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"{odaNo} numaralı odayı silmek istediğinize emin misiniz?", "Silme Onayı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Önce yatakları sil
                string yatakSilQuery = $"DELETE FROM Yataklar WHERE OdaID = {odaID}";
                Database.ExecuteNonQuery(yatakSilQuery);

                // Sonra odayı sil
                string odaSilQuery = $"DELETE FROM Odalar WHERE OdaID = {odaID}";
                int affectedRows = Database.ExecuteNonQuery(odaSilQuery);

                if (affectedRows > 0)
                {
                    MessageBox.Show("Oda başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OdalariYukle();
                }
                else
                {
                    MessageBox.Show("Silme işlemi sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnYatakAta_Click(object sender, EventArgs e)
        {
            if (dgvOdalar.SelectedRows.Count == 0 || dgvYataklar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen oda ve yatak seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int yatakID = Convert.ToInt32(dgvYataklar.SelectedRows[0].Cells["YatakID"].Value);
            string durum = dgvYataklar.SelectedRows[0].Cells["Durum"].Value.ToString();

            if (durum == "Dolu")
            {
                MessageBox.Show("Bu yatak zaten dolu. Önce boşaltmalısınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            YatakAtamaForm form = new YatakAtamaForm(yatakID);
            if (form.ShowDialog() == DialogResult.OK)
            {
                int odaID = Convert.ToInt32(dgvOdalar.SelectedRows[0].Cells["OdaID"].Value);
                YataklariYukle(odaID);
                OdalariYukle();
            }
        }

        private void btnYatakBosalt_Click(object sender, EventArgs e)
        {
            if (dgvOdalar.SelectedRows.Count == 0 || dgvYataklar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen oda ve yatak seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int yatakID = Convert.ToInt32(dgvYataklar.SelectedRows[0].Cells["YatakID"].Value);
            string durum = dgvYataklar.SelectedRows[0].Cells["Durum"].Value.ToString();

            if (durum == "Boş")
            {
                MessageBox.Show("Bu yatak zaten boş.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bu yatağı boşaltmak istediğinize emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = $"UPDATE Yataklar SET Durum = 0, OgrenciID = NULL WHERE YatakID = {yatakID}";
                int affectedRows = Database.ExecuteNonQuery(query);

                if (affectedRows > 0)
                {
                    // Oda doluluk sayısını güncelle
                    int odaID = Convert.ToInt32(dgvOdalar.SelectedRows[0].Cells["OdaID"].Value);
                    string dolulukQuery = $"UPDATE Odalar SET DoluYatakSayisi = DoluYatakSayisi - 1 WHERE OdaID = {odaID}";
                    Database.ExecuteNonQuery(dolulukQuery);

                    MessageBox.Show("Yatak başarıyla boşaltıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    YataklariYukle(odaID);
                    OdalariYukle();
                }
                else
                {
                    MessageBox.Show("İşlem sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbBlokFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdalariYukle();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}