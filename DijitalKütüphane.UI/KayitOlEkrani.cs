using DijitalKütüphane.UI.Context;
using DijitalKütüphane.UI.Data;
using DijitalKütüphane.UI.Helper;
using Microsoft.EntityFrameworkCore.Query;
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
    public partial class KayitOlEkrani : Form
    {
        private readonly DijitalKutuphaneDbContext _db;
        public KayitOlEkrani()
        {
            InitializeComponent();
            _db = new DijitalKutuphaneDbContext();
        }

        private void KayitOlEkrani_Load(object sender, EventArgs e)
        {
            cbUyelikSuresi.Items.AddRange(new string[] { "3 ay", "6 ay", "9 ay", "1 yıl" });
            txtSifre.PasswordChar = '*';
        }

        private int SecilenUyelikSuresi()
        {
            int uyelikSuresi = 0;
            switch (cbUyelikSuresi.SelectedItem)
            {
                case "3 ay":
                    uyelikSuresi = 3;
                    break;
                case "6 ay":
                    uyelikSuresi = 6;
                    break;
                case "9 ay":
                    uyelikSuresi = 9;
                    break;
                case "1 yıl":
                    uyelikSuresi = 12;
                    break;

            }
            return uyelikSuresi;
        }



        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            //Bir tane hata olsa dahi true olup çıkar!
            if (!txtAd.ValidateTextBox("Ad alanı doldurulmalıdır!") ||
                !txtSoyad.ValidateTextBox("Soyad alanı doldurulmalıdır!") ||
                !txtKullaniciAdi.ValidateTextBox("Kullanıcı adı alanı doldurulmalıdır!") ||
                !txtSifre.ValidateTextBox("Şifre alanı doldurulmalıdır!") ||
                !mtxtTelefon.ValidateMaskedTextBox("Telefon alanı doldurulmalıdır!") ||
                !txtEmail.ValidateTextBox("Email alanı doldurulmalıdır!") ||
                !txtUlke.ValidateTextBox("Ülke alanı doldurulmalıdır!") ||
                !txtSehir.ValidateTextBox("Şehir alanı doldurulmalıdır!") ||
                !dtpDogumTarihi.ValidateDateTimePicker("Doğum tarihi ileri bir tarih olamaz!") ||
                !cbUyelikSuresi.ValidateComboBox("Lütfen bir üyelik süresi seçiniz!"))
            {
                return;
            }

            Uye uye = new Uye
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                KullaniciAdi = txtKullaniciAdi.Text,
                Sifre = Sifreleme.Sha256Hash(txtSifre.Text),
                DogumTarihi = dtpDogumTarihi.Value.Date,
                Telefon = mtxtTelefon.Text,
                Email = txtEmail.Text,
                Ulke = txtUlke.Text,
                Sehir = txtSehir.Text,
                UyelikSuresi = SecilenUyelikSuresi(),
                Fotograf = txtFotograf.Text,
            };

            _db.Uyeler.Add(uye);
            _db.SaveChanges();
            MessageBox.Show("Kayıt olma işleminiz başarıyla sonuçlandı");

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            GirisSayfasi girisSayfasi = new GirisSayfasi();
            girisSayfasi.Show();
            this.Hide();
        }

        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkSifreGoster.Checked)
            {
                txtSifre.PasswordChar = '*';
            }
            else
            {
                txtSifre.PasswordChar = '\0';
            }
        }

        string fotografDosyaYolu;
        private void btnFotografSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;,*.jpeg;,*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fotografDosyaYolu = openFileDialog.FileName;
                pbFotograf.Image = Image.FromFile(fotografDosyaYolu);
                txtFotograf.Text = fotografDosyaYolu;
            }
        }
    }
}
