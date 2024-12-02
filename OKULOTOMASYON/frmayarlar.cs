using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using System.Runtime.ConstrainedExecution;
using System.Data.Entity.Infrastructure;

namespace OKULOTOMASYON
{
    public partial class frmayarlar : Form
    {
        public frmayarlar()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        DbOkulEntities db = new DbOkulEntities();

        //adonetogrtşifre
        void listele()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Execute AyarlarOgretmenler", bgl.baglanti());
            da1.Fill(dt1);
            gridControl1.DataSource = dt1;
        }

        //entity framework öğrenci listele
        void ogrlistele()
        {
            gridControl2.DataSource= db.AyarlarOgrenciler();
        }

        void temizle()
        {
            txtogrtıd.Text = "";
            txtogrıd.Text = "";
            txtogrtbrans.Text = "";
            txtsinif.Text = "";
            txtogrtsifre.Text = "";
            txtogrsifre.Text = "";
            mskogrttc.Text = "";
            mskogrtc.Text = "";
            pictureEditogrt.Text = "";
            pictureEditogr.Text = "";
            lookogrtad.Text = "";
            lookograd.Text = "";
            lookogrtad.Properties.NullText ="Öğretmen Seçiniz";
            lookograd.Properties.NullText = "Öğrenci Seçiniz";
        }

        //adonetlookupogrtverigetirme

        void ogretmenlistesi()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select OGTRID,(OGRTAD+' '+OGRTSOYAD) AS 'OGRTADSOYAD',OGRTBRANS from OGRETMENLER", bgl.baglanti());
            da2.Fill(dt2);
            lookogrtad.Properties.ValueMember = "OGTRID";
            lookogrtad.Properties.DisplayMember = "OGRTADSOYAD";
            lookogrtad.Properties.NullText = "Öğretmen Seçiniz";
            lookogrtad.Properties.DataSource = dt2;
        }

        //entity ile lookupedit veri getirme
        void ogrencilistesi() 
        {
            var deger = from item in db.OGRENCİLER
                        select new
                        {
                            OGRID = item.OGRID,
                            OGRADSOYAD = item.OGRAD + " " + item.OGRSOYAD,
                            OGRSINIF = item.OGRSINIF,

                        };
            lookograd.Properties.ValueMember = "OGRID";
            lookograd.Properties.DisplayMember = "OGRADSOYAD";
            lookograd.Properties.NullText = "Öğrenci Seçiniz";
            lookograd.Properties.DataSource = deger.ToList();
        }
        

        private void frmayarlar_Load(object sender, EventArgs e)
        {
            listele();
            ogretmenlistesi();
            ogrencilistesi();
            ogrlistele();
            temizle();
        }

        //adonet ile gridkontrol verilerini araçlara taşıma
        public string yeniyol;
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtogrtıd.Text = dr["AYARLARID"].ToString();
                lookogrtad.Text = dr["OGRTADSOYAD"].ToString();
                txtogrtbrans.Text = dr["OGRTBRANS"].ToString();
                mskogrttc.Text = dr["OGRTTC"].ToString();
                txtogrtsifre.Text = dr["OGRTSİFRE"].ToString();
                yeniyol = "C:\\Users\\ACER\\Desktop\\c# OTOMASYON\\OKULOTOMASYON\\OKULOTOMASYON" + "\\resimler\\" + dr["OGRTFOTO"].ToString();
                pictureEditogrt.Image = Image.FromFile(yeniyol);

            }
        }
        //adonet ile lookup edit seçimi sonrası veri düzeltem
        private void lookogrtad_Properties_EditValueChanged(object sender, EventArgs e)
        {
            txtogrtsifre.Text = "";

            SqlCommand komut = new SqlCommand("select * from OGRETMENLER where OGTRID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lookogrtad.ItemIndex +1);
            SqlDataReader dr3 = komut.ExecuteReader();
            while (dr3.Read())
            {
                txtogrtıd.Text = dr3["OGTRID"].ToString();
                txtogrtbrans.Text = dr3["OGRTBRANS"].ToString();
                mskogrttc.Text = dr3["OGRTTC"].ToString();
                yeniyol = "C:\\Users\\ACER\\Desktop\\c# OTOMASYON\\OKULOTOMASYON\\OKULOTOMASYON" + "\\resimler\\" + dr3["OGRTFOTO"].ToString();
                pictureEditogrt.Image = Image.FromFile(yeniyol);
            }
            bgl.baglanti().Close();
        }



        //öğretmenler şifre kaydetme
        private void btnogrtkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("insert into AYARLAR (AYARLARID,OGRTSİFRE) values(@p1,@p2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtogrtıd.Text);
            komut2.Parameters.AddWithValue("@p2", txtogrtsifre.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Şifre Oluşturuldu", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();

        }

        // adonet öğretmenler şifre güncelleme
        private void btnogrtguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("update AYARLAR set OGRTSİFRE=@p1 where AYARLARID=@p2",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", txtogrtsifre.Text);
            komut3.Parameters.AddWithValue("@p2", txtogrtıd.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Şifre Güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();

        }

        private void btnogrttemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            txtogrıd.Text=gridView2.GetRowCellValue(gridView2.FocusedRowHandle,"AYARLAROGRID").ToString();
            lookograd.Text=gridView2.GetRowCellValue(gridView2.FocusedRowHandle,"OGRADSOYAD") .ToString();
            txtsinif .Text= gridView2.GetRowCellValue(gridView2.FocusedRowHandle,"OGRSINIF").ToString();
            mskogrtc.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OGRTC").ToString();
            txtogrsifre.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OGRSİFRE").ToString();
            string uzanti= gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OGRFOTO").ToString();
            yeniyol = "C:\\Users\\ACER\\Desktop\\c# OTOMASYON\\OKULOTOMASYON\\OKULOTOMASYON" + "\\resimler\\" + uzanti;
            pictureEditogr.Image=Image.FromFile(yeniyol);
        }

        //entity ile lookupedit seçim aracı olarak kullanma
        private void lookograd_Properties_EditValueChanged(object sender, EventArgs e)
        {
            txtogrsifre.Text = "";

            using (DbOkulEntities db = new DbOkulEntities())
            {
                OGRENCİLER sorgu = db.OGRENCİLER.Find(lookograd.ItemIndex + 1);
                txtogrıd.Text = sorgu.OGRID.ToString();
                txtsinif.Text= sorgu.OGRSINIF.ToString();
                mskogrtc.Text= sorgu.OGRTC.ToString();
                yeniyol = "C:\\Users\\ACER\\Desktop\\c# OTOMASYON\\OKULOTOMASYON\\OKULOTOMASYON" + "\\resimler\\" + sorgu.OGRFOTO;
                pictureEditogr.Image= Image.FromFile(yeniyol);

            }
        }

        private void btnogrkaydet_Click(object sender, EventArgs e)
        {
            OGRAYARLAR komut= new OGRAYARLAR();
            komut.AYARLAROGRID = Convert.ToInt32(txtogrıd.Text);
            komut.OGRSİFRE = txtogrsifre.Text;
            db.OGRAYARLARs.Add(komut);
            db.SaveChanges();
            MessageBox.Show("Şifre Kaydedildi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ogrlistele();
            temizle();
            
        }

        private void btnogrguncelle_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32( gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "AYARLAROGRID"));
            var item = db.OGRAYARLARs.FirstOrDefault(x => x.AYARLAROGRID == id);
            item.OGRSİFRE= txtogrsifre.Text;
            db.SaveChanges();
            MessageBox.Show("Şifre Güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ogrlistele();
            temizle();

        }

        private void btnogrtemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
