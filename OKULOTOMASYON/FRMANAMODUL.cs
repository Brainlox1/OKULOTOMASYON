using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OKULOTOMASYON
{
    public partial class FRMANAMODUL : Form
    {
        public FRMANAMODUL()
        {
            InitializeComponent();
        }

        FrmOgretmenler frm1;

        frmogrenciler frm2;

        frmveliler frm3;

        frmayarlar frm4;

        private void btnogretmen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm1 == null || frm1.IsDisposed)
            {
                frm1 = new FrmOgretmenler();
                frm1.MdiParent = this;
                frm1.Show();
            }
        
        
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new frmogrenciler();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }

        private void btnveliler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new frmveliler();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }

        private void btnayarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new frmayarlar();
                frm4.MdiParent = this;
                frm4.Show();
            }
        }
    }
}
