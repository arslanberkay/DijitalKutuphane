namespace DijitalKütüphane.UI
{
    public partial class KullaniciGirisEkrani : Form
    {
        public KullaniciGirisEkrani()
        {
            InitializeComponent();
        }

        List<Kullanici> kullanicilar = new List<Kullanici>
        {
            new Kullanici{Id=1,Isim = "Berkay", Soyisim = "Arslan", KullaniciAdi="arslanberkay", OlusturulmaTarihi = new DateTime(2024,5,30), Sifre = "0618", Yetki = "admin"},
            new Kullanici {Id = 2, Isim = "Doğa", Soyisim = "Yıldız", KullaniciAdi = "dogayildizz",OlusturulmaTarihi = new DateTime(2024,9,1), Sifre="0658", Yetki="admin"},
            new Kullanici {Id = 3 , Isim = "Ekrem", Soyisim = "Hosanlı", KullaniciAdi="ekremcan", OlusturulmaTarihi = DateTime.Now, Sifre = "0660",Yetki ="üye"},
            new Kullanici {Id = 4 , Isim = "Talha", Soyisim = "Din", KullaniciAdi="talhacan", OlusturulmaTarihi = DateTime.Now, Sifre = "6060",Yetki ="üye"}
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Kullanıcı Adı alanı doldurulmalıdır!");
                Temizle();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Şifre alanı doldurulmalıdır!");
                return;
            }

            foreach (var kullanici in kullanicilar)
            {
                if (kullanici.KullaniciAdi == txtKullaniciAdi.Text && kullanici.Sifre == txtSifre.Text && kullanici.Yetki == "admin")
                {
                    AdminEkrani form2 = new AdminEkrani(kullanicilar);
                    form2.Show();
                    this.Hide();
                    return;
                }
                if (kullanici.KullaniciAdi == txtKullaniciAdi.Text && kullanici.Sifre == txtSifre.Text && kullanici.Yetki == "üye")
                {
                    UyeEkrani form3 = new UyeEkrani();
                    form3.Show();
                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("Geçersiz kullanıcı adı veya şifre!");
            Temizle();
        }

        private void Temizle()
        {
            for (int i = 0; i < grpKullaniciGirisi.Controls.Count; i++)
            {
                if (grpKullaniciGirisi.Controls[i] is TextBox txt)
                {
                    txt.Text = string.Empty;
                }
            }
        }


    }
}
