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
    public partial class frmveliler : Form
    {
        public frmveliler()
        {
            InitializeComponent();
        }

        DbOkulEntities db=new DbOkulEntities();

        void listele() 
        {
            var query = from item in db.VELİLER
                        select new { item.VELİID, item.VELİANNE, item.VELİBABA, item.VELİTEL1, item.VELİTEL2, item.VELİMAİL };
            gridControl1.DataSource = query.ToList();
        }

        void temizle()
        {
            txtannead.Text = "";
            txtbabaad.Text = "";
            msktelefon1.Text = "";
            msktelefon2.Text = "";
            txtmail.Text = "";
        }


        private void frmveliler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            VELİLER veli = new VELİLER();
            veli.VELİANNE = txtannead.Text;
            veli.VELİBABA = txtbabaad.Text;
            veli.VELİTEL1 = msktelefon1.Text;
            veli.VELİTEL2 = msktelefon2.Text;
            veli.VELİMAİL = txtmail.Text;
            db.VELİLER.Add(veli);
            db.SaveChanges();
            listele();
            temizle();

        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            txtID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELİID").ToString();
            txtannead.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELİANNE").ToString();
            txtbabaad.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELİBABA").ToString();
            msktelefon1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELİTEL1").ToString();
            msktelefon2.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELİTEL2").ToString();
            txtmail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELİMAİL").ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id= Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELİID").ToString());
            //var item = db.VELİLER.Find(id);
            //item.VELİANNE=txtannead.Text;
            //item.VELİBABA=txtbabaad.Text;
            //item.VELİTEL1 = msktelefon1.Text;
            //item.VELİTEL2 = msktelefon2.Text;
            //item.VELİMAİL = txtmail.Text;
            //db.SaveChanges();
            //listele();
            //temizle();

            using (DbOkulEntities db = new DbOkulEntities())
            {
                var item = db.VELİLER.FirstOrDefault(x=>x.VELİID==id);
                item.VELİANNE=txtannead.Text;
                item.VELİBABA=txtbabaad.Text;
                item.VELİTEL1 = msktelefon1.Text;
                item.VELİTEL2 = msktelefon2.Text;
                item.VELİMAİL = txtmail.Text;
                db.SaveChanges();
                listele();
                temizle();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELİID").ToString());
            //var item = db.VELİLER.Find(id);
            //db.VELİLER.Remove(item);
            //db.SaveChanges() ;
            //listele();
            //temizle() ;
            using (DbOkulEntities db = new DbOkulEntities())
            {
                var item = db.VELİLER.First(x => x.VELİID == id);
                db.VELİLER.Remove(item);
                db.SaveChanges();
                listele();
                temizle();
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
