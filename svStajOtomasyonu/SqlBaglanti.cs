using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace svStajOtomasyonu
{
    class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-A55UDMN\MSSQL;Initial Catalog=stajdb;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
