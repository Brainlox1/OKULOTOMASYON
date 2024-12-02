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
using DevExpress.Utils.DragDrop;
using DevExpress.XtraEditors.Popup;
using System.IO;
using DevExpress.XtraLayout.Resizing;

namespace OKULOTOMASYON
{
    public partial class FrmOgretmenler : Form
    {
        public FrmOgretmenler()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl=new Sqlbaglantisi();


        void listele() 
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da= new SqlDataAdapter("SELECT * FROM OGRETMENLER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void ilekle()
        {
            SqlCommand komut = new SqlCommand("Select * from Iller",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                cmbil.Properties.Items.Add(dr[1]);

            }
            bgl.baglanti().Close();
        }

        void bransgetir() 
        {
            SqlCommand komut = new SqlCommand("Select * from TBL_BRANSLAR", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbbrans.Properties.Items.Add(dr[1]);

            }
            bgl.baglanti().Close();
        }
        void temizle() 
        {
            txtID.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            msktc.Text = "";
            msktelefon.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            cmbbrans.Text = "";
            txtmail.Text = "";
            rchadres.Text = "";
            pcrresim.ImageLocation = "";
        }

        private void FrmOgretmenler_Load(object sender, EventArgs e)
        {
            listele();
            ilekle();
            bransgetir();
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilce.Properties.Items.Clear();
            cmbilce.Text = "";

            SqlCommand komut = new SqlCommand("select * from Ilceler where ILId=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbil.SelectedIndex+1);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cmbilce.Properties.Items.Add(dr[2]);    
            }
            bgl.baglanti().Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into OGRETMENLER (OGRTAD,OGRTSOYAD,OGRTTC,OGRTTEL,OGRTMAİL,OGRTİL,OGRTİLCE,OGRTADRES,OGRTBRANS,OGRTFOTO) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@P10)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktc.Text);
            komut.Parameters.AddWithValue("@p4", msktelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtmail.Text);
            komut.Parameters.AddWithValue("@p6", cmbil.Text);
            komut.Parameters.AddWithValue("@p7", cmbilce.Text);
            komut.Parameters.AddWithValue("@p8", rchadres.Text);
            komut.Parameters.AddWithValue("@p9", cmbbrans.Text);
            komut.Parameters.AddWithValue("@P10", Path.GetFileName(yeniyol));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["OGTRID"].ToString();
                txtad.Text = dr["OGRTAD"].ToString();
                txtsoyad.Text = dr["OGRTSOYAD"].ToString();
                msktc.Text = dr["OGRTTC"].ToString();
                msktelefon.Text = dr["OGRTTEL"].ToString();
                cmbil.Text = dr["OGRTİL"].ToString();
                cmbilce.Text= dr["OGRTİLCE"].ToString() ;
                cmbbrans.Text = dr["OGRTBRANS"].ToString();
                txtmail.Text = dr["OGRTMAİL"].ToString();
                rchadres.Text = dr["OGRTADRES"].ToString();
                yeniyol = "C:\\Users\\ACER\\Desktop\\c# OTOMASYON\\OKULOTOMASYON\\OKULOTOMASYON" + "\\resimler\\" + dr["OGRTFOTO"].ToString();
                pcrresim.ImageLocation = yeniyol;
            }
        }
        public string yeniyol;

        private void btnresimsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya= new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*png;*nef | Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\ACER\\Desktop\\c# OTOMASYON\\OKULOTOMASYON\\OKULOTOMASYON" + "\\resimler\\" + Guid.NewGuid().ToString() + ".jpg" ;
            File.Copy(dosyayolu,yeniyol);
            pcrresim.ImageLocation = yeniyol;
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update OGRETMENLER set OGRTAD=@p1,OGRTSOYAD=@p2,OGRTTC=@p3,OGRTTEL=@p4,OGRTMAİL=@p5,OGRTİL=@p6,OGRTİLCE=@p7,OGRTADRES=@p8,OGRTBRANS=@p9,OGRTFOTO=@p10 where OGTRID=@P11", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktc.Text);
            komut.Parameters.AddWithValue("@p4", msktelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtmail.Text);
            komut.Parameters.AddWithValue("@p6", cmbil.Text);
            komut.Parameters.AddWithValue("@p7", cmbilce.Text);
            komut.Parameters.AddWithValue("@p8", rchadres.Text);
            komut.Parameters.AddWithValue("@p9", cmbbrans.Text);
            komut.Parameters.AddWithValue("@P10", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p11", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from OGRETMENLER where OGTRID=@P1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti() .Close();
            MessageBox.Show("Personel Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pcrresim_Click(object sender, EventArgs e)
        {

        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbilce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void msktelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void msktc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void txtsoyad_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void txtad_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rchadres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmail_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void labelControl10_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
