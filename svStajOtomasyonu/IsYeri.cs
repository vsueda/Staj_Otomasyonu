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
    public partial class IsYeri : Form
    {
        public IsYeri()
        {
            InitializeComponent();
        }
        SqlBaglanti baglan = new SqlBaglanti();
        IsYeriEkrani isyeriEkran;
        Form1 frm1;
        int id;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From IsYeri where IsyeriNo=@P1 and IsyeriSifre=@P2", baglan.baglanti());
            komut.Parameters.AddWithValue("@P1", textEdit1.Text);
            komut.Parameters.AddWithValue("@P2", textEdit2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                SqlCommand komut2 = new SqlCommand("Select * from IsYeri where IsyeriNo=@p1", baglan.baglanti());
                komut2.Parameters.AddWithValue("@p1", textEdit1.Text);
                komut2.ExecuteNonQuery();
                SqlDataReader read = komut2.ExecuteReader();
                while (read.Read())
                {
                    id = Convert.ToInt32(read[0]);

                }
                IsYeriEkrani isyr = new IsYeriEkrani() {
                    isyeriid = id

                };
                isyr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }
        }
    }
}
