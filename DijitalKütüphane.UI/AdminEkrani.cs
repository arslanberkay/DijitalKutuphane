using DijitalKütüphane.UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DijitalKütüphane.UI
{
    public partial class AdminEkrani : Form
    {
        List<Kullanici> kullanicilar;
        public AdminEkrani(List<Kullanici> kullanicilarG)
        {
            InitializeComponent();
            kullanicilar = kullanicilarG;
        }

        List<Kitap> kitaplar = new List<Kitap>
        {
            new Kitap{Id=1, Isim="Meg - Derinlerdeki Dehşet", Yazar="Steve Alten", YayinEvi="Panama Yayıncılık", BasimYili=new DateTime(2018,08,1), Sayfa=440, Adet=100, Dil="İngilizce", Tur="Macera"},
            new Kitap{Id=2, Isim="Bir Yazılımcının Yol Haritası", Yazar="Murat Yücedağ", YayinEvi="Kodlab Yayıncılık", BasimYili=new DateTime(2020,05,1), Sayfa=320, Adet=50, Dil="Türkçe", Tur="Eğitim"},
            new Kitap{Id=3, Isim="Pi", Yazar="Yann Martel", YayinEvi="Yapı Kredi Yayınları", BasimYili=new DateTime(2001,06,1), Sayfa=480,   Adet=70, Dil="Türkçe", Tur="Macera"},
            new Kitap{Id=4, Isim="Robinson Crusoe", Yazar="Daniel Defoe", YayinEvi="İş Bankası Kültür Yayınları", BasimYili=new DateTime(1719,04,25), Sayfa=320, Adet=80, Dil="Türkçe", Tur="Macera"},
            new Kitap{Id=5, Isim="Sefiller", Yazar="Victor Hugo", YayinEvi="İş Bankası Kültür Yayınları", BasimYili=new DateTime(1862,01,1), Sayfa=1232, Adet=30, Dil="Türkçe", Tur="Roman"}

        };

        private void KitapTablosunuYenile()
        {
            dgvKitaplar.DataSource = null;
            dgvKitaplar.DataSource = kitaplar;
        }

        private void AdminEkrani_Load(object sender, EventArgs e)
        {
            UyeTablosunuYenile();
            KitapTablosunuYenile();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grpUyeIslemleri.Controls.Count; i++)
            {
                if ((grpUyeIslemleri.Controls[i] is TextBox txt && string.IsNullOrWhiteSpace(txt.Text)) || grpUyeIslemleri.Controls[i] is MaskedTextBox mtxt && string.IsNullOrWhiteSpace(mtxt.Text)) //TextBox veya MaskedTextBox boşsa
                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz!");
                    return;
                }
            }

            Kullanici yeniKullanici = new Kullanici();
            try
            {
                yeniKullanici.Id = Convert.ToInt32(txtId.Text);
                yeniKullanici.Isim = txtIsim.Text;
                yeniKullanici.Soyisim = txtSoyisim.Text;
                yeniKullanici.KullaniciAdi = txtKullaniciAdi.Text;
                yeniKullanici.Sifre = txtSifre.Text;
                yeniKullanici.OlusturulmaTarihi = Convert.ToDateTime(mtxtOlusturulmaTarihi.Text);
                yeniKullanici.Yetki = txtYetki.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz ve düzgün bir şekilde doldurunuz!");
            }

            kullanicilar.Add(yeniKullanici);

            UyeTablosunuYenile();


        }

        private void UyeTablosunuYenile()
        {
            dgvUyeler.DataSource = null;
            dgvUyeler.DataSource = kullanicilar;
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silme istediğiniz kullanıcıyı seçiniz!");
                return;
            }
            kullanicilar.RemoveAt(dgvUyeler.CurrentRow.Index);

            UyeTablosunuYenile();
        }

        private void btnUyeGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kullanıcıyı seçiniz!");
                return;
            }
            int index = dgvUyeler.CurrentRow.Index;
            Kullanici guncellenecekKullanici = kullanicilar[index];
            try
            {
                guncellenecekKullanici.Id = Convert.ToInt32(txtId.Text);
                guncellenecekKullanici.Isim = txtIsim.Text;
                guncellenecekKullanici.Soyisim = txtSoyisim.Text;
                guncellenecekKullanici.KullaniciAdi = txtKullaniciAdi.Text;
                guncellenecekKullanici.Sifre = txtSifre.Text;
                guncellenecekKullanici.OlusturulmaTarihi = Convert.ToDateTime(mtxtOlusturulmaTarihi.Text);
                guncellenecekKullanici.Yetki = txtYetki.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz ve düzgün bir şekilde doldurunuz!");
                return;
            }

            kullanicilar[index] = guncellenecekKullanici;

            UyeTablosunuYenile();

            MessageBox.Show("Üye güncelleme işlemi başarıyla sonuçlandı.");

        }

        private void btnUyeTemizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grpUyeIslemleri.Controls.Count; i++)
            {
                if (grpUyeIslemleri.Controls[i] is TextBox txt)
                {
                    txt.Text = string.Empty;
                }
                else if (grpUyeIslemleri.Controls[i] is MaskedTextBox mtxt)
                {
                    mtxt.Text = string.Empty;
                }
            }
        }

        private void dgvUyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliSatir = dgvUyeler.CurrentRow.Index;
            Kullanici seciliKullanici = kullanicilar[seciliSatir];

            txtId.Text = seciliKullanici.Id.ToString();
            txtIsim.Text = seciliKullanici.Isim;
            txtSoyisim.Text = seciliKullanici.Soyisim;
            txtKullaniciAdi.Text = seciliKullanici.KullaniciAdi;
            txtSifre.Text = seciliKullanici.Sifre;
            txtYetki.Text = seciliKullanici.Yetki;
            mtxtOlusturulmaTarihi.Text = seciliKullanici.OlusturulmaTarihi.ToString("dd-MM-yyyy HH:mm:ss");
        }
    }
}
