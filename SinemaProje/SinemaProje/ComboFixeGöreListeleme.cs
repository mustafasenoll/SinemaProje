using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaProje
{
    public partial class ComboFixeGöreListeleme : Form
    {
        public ComboFixeGöreListeleme()
        {
            InitializeComponent();
        }
        SqlBağlantı baglan = new SqlBağlantı();
        private void ComboFixeGöreListeleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sinemaProjeDataSet1.Filmler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmlerTableAdapter.Fill(this.sinemaProjeDataSet1.Filmler);



        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button dbtn = (sender as Button);
            BiletDetay frmDetay = new BiletDetay();
            frmDetay.FilmAd = comboBox1.Text;
            frmDetay.KoltukAd = dbtn.Text;
            frmDetay.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flp1.Controls.Clear();
            int baslaX = 1;
            int baslaY = 50;
            int btnsayi = 20;
            int boyutbol = Convert.ToInt32(Math.Ceiling(Math.Sqrt(btnsayi)));

            ArrayList Koltuklar = new ArrayList();
            SqlCommand komuts = new SqlCommand("Select KoltukAd from Biletler Where BiletFilmAd=@p1", baglan.baglanti());
            komuts.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dro = komuts.ExecuteReader();
            while (dro.Read())
            {
                Koltuklar.Add(dro["KoltukAd"]).ToString();
            }

            for (int i = 1; i < btnsayi; i++)
            {
                Button btn = new Button();
                btn.Name = "Buton" + i.ToString();
                btn.Text = "Koltuk" + i.ToString();
                btn.Size = new Size(flp1.Width / boyutbol, flp1.Height / (boyutbol * 2));
                btn.Location = new Point(baslaX, baslaY);
                flp1.Controls.Add(btn);
                baslaX += btn.Width + 10;
                if (baslaX + flp1.Width / boyutbol > flp1.Width)
                {
                    baslaX = 1;
                    baslaY = flp1.Height / (boyutbol * 2) + 5;

                }
                btn.Click += Btn_Click;
                if (Koltuklar.Contains(btn.Text))
                {
                    btn.BackColor = Color.Green;
                }
                else
                {
                    btn.BackColor = Color.Red;
                }
            }
        }

        private void flp1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
