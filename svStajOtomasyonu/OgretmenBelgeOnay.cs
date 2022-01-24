﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;

namespace svStajOtomasyonu
{
    public partial class OgretmenBelgeOnay : Form
    {
        public int ogrbelgeid;
        public OgretmenBelgeOnay()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
            ogrenciTableAdapter1.Fill(stajdbogr1.Ogrenci);
            // This line of code is generated by Data Source Configuration Wizard
            ısYeriTableAdapter1.Fill(stajdbisyr1.IsYeri);
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {

        }
        String id;
        SqlBaglanti baglan = new SqlBaglanti();
        public string yeniyol;
        private void gridView1_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                id = (dr["OgrenciId"].ToString());//Burada int hatası alabilirsin
                
                SqlCommand komut = new SqlCommand("Select * from StajBelgeleri where Ogrenci=@p1", baglan.baglanti());
                komut.Parameters.AddWithValue("@p1", id);
                komut.ExecuteNonQuery();
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {

                    yeniyol = "C:\\Users\\sueda\\source\\repos\\svStajOtomasyonu\\svStajOtomasyonu" + "\\pdf\\" + read[2].ToString();
                    pdfViewer1.LoadDocument(yeniyol);
                    yeniyol = "C:\\Users\\sueda\\source\\repos\\svStajOtomasyonu\\svStajOtomasyonu" + "\\pdf\\" + read[3].ToString();
                    pdfViewer2.LoadDocument(yeniyol);
                    yeniyol = "C:\\Users\\sueda\\source\\repos\\svStajOtomasyonu\\svStajOtomasyonu" + "\\pdf\\" + read[4].ToString();
                    pdfViewer3.LoadDocument(yeniyol);
                }
                baglan.baglanti().Close();

            }
        }

        private void gridView2_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                id = (dr["IsyeriId"].ToString());//Burada int hatası alabilirsin
                
                SqlCommand komut = new SqlCommand("Select * from StajBelgeleri where IsYeriId=@p1", baglan.baglanti());
                komut.Parameters.AddWithValue("@p1", id);
                komut.ExecuteNonQuery();
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {

                    yeniyol = "C:\\Users\\sueda\\source\\repos\\svStajOtomasyonu\\svStajOtomasyonu" + "\\pdf\\" + read[9].ToString();
                    pdfViewer4.LoadDocument(yeniyol);
                }
                baglan.baglanti().Close();

            }
        }

        private void OgretmenBelgeOnay_Load(object sender, EventArgs e)
        {

        }
    }
}
