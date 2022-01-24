﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;

namespace svStajOtomasyonu
{
    public partial class OgrenciOnay : Form
    {
        public OgrenciOnay()
        {
            InitializeComponent();

            
            // This line of code is generated by Data Source Configuration Wizard
            ogrenciTableAdapter1.Fill(stajdbDataSet51.Ogrenci);
        }
        SqlBaglanti baglan = new SqlBaglanti();
        public int ogronayid;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Ogrenci set OgrenciOnay=@p1 where OgrenciTc=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", "Etkin");
            komut.Parameters.AddWithValue("@p2", labelControl1.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            ogrenciTableAdapter1.Fill(stajdbDataSet51.Ogrenci);


        }
        

        private void OgrenciOnay_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stajdbDataSet2.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter1.Fill(stajdbDataSet51.Ogrenci);



        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Ogrenci set OgrenciOnay=@p1 where OgrenciTc=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", "Etkin Değil");
            komut.Parameters.AddWithValue("@p2", labelControl1.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            ogrenciTableAdapter1.Fill(stajdbDataSet51.Ogrenci);

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {
          
        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void gridView2_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {
            
        }

        private void ogrenciBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        public string yeniyol;

        private void gridView2_FocusedRowObjectChanged_1(object sender, FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                labelControl1.Text = dr["OgrenciTc"].ToString();
                labelControl2.Text = dr["OgreciIsim"].ToString();
                labelControl3.Text = dr["OgrenciSoyisim"].ToString();
                labelControl4.Text = dr["OgrenciOkul"].ToString();
                labelControl5.Text = dr["OgrenciMail"].ToString();
                labelControl6.Text = dr["OgrenciTel"].ToString();
                SqlCommand komut = new SqlCommand("Select * from Ogrenci where OgreciIsim=@p1", baglan.baglanti());
                komut.Parameters.AddWithValue("@p1", labelControl2.Text.ToString());
                komut.ExecuteNonQuery();
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    
                    
                    yeniyol = "C:\\Users\\sueda\\source\\repos\\svStajOtomasyonu\\svStajOtomasyonu" + "\\resimler\\" + read[9].ToString();
                    pictureBox1.ImageLocation = yeniyol;
                }
                baglan.baglanti().Close();

            }
        }
    }
}