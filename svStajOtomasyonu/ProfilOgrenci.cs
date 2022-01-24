using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace svStajOtomasyonu
{
    public partial class ProfilOgrenci : Form
    {
        public ProfilOgrenci()
        {
            InitializeComponent();
        }
         public string yeniyol;
        SqlBaglanti baglan = new SqlBaglanti();
        String isim, okul, mail, tel;
        public int ogrIdProf;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            xtraTabControl1.Visible = true;
            SqlCommand komut = new SqlCommand("Select * from Ogrenci where OgrenciId=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", ogrIdProf);
            komut.ExecuteNonQuery();
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textEdit4.Text = read[3].ToString();
                textEdit3.Text = read[4].ToString();
                textEdit1.Text = read[2].ToString();
                textEdit5.Text = read[8].ToString();
                textEdit7.Text = read[7].ToString();

            }
            baglan.baglanti().Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ProfilOgrenci_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Ogrenci where OgrenciId=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", ogrIdProf);
            komut.ExecuteNonQuery();
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                label1.Text = read[3].ToString() + " " + read[4].ToString();
                label2.Text = read[5].ToString();
                label4.Text = read[7].ToString();
                label5.Text = read[8].ToString();
                yeniyol = "C:\\Users\\sueda\\source\\repos\\svStajOtomasyonu\\svStajOtomasyonu" + "\\resimler\\" + read[9].ToString();
                pictureBox1.ImageLocation = yeniyol;
            }
            baglan.baglanti().Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Ogrenci set OgreciIsim=@p1, OgrenciSoyisim=@p2, OgrenciSifre=@p3, OgrenciMail=@p5, OgrenciTel=@p4 where OgrenciId=@p6", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", textEdit4.Text);
            komut.Parameters.AddWithValue("@p2", textEdit3.Text);
            komut.Parameters.AddWithValue("@p3", textEdit1.Text);
            komut.Parameters.AddWithValue("@p4", textEdit5.Text);
            komut.Parameters.AddWithValue("@p5", textEdit7.Text);
            komut.Parameters.AddWithValue("@p6", ogrIdProf);
            komut.ExecuteNonQuery();
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
            SqlCommand komut = new SqlCommand("Update Ogrenci set OgrenciFoto=@p1 where OgrenciId=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p2", ogrIdProf);
            komut.Parameters.AddWithValue("@p1", Path.GetFileName(yeniyol));
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
        }
    }
}
