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
    public partial class frmnufuscuzdani : Form
    {
        public frmnufuscuzdani()
        {
            InitializeComponent();
        }
        public string ad, soyad, tc, cinsiyet, dogtarihi, uzanti;

        private void frmnufuscuzdani_Load(object sender, EventArgs e)
        {
            lblad.Text = ad;
            lblsoyad.Text = soyad;
            lblcinsiyet.Text = cinsiyet;
            lbldogtar.Text = dogtarihi;
            lbltc.Text = tc;
            pictureEdit1.Image = Image.FromFile(uzanti);
        }
        
    }
}
