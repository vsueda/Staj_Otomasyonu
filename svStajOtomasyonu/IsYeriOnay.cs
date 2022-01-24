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
    public partial class IsYeriOnay : Form
    {
        public IsYeriOnay()
        {
            InitializeComponent();
         
            ısYeriTableAdapter1.Fill(stajdbDataSet81.IsYeri);
        }
        SqlBaglanti baglan = new SqlBaglanti();
        public int ogrisonay;
        private void IsYeriOnay_Load(object sender, EventArgs e)
        {
           
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                labelControl6.Text = dr["IsyeriTel"].ToString();
                labelControl1.Text = dr["IsyeriNo"].ToString();
                labelControl2.Text = dr["IsyeriIsim"].ToString();
                labelControl3.Text = dr["IsyeriIl"].ToString();
                labelControl4.Text = dr["IsyeriAdres"].ToString();
                labelControl5.Text = dr["IsyeriMail"].ToString();

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update IsYeri set IsyeriOnay=@p1 where IsyeriNo=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", "Etkin");
            komut.Parameters.AddWithValue("@p2", labelControl1.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            ısYeriTableAdapter1.Fill(stajdbDataSet81.IsYeri);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update IsYeri set IsyeriOnay=@p1 where IsyeriNo=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", "Etkin Değil");
            komut.Parameters.AddWithValue("@p2", labelControl1.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            ısYeriTableAdapter1.Fill(stajdbDataSet81.IsYeri);
        }

        private void stajdbDataSet7BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
