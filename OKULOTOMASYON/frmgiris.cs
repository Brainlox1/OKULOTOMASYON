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

namespace OKULOTOMASYON
{
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl=new Sqlbaglantisi();

        private void btnyonetici_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("select OGRTTC,OGRTSİFRE from AYARLAR inner join OGRETMENLER  on AYARLAR.AYARLARID=OGRETMENLER.OGTRID where OGRTTC=@p1 and OGRTSİFRE=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            {
                FRMANAMODUL frm1 = new FRMANAMODUL();
                frm1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Veya Şifre");
                msktc.Text ="";
                txtsifre.Text = "";
            }
            bgl.baglanti().Close();
        }

        private void btnogretmen_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select OGRTTC,OGRTSİFRE from AYARLAR inner join OGRETMENLER  on AYARLAR.AYARLARID=OGRETMENLER.OGTRID where OGRTTC=@p1 and OGRTSİFRE=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FRMANAMODUL frm1 = new FRMANAMODUL();
                frm1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Veya Şifre");
                msktc.Text = "";
                txtsifre.Text = "";
            }
            bgl.baglanti().Close();
        }
    }
}
