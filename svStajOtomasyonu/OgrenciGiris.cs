using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace svStajOtomasyonu
{
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti baglan = new SqlBaglanti();
        OgrenciEkrani ogrEkran;
        Form1 frm1;
        int id;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Ogrenci where OgrenciTc=@P1 and OgrenciSifre=@P2", baglan.baglanti());
            komut.Parameters.AddWithValue("@P1", textEdit1.Text);
            komut.Parameters.AddWithValue("@P2", textEdit2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
              
                
                SqlCommand komut2 = new SqlCommand("Select * from Ogrenci where OgrenciTc=@p1", baglan.baglanti());
                komut2.Parameters.AddWithValue("@p1", textEdit1.Text);
                komut2.ExecuteNonQuery();
                SqlDataReader read = komut2.ExecuteReader();
                while (read.Read())
                {
                    id = Convert.ToInt32(read[0]);

                }
                OgrenciEkrani ogr = new OgrenciEkrani() {
                    ogrid = id

                };
                ogr.ShowDialog();


                
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }

        }

        private void OgrenciGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
