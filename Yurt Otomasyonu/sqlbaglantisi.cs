using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yurt_Otomasyonu
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-S59HMG2\\MSSQLSERVER03;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True;");
            baglan.Open();
            return baglan;
        }
    }
}
