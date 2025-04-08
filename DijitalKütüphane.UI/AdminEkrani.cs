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

        private void AdminEkrani_Load(object sender, EventArgs e)
        {
            UyeTablosunuYenile();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {

            Kullanici yeniKullanici = new Kullanici();
            yeniKullanici.Id = Convert.ToInt32(txtId.Text);
            yeniKullanici.Isim = txtIsim.Text;
            yeniKullanici.Soyisim = txtSoyisim.Text;
            yeniKullanici.KullaniciAdi = txtKullaniciAdi.Text;
            yeniKullanici.Sifre = txtSifre.Text;
            yeniKullanici.OlusturulmaTarihi = Convert.ToDateTime(mtxtOlusturulmaTarihi.Text);
            yeniKullanici.Yetki = txtYetki.Text;

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
            kullanicilar.RemoveAt(dgvUyeler.CurrentRow.Index);

            UyeTablosunuYenile();
        }

        private void btnUyeGuncelle_Click(object sender, EventArgs e)
        {
            int index = dgvUyeler.CurrentRow.Index;
            Kullanici guncellenecekKullanici = kullanicilar[index];
            guncellenecekKullanici.Id = Convert.ToInt32(txtId.Text);
            guncellenecekKullanici.Isim = txtIsim.Text;
            guncellenecekKullanici.Soyisim = txtSoyisim.Text;
            guncellenecekKullanici.KullaniciAdi = txtKullaniciAdi.Text;
            guncellenecekKullanici.Sifre = txtSifre.Text;
            guncellenecekKullanici.OlusturulmaTarihi = Convert.ToDateTime(mtxtOlusturulmaTarihi.Text);
            guncellenecekKullanici.Yetki = txtYetki.Text;

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
            mtxtOlusturulmaTarihi.Text = seciliKullanici.OlusturulmaTarihi.ToString("dd-MM-yyyy HH:mm:ss" );
        }
    }
}
