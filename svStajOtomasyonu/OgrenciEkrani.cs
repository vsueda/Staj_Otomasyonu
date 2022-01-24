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
    public partial class OgrenciEkrani : Form
    {
        public OgrenciEkrani()
        {
            InitializeComponent();
        }
        public int ogrid;
        OgrenciDevamsizlik devamsizlik;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            devamsizlik = new OgrenciDevamsizlik();
            devamsizlik.MdiParent = this;
            devamsizlik.Show();
        }

        OgrenciTask ogrtask;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*ogrtask = new OgrenciTask();
            ogrtask.MdiParent = this;
            ogrtask.ogrIdTask = ogrid;
            ogrtask.ShowDialog();*/
            OgrenciTask fr = new OgrenciTask() {
                ogrIdTask = ogrid
            };
            fr.MdiParent = this;
            fr.Show();

        }

        OgrenciStajSonu ogrstajson;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ogrstajson = new OgrenciStajSonu();
            ogrstajson.MdiParent = this;
            ogrstajson.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        ProfilOgrenci prflogr;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           /* prflogr = new ProfilOgrenci();
            prflogr.MdiParent = this;
            prflogr.ogrIdProf = ogrid;
            prflogr.ShowDialog();*/
            ProfilOgrenci fr = new ProfilOgrenci() {
                ogrIdProf = ogrid
            };
            fr.MdiParent = this;
            fr.Show();
        }
        OgrenciStajBasvuru ogrbasvuru;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*ogrbasvuru = new OgrenciStajBasvuru();
            ogrbasvuru.MdiParent = this;
            ogrbasvuru.Show();*/

            OgrenciStajBasvuru fr = new OgrenciStajBasvuru() {
                ogrstjid = ogrid
            };
            fr.MdiParent = this;
            fr.Show();
        }

        OgrenciMesaj ogrMesaj;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            /*ogrMesaj = new OgrenciMesaj();
            ogrMesaj.MdiParent = this;
            ogrMesaj.Show();*/

            OgrenciMesaj fr = new OgrenciMesaj() {
                ogrmesajid = ogrid
            };
            fr.MdiParent = this;
            fr.Show();
        }

        private void OgrenciEkrani_Load(object sender, EventArgs e)
        {
            
        }
    }
}
