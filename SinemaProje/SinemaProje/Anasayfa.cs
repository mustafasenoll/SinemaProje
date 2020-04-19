using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SinemaProje
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        SqlBağlantı baglan = new SqlBağlantı();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sinemaProjeDataSet.Filmler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmlerTableAdapter.Fill(this.sinemaProjeDataSet.Filmler);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Filmler(FilmAd) values(@p1)", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", txtFilmAdı.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Kayıt Başarılı.");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2) 
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                Koltuklar frmKoltuk = new Koltuklar();
                frmKoltuk.filmadi = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                frmKoltuk.Show();

            }
        }

        private void btnBilet_Click(object sender, EventArgs e)
        {
            ComboFixeGöreListeleme frmCombo = new ComboFixeGöreListeleme();
            frmCombo.Show();
        }
    }
}
