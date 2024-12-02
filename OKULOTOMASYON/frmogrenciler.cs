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

namespace OKULOTOMASYON
{
    public partial class frmogrenciler : Form
    {
        public frmogrenciler()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl=new Sqlbaglantisi();


        void listele() 
        {
            //5.SINIF
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Execute OgrenciVeli5",bgl.baglanti());
            da1.Fill(dt1);
            grdctrl5.DataSource = dt1;

            //6.SINIF
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Execute OgrenciVeli6", bgl.baglanti());
            da2.Fill(dt2);
            grdctrl6.DataSource = dt2;

            //7.SINIF
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Execute OgrenciVeli7", bgl.baglanti());
            da3.Fill(dt3);
            grdctrl7.DataSource = dt3;

            //8.SINIF
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("Execute OgrenciVeli8", bgl.baglanti());
            da4.Fill(dt4);
            grdctrl8.DataSource = dt4;
        }

        void velilistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select VELİID,(VELİANNE+' | '+VELİBABA) AS 'VELİ ANNE BABA' FROM VELİLER", bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "VELİID";
            lookUpEdit1.Properties.DisplayMember = "VELİ ANNE BABA";
            lookUpEdit1.Properties.DataSource = dt;
        }

        void sehirekle() 
        {
            SqlCommand komut = new SqlCommand("select * from Iller",bgl.baglanti());
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                cmbil.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }

        void temizle() 
        {
            txtID.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            mskogrencino.Text = "";
            msktc.Text = "";
            rbbtnbayan.Checked = false;
            rbbtnerkek.Checked = false;
            cmbsinif.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            dateEdit1.Text = "";
            rchadres.Text = "";
            pictureEdit1.Text = "";
        }

        private void frmogrenciler_Load(object sender, EventArgs e)
        {
            listele();
            sehirekle();
            temizle();
            velilistesi();
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilce.Properties.Items.Clear();
            cmbilce.Text = "";


            SqlCommand komut = new SqlCommand("select * from Ilceler where IlID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbil.SelectedIndex +1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbilce.Properties.Items.Add(dr[2]);
            }
            bgl.baglanti().Close();
        }

        public string cinsiyet;

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into OGRENCİLER (OGRAD,OGRSOYAD,OGRNO,OGRSINIF,OGRDOGTAR,OGRCİNSİYET,OGRTC,OGRİL,OGRİLCE,OGRADRES,OGRFOTO,OGRVELIID) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskogrencino.Text);
            komut.Parameters.AddWithValue("@p4", cmbsinif.Text);
            komut.Parameters.AddWithValue("@p5", dateEdit1.Text);
            if (rbbtnerkek.Checked == true) 
            {
                komut.Parameters.AddWithValue("@p6", cinsiyet="E");
            }
            else
            {
                komut.Parameters.AddWithValue("@p6", cinsiyet="B");
            }
            
            komut.Parameters.AddWithValue("@p7", msktc.Text);
            komut.Parameters.AddWithValue("@p8", cmbil.Text);
            komut.Parameters.AddWithValue("@p9", cmbilce.Text);
            komut.Parameters.AddWithValue("@p10", rchadres.Text);
            komut.Parameters.AddWithValue("@p11", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p12", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["OGRID"].ToString();
                txtad.Text= dr["OGRAD"].ToString() ;
                txtsoyad.Text = dr["OGRSOYAD"].ToString();
                msktc.Text = dr["OGRTC"].ToString();
                mskogrencino.Text = dr["OGRNO"].ToString();
                cmbsinif.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCİNSİYET"].ToString() == "E") 
                {
                    rbbtnerkek.Checked = true;
                }
                else
                {
                    rbbtnbayan.Checked = true;
                }
                cmbil.Text = dr["OGRİL"].ToString();
                cmbilce.Text = dr["OGRİLCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                rchadres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\ACER\\Desktop\\c# OTOMASYON\\OKULOTOMASYON\\OKULOTOMASYON" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
                lookUpEdit1.Text = dr["VELİANNEBABA"].ToString();
            }
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["OGRID"].ToString();
                txtad.Text = dr["OGRAD"].ToString();
                txtsoyad.Text = dr["OGRSOYAD"].ToString();
                msktc.Text = dr["OGRTC"].ToString();
                mskogrencino.Text = dr["OGRNO"].ToString();
                cmbsinif.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCİNSİYET"].ToString() == "E")
                {
                    rbbtnerkek.Checked = true;
                }
                else
                {
                    rbbtnbayan.Checked = true;
                }
                cmbil.Text = dr["OGRİL"].ToString();
                cmbilce.Text = dr["OGRİLCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                rchadres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\ACER\\Desktop\\c# OTOMASYON\\OKULOTOMASYON\\OKULOTOMASYON" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
                lookUpEdit1.Text = dr["VELİANNEBABA"].ToString();

            }
        }

        private void gridView3_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["OGRID"].ToString();
                txtad.Text = dr["OGRAD"].ToString();
                txtsoyad.Text = dr["OGRSOYAD"].ToString();
                msktc.Text = dr["OGRTC"].ToString();
                mskogrencino.Text = dr["OGRNO"].ToString();
                cmbsinif.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCİNSİYET"].ToString() == "E")
                {
                    rbbtnerkek.Checked = true;
                }
                else
                {
                    rbbtnbayan.Checked = true;
                }
                cmbil.Text = dr["OGRİL"].ToString();
                cmbilce.Text = dr["OGRİLCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                rchadres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\ACER\\Desktop\\c# OTOMASYON\\OKULOTOMASYON\\OKULOTOMASYON" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
                lookUpEdit1.Text = dr["VELİANNEBABA"].ToString();
            }
        }

        private void gridView4_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView4.GetDataRow(gridView4.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["OGRID"].ToString();
                txtad.Text = dr["OGRAD"].ToString();
                txtsoyad.Text = dr["OGRSOYAD"].ToString();
                msktc.Text = dr["OGRTC"].ToString();
                mskogrencino.Text = dr["OGRNO"].ToString();
                cmbsinif.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCİNSİYET"].ToString() == "E")
                {
                    rbbtnerkek.Checked = true;
                }
                else
                {
                    rbbtnbayan.Checked = true;
                }
                cmbil.Text = dr["OGRİL"].ToString();
                cmbilce.Text = dr["OGRİLCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                rchadres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\ACER\\Desktop\\c# OTOMASYON\\OKULOTOMASYON\\OKULOTOMASYON" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
                lookUpEdit1.Text = dr["VELİANNEBABA"].ToString();
            }
        }

        public string yeniyol;

        private void btnresimsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*png;*nef | Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu= dosya.FileName;
            yeniyol = "C:\\Users\\ACER\\Desktop\\c# OTOMASYON\\OKULOTOMASYON\\OKULOTOMASYON" + "\\resimler\\" + Guid.NewGuid().ToString() + ".jpg";
            File.Copy(dosyayolu, yeniyol);
            pictureEdit1.Image=Image.FromFile(yeniyol);

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update OGRENCİLER set OGRAD=@p1,OGRSOYAD=@p2,OGRNO=@p3,OGRSINIF=@p4,OGRDOGTAR=@p5,OGRCİNSİYET=@p6,OGRTC=@p7,OGRİL=@p8,OGRİLCE=@p9,OGRADRES=@p10,OGRFOTO=@p11,OGRVELIID=@p13 where OGRID=@p12", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskogrencino.Text);
            komut.Parameters.AddWithValue("@p4", cmbsinif.Text);
            komut.Parameters.AddWithValue("@p5", dateEdit1.Text);
            if (rbbtnerkek.Checked == true)
            {
                komut.Parameters.AddWithValue("@p6", cinsiyet = "E");
            }
            else
            {
                komut.Parameters.AddWithValue("@p6", cinsiyet = "B");
            }

            komut.Parameters.AddWithValue("@p7", msktc.Text);
            komut.Parameters.AddWithValue("@p8", cmbil.Text);
            komut.Parameters.AddWithValue("@p9", cmbilce.Text);
            komut.Parameters.AddWithValue("@p10", rchadres.Text);
            komut.Parameters.AddWithValue("@p11", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p12", txtID.Text);
            komut.Parameters.AddWithValue("@p13", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from  OGRENCİLER where OGRID=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Bilgileri Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            frmnufuscuzdani frm= new frmnufuscuzdani();

            if (dr != null) 
            {
                frm.ad = dr["OGRAD"].ToString();
                frm.soyad = dr["OGRSOYAD"].ToString() ;
                frm.tc = dr["OGRTC"].ToString();
                frm.cinsiyet = dr["OGRCİNSİYET"].ToString();
                frm.dogtarihi = dr["OGRDOGTAR"].ToString();
                frm.uzanti= "C:\\Users\\ACER\\Desktop\\c# OTOMASYON\\OKULOTOMASYON\\OKULOTOMASYON" + "\\resimler\\" + dr["OGRFOTO"].ToString();
            }
            frm.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            frmnufuscuzdani frm = new frmnufuscuzdani();

            if (dr != null)
            {
                frm.ad = dr["OGRAD"].ToString();
                frm.soyad = dr["OGRSOYAD"].ToString();
                frm.tc = dr["OGRTC"].ToString();
                frm.cinsiyet = dr["OGRCİNSİYET"].ToString();
                frm.dogtarihi = dr["OGRDOGTAR"].ToString();
                frm.uzanti = "C:\\Users\\ACER\\Desktop\\c# OTOMASYON\\OKULOTOMASYON\\OKULOTOMASYON" + "\\resimler\\" + dr["OGRFOTO"].ToString();
            }
            frm.Show();
        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            frmnufuscuzdani frm = new frmnufuscuzdani();

            if (dr != null)
            {
                frm.ad = dr["OGRAD"].ToString();
                frm.soyad = dr["OGRSOYAD"].ToString();
                frm.tc = dr["OGRTC"].ToString();
                frm.cinsiyet = dr["OGRCİNSİYET"].ToString();
                frm.dogtarihi = dr["OGRDOGTAR"].ToString();
                frm.uzanti = "C:\\Users\\ACER\\Desktop\\c# OTOMASYON\\OKULOTOMASYON\\OKULOTOMASYON" + "\\resimler\\" + dr["OGRFOTO"].ToString();
            }
            frm.Show();
        }

        private void gridView4_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView4.GetDataRow(gridView4.FocusedRowHandle);
            frmnufuscuzdani frm = new frmnufuscuzdani();

            if (dr != null)
            {
                frm.ad = dr["OGRAD"].ToString();
                frm.soyad = dr["OGRSOYAD"].ToString();
                frm.tc = dr["OGRTC"].ToString();
                frm.cinsiyet = dr["OGRCİNSİYET"].ToString();
                frm.dogtarihi = dr["OGRDOGTAR"].ToString();
                frm.uzanti = "C:\\Users\\ACER\\Desktop\\c# OTOMASYON\\OKULOTOMASYON\\OKULOTOMASYON" + "\\resimler\\" + dr["OGRFOTO"].ToString();
            }
            frm.Show();
        }
    }
}
