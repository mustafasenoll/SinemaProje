using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SinemaProje
{
    class SqlBağlantı
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=TOSHIBA\\SQLEXPRESS;Initial Catalog=SinemaProje;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
