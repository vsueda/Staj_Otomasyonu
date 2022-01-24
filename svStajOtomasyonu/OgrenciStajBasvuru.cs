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
    public partial class OgrenciStajBasvuru : Form
    {
        public OgrenciStajBasvuru()
        {
            InitializeComponent();
        }
        public string yeniyol;
        public int ogrstjid;
        SqlBaglanti baglan = new SqlBaglanti();
        private void OgrenciStajBasvuru_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Pdf Dosyası |* *pdf; *nef | Tüm Dosyalar | *.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\sueda\\source\\repos\\svStajOtomasyonu\\svStajOtomasyonu" + "\\pdf\\" + Guid.NewGuid().ToString() + ".pdf";
            File.Copy(dosyayolu, yeniyol);
            pdfViewer1.LoadDocument(yeniyol);
            SqlCommand komut = new SqlCommand("Update StajBelgeleri set ZorunluStajBelgesi=@p1 where Ogrenci=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p2", ogrstjid);
            komut.Parameters.AddWithValue("@p1", Path.GetFileName(yeniyol));
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Pdf Dosyası |* *pdf; *nef | Tüm Dosyalar | *.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\sueda\\source\\repos\\svStajOtomasyonu\\svStajOtomasyonu" + "\\pdf\\" + Guid.NewGuid().ToString() + ".pdf";
            File.Copy(dosyayolu, yeniyol);
            pdfViewer1.LoadDocument(yeniyol);
            SqlCommand komut = new SqlCommand("Update StajBelgeleri set StajBasvuruFormu=@p1 where Ogrenci=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p2", ogrstjid);
            komut.Parameters.AddWithValue("@p1", Path.GetFileName(yeniyol));
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Pdf Dosyası |* *pdf; *nef | Tüm Dosyalar | *.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\sueda\\source\\repos\\svStajOtomasyonu\\svStajOtomasyonu" + "\\pdf\\" + Guid.NewGuid().ToString() + ".pdf";
            File.Copy(dosyayolu, yeniyol);
            pdfViewer1.LoadDocument(yeniyol);
            SqlCommand komut = new SqlCommand("Update StajBelgeleri set StajKabul=@p1 where Ogrenci=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p2", ogrstjid);
            komut.Parameters.AddWithValue("@p1", Path.GetFileName(yeniyol));
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Pdf Dosyası |* *pdf; *nef | Tüm Dosyalar | *.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\sueda\\source\\repos\\svStajOtomasyonu\\svStajOtomasyonu" + "\\pdf\\" + Guid.NewGuid().ToString() + ".pdf";
            File.Copy(dosyayolu, yeniyol);
            pdfViewer1.LoadDocument(yeniyol);
            SqlCommand komut = new SqlCommand("Update StajBelgeleri set StajTaahutname=@p1 where Ogrenci=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p2", ogrstjid);
            komut.Parameters.AddWithValue("@p1", Path.GetFileName(yeniyol));
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from StajBelgeleri where Ogrenci=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", ogrstjid);
            komut.ExecuteNonQuery();
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                
                yeniyol = "C:\\Users\\sueda\\source\\repos\\svStajOtomasyonu\\svStajOtomasyonu" + "\\pdf\\" + read[2].ToString();
                pdfViewer2.LoadDocument(yeniyol);
            }
            baglan.baglanti().Close();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from StajBelgeleri where Ogrenci=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", ogrstjid);
            komut.ExecuteNonQuery();
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {

                yeniyol = "C:\\Users\\sueda\\source\\repos\\svStajOtomasyonu\\svStajOtomasyonu" + "\\pdf\\" + read[3].ToString();
                pdfViewer2.LoadDocument(yeniyol);
            }
            baglan.baglanti().Close();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from StajBelgeleri where Ogrenci=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", ogrstjid);
            komut.ExecuteNonQuery();
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {

                yeniyol = "C:\\Users\\sueda\\source\\repos\\svStajOtomasyonu\\svStajOtomasyonu" + "\\pdf\\" + read[4].ToString();
                pdfViewer2.LoadDocument(yeniyol);
            }
            baglan.baglanti().Close();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from StajBelgeleri where Ogrenci=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", ogrstjid);
            komut.ExecuteNonQuery();
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {

                yeniyol = "C:\\Users\\sueda\\source\\repos\\svStajOtomasyonu\\svStajOtomasyonu" + "\\pdf\\" + read[5].ToString();
                pdfViewer2.LoadDocument(yeniyol);
            }
            baglan.baglanti().Close();
        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Pdf Dosyası |* *pdf; *nef | Tüm Dosyalar | *.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\sueda\\source\\repos\\svStajOtomasyonu\\svStajOtomasyonu" + "\\pdf\\" + Guid.NewGuid().ToString() + ".pdf";
            File.Copy(dosyayolu, yeniyol);
            pdfViewer1.LoadDocument(yeniyol);
            SqlCommand komut = new SqlCommand("Update StajBelgeleri set StajBasvuruFormu=@p1 where Ogrenci=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p2", ogrstjid);
            komut.Parameters.AddWithValue("@p1", Path.GetFileName(yeniyol));
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Pdf Dosyası |* *pdf; *nef | Tüm Dosyalar | *.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\sueda\\source\\repos\\svStajOtomasyonu\\svStajOtomasyonu" + "\\pdf\\" + Guid.NewGuid().ToString() + ".pdf";
            File.Copy(dosyayolu, yeniyol);
            pdfViewer1.LoadDocument(yeniyol);
            SqlCommand komut = new SqlCommand("Update StajBelgeleri set StajKabul=@p1 where Ogrenci=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p2", ogrstjid);
            komut.Parameters.AddWithValue("@p1", Path.GetFileName(yeniyol));
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Pdf Dosyası |* *pdf; *nef | Tüm Dosyalar | *.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\sueda\\source\\repos\\svStajOtomasyonu\\svStajOtomasyonu" + "\\pdf\\" + Guid.NewGuid().ToString() + ".pdf";
            File.Copy(dosyayolu, yeniyol);
            pdfViewer1.LoadDocument(yeniyol);
            SqlCommand komut = new SqlCommand("Update StajBelgeleri set StajTaahutname=@p1 where Ogrenci=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p2", ogrstjid);
            komut.Parameters.AddWithValue("@p1", Path.GetFileName(yeniyol));
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Pdf Dosyası |* *pdf; *nef | Tüm Dosyalar | *.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\sueda\\source\\repos\\svStajOtomasyonu\\svStajOtomasyonu" + "\\pdf\\" + Guid.NewGuid().ToString() + ".pdf";
            File.Copy(dosyayolu, yeniyol);
            pdfViewer1.LoadDocument(yeniyol);
            SqlCommand komut = new SqlCommand("Update StajBelgeleri set ZorunluStajBelgesi=@p1 where Ogrenci=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p2", ogrstjid);
            komut.Parameters.AddWithValue("@p1", Path.GetFileName(yeniyol));
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
        }
    }
}
