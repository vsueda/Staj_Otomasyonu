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
    public partial class IsYeriTaskGorevVer : Form
    {
        public IsYeriTaskGorevVer()
        {
            InitializeComponent();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                
                labelControl1.Text = dr["OgreciIsim"].ToString() + " " + dr["OgrenciSoyisim"].ToString();

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            labelControl3.Visible = true;
            simpleButton2.Visible = true;
            textEdit1.Visible = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textEdit1.ToString());
            labelControl3.Visible = false;
            simpleButton2.Visible = false;
            textEdit1.Visible = false;
        }
    }
}
