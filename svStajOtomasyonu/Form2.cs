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

namespace svStajOtomasyonu
{
    
    public partial class OgretmenGiris : Form
    {
        public OgretmenGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti baglan = new SqlBaglanti();
        OgretmenEkrani ogrEkran;
        Form1 frm1;
        int id;
        
        private void ogretmmenGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Ogretmen where OgretmenTc=@P1 and OgretmenSifre=@P2", baglan.baglanti());
            komut.Parameters.AddWithValue("@P1", girisOgretmenTc.Text);
            komut.Parameters.AddWithValue("@P2", girisOgretmenSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                SqlCommand komut2 = new SqlCommand("Select * from Ogretmen where OgretmenTc=@p1", baglan.baglanti());
                komut2.Parameters.AddWithValue("@p1", girisOgretmenTc.Text);
                komut2.ExecuteNonQuery();
                SqlDataReader read = komut2.ExecuteReader();
                while (read.Read())
                {
                    id = Convert.ToInt32(read[0]);

                }
                OgretmenEkrani ogr = new OgretmenEkrani() {
                    ogrid = id

                };
                ogr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }
        }
    }
}
