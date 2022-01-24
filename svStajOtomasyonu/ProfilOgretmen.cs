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
using System.IO;

namespace svStajOtomasyonu
{
    public partial class ProfilOgretmen : Form
    {
        public ProfilOgretmen()
        {
            InitializeComponent();
        }

        public string yeniyol;
        SqlBaglanti baglan = new SqlBaglanti();
        String isim, okul, mail, tel;
        public int ogrprofid;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            xtraTabControl1.Visible = true;
            SqlCommand komut = new SqlCommand("Select * from Ogretmen where OgretmenId=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", ogrprofid);
            komut.ExecuteNonQuery();
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textEdit4.Text = read[3].ToString();
                textEdit3.Text = read[4].ToString();
                textEdit1.Text = read[2].ToString();
                textEdit5.Text = read[7].ToString();
                textEdit7.Text = read[6].ToString();
               
            }
            baglan.baglanti().Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Ogretmen set OgretmenIsim=@p1, OgretmenSoyisim=@p2, OgretmenSifre=@p3, OgretmenMail=@p5, OgretmenTel=@p4 where OgretmenId=@p6", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", textEdit4.Text);
            komut.Parameters.AddWithValue("@p2", textEdit3.Text);
            komut.Parameters.AddWithValue("@p3", textEdit1.Text);
            komut.Parameters.AddWithValue("@p4", textEdit5.Text);
            komut.Parameters.AddWithValue("@p5", textEdit7.Text);
            komut.Parameters.AddWithValue("@p6", ogrprofid);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            
        }

        private void ProfilOgretmen_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Ogretmen where OgretmenId=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", ogrprofid);
            komut.ExecuteNonQuery();
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                label1.Text = read[3].ToString() + " " + read[4].ToString();
                label2.Text = read[5].ToString();
                label4.Text = read[6].ToString();
                label5.Text = read[7].ToString();
                yeniyol = "C:\\Users\\sueda\\source\\repos\\svStajOtomasyonu\\svStajOtomasyonu" + "\\resimler\\" + read[8].ToString();
                pictureBox1.ImageLocation = yeniyol;
            }
            baglan.baglanti().Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |* .jpg;*png;*nef | Tüm Dosyalar | *.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\sueda\\source\\repos\\svStajOtomasyonu\\svStajOtomasyonu" + "\\resimler\\" + Guid.NewGuid().ToString() + ".jpg";
            File.Copy(dosyayolu, yeniyol);
            pictureBox1.ImageLocation = yeniyol;
            SqlCommand komut = new SqlCommand("Update Ogretmen set OgretmenFoto=@p1 where OgretmenId=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p2", ogrprofid);
            komut.Parameters.AddWithValue("@p1", Path.GetFileName(yeniyol));
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();

        }
    }
}
