using System;
using System.Data;
using System.Windows.Forms;
using YurtÖğrenciOtomasyonSistem;

namespace YurtÖğrenciOtomasyonSistem
{
    public partial class OgrenciListesiRaporuForm : Form
    {
        public OgrenciListesiRaporuForm()
        {
            InitializeComponent();
        }

        private void OgrenciListesiRaporuForm_Load(object sender, EventArgs e)
        {
            string query = @"SELECT o.TCKimlik, o.Ad, o.Soyad, o.CepTelefonu, 
                           oda.OdaNo, y.YatakNo
                           FROM Ogrenciler o
                           LEFT JOIN Yataklar y ON o.OgrenciID = y.OgrenciID
                           LEFT JOIN Odalar oda ON y.OdaID = oda.OdaID
                           WHERE o.Aktif = 1";
            dataGridView1.DataSource = Database.GetData(query);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}