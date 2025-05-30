using System;
using System.Data;
using System.Windows.Forms;
using YurtÖğrenciOtomasyonSistem;

namespace YurtÖğrenciOtomasyonSistem
{
    public partial class YatakAtamaForm : Form
    {
        private int yatakID;

        public YatakAtamaForm(int yatakID)
        {
            InitializeComponent();
            this.yatakID = yatakID;
        }

        private void YatakAtamaForm_Load(object sender, EventArgs e)
        {
          

          
            // Yatağın oda ve yatak numarasını göster
            string yatakQuery = $@"SELECT o.OdaNo, y.YatakNo FROM Yataklar y
                         JOIN Odalar o ON y.OdaID = o.OdaID
                         WHERE y.YatakID = {yatakID}";
            DataTable dt = Database.GetData(yatakQuery);
            if (dt.Rows.Count > 0)
            {
                lblYatakBilgisi.Text = $"Oda: {dt.Rows[0]["OdaNo"]}, Yatak: {dt.Rows[0]["YatakNo"]}";
            }
            OgrencileriYukle();
        
        }

        private void OgrencileriYukle()
        {
            // Yurtta kalan ve yatağı olmayan öğrencileri yükle
            string query = @"SELECT o.OgrenciID, o.Ad + ' ' + o.Soyad AS AdSoyad 
                           FROM Ogrenciler o
                           LEFT JOIN Yataklar y ON o.OgrenciID = y.OgrenciID
                           WHERE o.Aktif = 1 AND y.OgrenciID IS NULL";

            DataTable dt = Database.GetData(query);

            cmbOgrenciler.DataSource = dt;
            cmbOgrenciler.DisplayMember = "AdSoyad";
            cmbOgrenciler.ValueMember = "OgrenciID";
        }

        private void btnAta_Click(object sender, EventArgs e)
        {
            if (cmbOgrenciler.SelectedIndex == -1)
            {
                MessageBox.Show("Öğrenci seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ogrenciID = Convert.ToInt32(cmbOgrenciler.SelectedValue);

            // Önce bu öğrencinin başka bir yatağı var mı kontrol et
            string kontrolQuery = $"SELECT COUNT(*) FROM Yataklar WHERE OgrenciID = {ogrenciID}";
            int yatakSayisi = Convert.ToInt32(Database.GetData(kontrolQuery).Rows[0][0]);

            if (yatakSayisi > 0)
            {
                MessageBox.Show("Bu öğrencinin zaten bir yatağı var.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Yatağı öğrenciye ata
            string query = $@"BEGIN TRANSACTION;
                           UPDATE Yataklar SET Durum = 1, OgrenciID = {ogrenciID} WHERE YatakID = {yatakID};
                           
                           -- Oda doluluk sayısını güncelle
                           DECLARE @OdaID INT = (SELECT OdaID FROM Yataklar WHERE YatakID = {yatakID});
                           UPDATE Odalar SET DoluYatakSayisi = DoluYatakSayisi + 1 WHERE OdaID = @OdaID;
                           
                           COMMIT;";

            int affectedRows = Database.ExecuteNonQuery(query);

            if (affectedRows > 0)
            {
                MessageBox.Show("Yatak başarıyla atandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Atama işlemi sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}