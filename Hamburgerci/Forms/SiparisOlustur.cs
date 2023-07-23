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
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
            YeniSiparisler = new List<Siparis>();
        }
        List<Siparis> YeniSiparisler;

        double toplam = 0;
        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            foreach (Menu menu in Form1.Menuler)
            {
                cbxHamburger.Items.Add(menu);
            }

            foreach (Malzeme melzeme in Form1.Malzemeler)
            {
                //checkedListBox1.Items.Add(melzeme.Ad);

                flowLayoutPanel1.Controls.Add(new CheckBox() { Text = melzeme.Ad, Tag = melzeme });
            }

            cbxHamburger.SelectedItem = 0;
            rbnKucuk.Checked = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;




        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            //siparis.Menu = (Menu)cbxHamburger.SelectedItem;

            siparis.Menu = (Menu)cbxHamburger.SelectedItem;

            foreach (CheckBox cbox in flowLayoutPanel1.Controls)
            {
                if (cbox.Checked)
                {
                    siparis.Malzemeler.Add((Malzeme)cbox.Tag);

                }
            }

            if (rbnOrta.Checked)
            {
                siparis.Boy = Boy.orta;
            }
            else if (rbnBuyuk.Checked)
            {
                siparis.Boy = Boy.büyük;
            }
            else
            {
                siparis.Boy = Boy.kucuk;
            }

            siparis.Adet = (int)numAdet.Value;

            toplam += siparis.ToplamFiyat;
            label3.Text = toplam.ToString("C2");

            YeniSiparisler.Add(siparis);
            listBox1.Items.Add(siparis);

            Helper.Temizle(this.Controls);
        }

        private void btnSiparisOnayla_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("siparişi onaylıyor musunu?", "onay", MessageBoxButtons.OKCancel);

            if(dialogResult == DialogResult.OK)
            {
                Form1.Siparisler.AddRange(YeniSiparisler);
                listBox1 .Items.Clear();
                YeniSiparisler.Clear();
            }

            Helper.Temizle(this.Controls);
        }
    }
}
