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
using DevExpress.XtraGrid.Columns;

namespace svStajOtomasyonu
{
    public partial class OgretmenMesaj : Form
    {
        public OgretmenMesaj()
        {
            InitializeComponent();
            
            // This line of code is generated by Data Source Configuration Wizard
            mesajTableAdapter2.Fill(stajdbDataSetMesaj2.Mesaj);
        }
        SqlBaglanti baglan = new SqlBaglanti();
        public int ogrmesajid;
        String isim,id, mesaj, mesajKonu, mesajId, tc;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            textBox2.Text = id;
            textBox3.Text = mesajKonu;
            xtraTabPage2.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            textBox1.Text = mesaj;
            textBox3.Text = mesajKonu;
            xtraTabPage2.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Mesaj(gonderenId,aliciId,mesaj,mesajKonu) values (@p1,@p2,@p3,@p4)", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);//giriş yapan kullanıcı tc
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", textBox1.Text);
            komut.Parameters.AddWithValue("@p4", textBox3.Text);
        
            
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Mesaj gönderildi.");
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Mesaj where id=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", mesajId);
            komut.ExecuteNonQuery();
            SqlDataReader read = komut.ExecuteReader();
            baglan.baglanti().Close();
            mesajTableAdapter2.Fill(stajdbDataSetMesaj2.Mesaj);
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void OgretmenMesaj_Load(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Select * from Ogretmen where OgretmenId=@p1", baglan.baglanti());
            komut2.Parameters.AddWithValue("@p1", ogrmesajid);
            komut2.ExecuteNonQuery();
            SqlDataReader read = komut2.ExecuteReader();
            while (read.Read())
            {
                tc = read[1].ToString();

            }
            gridView1.Columns["aliciId"].FilterInfo = new ColumnFilterInfo("[aliciId]="+tc);//Buraya giriş yapan kullanıcı tc gelecek
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                id = dr["gonderenId"].ToString();
                SqlCommand komut = new SqlCommand("Select * from Ogrenci where OgrenciTc=@p1", baglan.baglanti());
                komut.Parameters.AddWithValue("@p1", id);
                komut.ExecuteNonQuery();
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    isim = read[3].ToString()+" " + read[4].ToString();
                }
                SqlCommand komut2 = new SqlCommand("Select * from IsYeri where IsyeriNo=@p1", baglan.baglanti());
                komut2.Parameters.AddWithValue("@p1", id);
                komut2.ExecuteNonQuery();
                SqlDataReader read2 = komut2.ExecuteReader();
                while (read2.Read())
                {
                    isim = read2[3].ToString();
                }
                textBox5.Text = isim;
                 mesajId =  dr["id"].ToString();
                
                SqlCommand komut3 = new SqlCommand("Select * from Mesaj where id=@p1", baglan.baglanti());
                komut3.Parameters.AddWithValue("@p1", mesajId);
                komut3.ExecuteNonQuery();
                SqlDataReader read3 = komut3.ExecuteReader();
                while (read3.Read())
                {
                    mesaj = read3[4].ToString();
                    mesajKonu = read3[5].ToString();

                }
                textBox4.Text = mesajKonu;
                labelControl1.Text = mesaj;
                baglan.baglanti().Close();

            }
        }
    }
}
