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
    public partial class MalzemeEkle : Form
    {
        public MalzemeEkle()
        {
            InitializeComponent();
        }
       

        private void btnEkleMalzeme_Click(object sender, EventArgs e)
        {
           Malzeme malzeme = new Malzeme();

            malzeme.Ad = txtMalzemeAd.Text;

            malzeme.Fiyat = (int)numMalzemeFiyat.Value;

            Form1.Malzemeler.Add(malzeme);

            Helper.Temizle(this.Controls);

        }
    }
}
