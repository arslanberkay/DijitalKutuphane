using DijitalKütüphane.UI.Context;
using DijitalKütüphane.UI.Helper;
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
    public partial class GirisSayfasi : Form
    {
        private readonly DijitalKutuphaneDbContext _db;

        public GirisSayfasi()
        {
            InitializeComponent();
            _db = new DijitalKutuphaneDbContext();
        }

        private void GirisSayfasi_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            //TumSifreleriGuvenliYap();
            //AdminSifreleriniGuvenliYap();

        }

        private void TumSifreleriGuvenliYap()
        {
            foreach (var uye in _db.Uyeler)
            {
                if (uye.Sifre.Length != 64)
                {
                    uye.Sifre = Sifreleme.Sha256Hash(uye.Sifre);
                }
            }

            _db.SaveChanges();
        }

        private void AdminSifreleriniGuvenliYap()
        {
            foreach (var admin in _db.Adminler)
            {
                if (admin.Sifre.Length != 64)
                {
                    admin.Sifre = Sifreleme.Sha256Hash(admin.Sifre);
                }
            }

            _db.SaveChanges();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (_db.Adminler.Any(a => a.KullaniciAdi == txtKullaniciAdi.Text && a.Sifre == Sifreleme.Sha256Hash(txtSifre.Text)))
            {
                AdminMenuEkrani adminMenuEkrani = new AdminMenuEkrani();
                adminMenuEkrani.Show();
                this.Hide();
            }
            else if (_db.Uyeler.Any(u => u.KullaniciAdi == txtKullaniciAdi.Text && u.Sifre == Sifreleme.Sha256Hash(txtSifre.Text)))
            {
                UyeGorunumEkrani uyeGorunumEkrani = new UyeGorunumEkrani();
                uyeGorunumEkrani.Show();
                this.Hide();
            }
        }

        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSifreGoster.Checked == false)
            {
                txtSifre.PasswordChar = '*';
            }
            else
            {
                txtSifre.PasswordChar = '\0';
            }


        }

        private void lnkSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreYenilemeEkrani sifreYenilemeEkrani = new SifreYenilemeEkrani();
            sifreYenilemeEkrani.Show();
            this.Hide();
        }

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOlEkrani kayitOlEkrani = new KayitOlEkrani();
            kayitOlEkrani.Show();
            this.Hide();
        }
    }
}
