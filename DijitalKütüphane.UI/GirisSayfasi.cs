using DijitalKütüphane.UI.Context;
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
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (_db.Adminler.Any(a => a.KullaniciAdi == txtKullaniciAdi.Text && a.Sifre == txtSifre.Text))
            {
                AdminMenuEkrani adminMenuEkrani = new AdminMenuEkrani();
                adminMenuEkrani.Show();
                this.Hide();
            }
            else if (_db.Uyeler.Any(u => u.KullaniciAdi == txtKullaniciAdi.Text && u.Sifre == txtSifre.Text))
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
