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
    public partial class IsYeriEkrani : Form
    {
        public IsYeriEkrani()
        {
            InitializeComponent();
        }
        public int isyeriid;

        IsYeriStajBasvuru isyeribasvuru;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            IsYeriStajBasvuru fr = new IsYeriStajBasvuru() {
                isyeribasid = isyeriid
            };
            fr.MdiParent = this;
            fr.Show();
        }

        IsyeriMesaj ismesaj;
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsyeriMesaj fr = new IsyeriMesaj() {
                isyerimesajid = isyeriid
            };
            fr.MdiParent = this;
            fr.Show();
        }

        IsYeriTask task;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsYeriTask fr = new IsYeriTask() {
                isyeritaskid = isyeriid
            };
            fr.MdiParent = this;
            fr.Show();
        }

        private void IsYeriEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
