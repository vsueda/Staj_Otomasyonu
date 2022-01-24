using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svStajOtomasyonu
{
    class Login
    {
        SqlBaglanti baglan = new SqlBaglanti();
        int id;
        public int Giris_Yap(int no)
        {
            
            
            baglan.baglanti().Close();


            return id;
        }
    }
}
