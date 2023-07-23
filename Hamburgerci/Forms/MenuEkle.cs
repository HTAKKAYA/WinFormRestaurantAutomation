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
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
        }

        

        private void btnMenuEkle_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            menu.Ad = txtMenuAd.Text;
            menu.Fiyat = (int)numMenuFiyat.Value;
            Form1.Menuler.Add(menu);

            Helper.Temizle(this.Controls);
        }

        
    }
}
