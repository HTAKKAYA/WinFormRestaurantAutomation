namespace Hamburgerci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Siparisler = new List<Siparis>();
        }



        public static List<Menu> Menuler = new List<Menu>()
        {
            new Menu{Ad="Whopper",Fiyat=120},
            new Menu{Ad="Big Chicken",Fiyat=90}
        };

        public static List<Malzeme> Malzemeler = new List<Malzeme>()
        {
            new Malzeme{Ad="Ket�ap",Fiyat=5},
            new Malzeme{Ad="Mayonez",Fiyat=10}
        };
        public static List<Siparis> Siparisler;

        private void Form1_Load(object sender, EventArgs e)
        {
            SiparisOlusturmaEkraniGetir();

        }

        private void SiparisOlusturmaEkraniGetir()
        {
            Formlar�Kapat();

            SiparisOlustur siparisOlustur = new();

            siparisOlustur.MdiParent = this;
            siparisOlustur.Dock = DockStyle.Fill;
            this.Width = siparisOlustur.Width + 50;
            this.Height = siparisOlustur.Height + 90;
            siparisOlustur.Show();
        }

        private void Formlar�Kapat()
        {
            Form[] forms = this.MdiChildren;
            foreach (Form form in forms)
            {
                form.Close();
            }
        }
       
        private void sipari�Olu�turToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisOlusturmaEkraniGetir();
        }

        private void t�mSipari�lerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar�Kapat();

            TumSiparisler tumSiparisler = new();

            tumSiparisler.MdiParent = this;
            tumSiparisler.Dock = DockStyle.Fill;
            this.Width = tumSiparisler.Width + 50;
            this.Height = tumSiparisler.Height + 90;
            tumSiparisler.Show();

        }

        private void menuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar�Kapat();

            MenuEkle menuEkle = new();

            menuEkle.MdiParent = this;
            menuEkle.Dock = DockStyle.Fill;
            this.Width = menuEkle.Width + 50;
            this.Height = menuEkle.Height + 90;
            menuEkle.Show();
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar�Kapat();

            MalzemeEkle malzemeEkle = new();

            malzemeEkle.MdiParent = this;
            malzemeEkle.Dock = DockStyle.Fill;
            this.Width = malzemeEkle.Width + 50;
            this.Height = malzemeEkle.Height + 90;
            malzemeEkle.Show();
        }
    }
}