using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace svStajOtomasyonu
{
    public partial class OgretmenEkrani : Form
    {
        public OgretmenEkrani()
        {
            InitializeComponent();
        }
        OgretmenBelgeOnay ogrBelgeonay;
        public int ogrid;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            OgretmenBelgeOnay fr = new OgretmenBelgeOnay() {
                ogrbelgeid = ogrid
            };
            fr.MdiParent = this;
            fr.Show();

        }
        OgretmenStajSonuc stjsnc;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OgretmenStajSonuc fr = new OgretmenStajSonuc() {
                ogrsonucid = ogrid
            };
            fr.MdiParent = this;
            fr.Show();

        }
        Form1 frm1;
        private void OgretmenEkrani_Load(object sender, EventArgs e)
        {
           
        }
        OgrenciOnay ogrOnay;
        private void ogrenciOnayButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            OgrenciOnay fr = new OgrenciOnay() {
                ogronayid = ogrid
            };
            fr.MdiParent = this;
            fr.Show();
        }

        IsYeriOnay isyOnay;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsYeriOnay fr = new IsYeriOnay() {
                ogrisonay = ogrid
            };
            fr.MdiParent = this;
            fr.Show();
        }

        ProfilOgretmen profilOgretmen;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProfilOgretmen fr = new ProfilOgretmen() {
                ogrprofid = ogrid
            };
            fr.MdiParent = this;
            fr.Show();
        }
        OgretmenMesaj ogrMesasj;
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OgretmenMesaj fr = new OgretmenMesaj() {
                ogrmesajid = ogrid
            };
            fr.MdiParent = this;
            fr.Show();
        }
    }
}
