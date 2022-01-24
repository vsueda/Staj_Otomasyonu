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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        OgretmenGiris ogrtgiris;
        OgrenciGiris ogrgiris;
        IsYeri isyerigiris;

        private void OgretmenGirisMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ogrtgiris = new OgretmenGiris();
            ogrtgiris.MdiParent = this;
            ogrtgiris.Show();


        }

        private void ogrenciGirisMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            ogrgiris = new OgrenciGiris();
            ogrgiris.MdiParent = this;
            ogrgiris.Show();
        }

        private void isYeriGirisMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isyerigiris = new IsYeri();
            isyerigiris.MdiParent = this;
            isyerigiris.Show();
        }
    }
}
