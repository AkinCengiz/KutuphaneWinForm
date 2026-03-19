namespace KutuphaneWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //YazarManager manager = new YazarManager();
            //Yazar yazar = new Yazar()
            //{
            //    Adi = "Erkan",
            //    Soyadi = "Günay",
            //    DogumYeri = "Güngören",
            //    DogumYili = new DateTime(2002, 01, 01)
            //};
            //manager.YazarEkle(yazar);
            //Yazar yazar2 = new Yazar()
            //{
            //    Adi = "Muhammed",
            //    Soyadi = "Saka",
            //    DogumYeri = "İstanbul",
            //    DogumYili = new DateTime(2002, 01, 01)
            //};
            //manager.YazarEkle(yazar2);
            //Yazar yazar3 = new Yazar()
            //{
            //    Adi = "Akın",
            //    Soyadi = "Cengiz",
            //    DogumYeri = "İstanbul",
            //    DogumYili = new DateTime(1981, 01, 01)
            //};
            //manager.YazarEkle(yazar3);
        }

        private void btnYazarIslemleri_Click(object sender, EventArgs e)
        {
            FrmYazarIslemleri form = new FrmYazarIslemleri();
            form.ShowDialog();
        }

        private void btnKitapIslemleri_Click(object sender, EventArgs e)
        {
            FrmKitapIslemleri kitapIslemleri = new FrmKitapIslemleri();
            kitapIslemleri.ShowDialog();
        }
    }
}
