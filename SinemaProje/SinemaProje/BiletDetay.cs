using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SinemaProje
{
    public partial class BiletDetay : Form
    {
        public BiletDetay()
        {
            InitializeComponent();
        }
        public string KoltukAd;
        public string FilmAd;
        SqlBağlantı baglan = new SqlBağlantı();
        private void BiletDetay_Load(object sender, EventArgs e)
        {
            lblFilm.Text = FilmAd;
            lblKoltuk.Text = KoltukAd;
        }

        private void btnBilet_Click(object sender, EventArgs e)
        {
            SqlCommand komute = new SqlCommand("INSERT INTO Biletler(BiletAd,KoltukAd,BiletFilmAd) values (@b1,@b2,@b3)", baglan.baglanti());
            komute.Parameters.AddWithValue("@b1", txtAd.Text);
            komute.Parameters.AddWithValue("@b2", lblKoltuk.Text);
            komute.Parameters.AddWithValue("@b3", lblFilm.Text);
            komute.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Bilet Alma işlemi başarılıdır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
