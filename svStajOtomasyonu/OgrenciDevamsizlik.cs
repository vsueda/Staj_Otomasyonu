using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Calendar;

namespace svStajOtomasyonu
{
    public partial class OgrenciDevamsizlik : Form
    {
        public OgrenciDevamsizlik()
        {
            InitializeComponent();
        }

        private void calendarControl1_DoubleClick(object sender, EventArgs e)
        {
            
               
            
        }

        private void calendarControl1_ClientSizeChanged(object sender, EventArgs e)
        {
         
        }

        private void calendarControl1_SelectionChanged(object sender, EventArgs e)
        {
           /* CalendarHitInfo hitInfo = calendarControl1.GetHitInfo();
            if (hitInfo.HitTest == CalendarHitInfoType.Cell)
            {
                DialogResult mesaj = MessageBox.Show("Seçili günde stajınızı gerçekleştiridiniz mi?", "Devamsızlık" + hitInfo.ToString(), MessageBoxButtons.YesNoCancel);
                if (mesaj == DialogResult.Yes)
                {
                    //
                }
                else if (mesaj == DialogResult.No)
                {
                    //seçili günü eksi olarak ekle
                }
                else
                {
                    //bişi yapma
                }
            }*/
        }
        private void calendarControl1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}
