using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci
{
    public partial class TumSiparisler : Form
    {
        public TumSiparisler()
        {
            InitializeComponent();
        }

        private void TumSiparisler_Load(object sender, EventArgs e)
        {
            double ciro = 0;
            int toplamSiparis = 0;
            double ekstraMalzemeGeliri = 0;
            int satilanUrunAdedi = 0;
            foreach(Siparis siparis in Form1.Siparisler)
            {
                listBox1.Items.Add(siparis);
                ciro += siparis.ToplamFiyat;

                ekstraMalzemeGeliri += siparis.EkstraMalzemeFiyatlari();

                satilanUrunAdedi += siparis.Malzemeler.Count;

                satilanUrunAdedi++;
            }

            toplamSiparis = Form1.Siparisler.Count;

            lblCiro.Text = ciro.ToString("C2");
            lblToplamSiparis.Text = toplamSiparis.ToString("C2");
            lblEkstraMalzemeGeliri.Text = ekstraMalzemeGeliri.ToString("C2");
            lblSatılanÜrünAdedi.Text = satilanUrunAdedi.ToString("C2");
        }
    }
}
