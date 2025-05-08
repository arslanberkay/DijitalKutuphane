using DijitalKütüphane.UI.Context;
using DijitalKütüphane.UI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DijitalKütüphane.UI
{
    public partial class SifreYenilemeEkrani : Form
    {
        private readonly DijitalKutuphaneDbContext _db;
        public SifreYenilemeEkrani()
        {
            InitializeComponent();
            _db = new DijitalKutuphaneDbContext();
        }

        private void SifreYenilemeEkrani_Load(object sender, EventArgs e)
        {
            SifirlamaKodAlaniGorunurluk(false);
            YeniSifreAlaniGorunurluk(false);
            txtYeniSifre.PasswordChar = '*';
            txtYeniSifreTekrar.PasswordChar = '*';
        }
        Uye sifreYenilemeYapanUye;
        Random rnd = new Random();
        int sifirlamaKodu;
        private void btnSifirlamaKoduGonder_Click(object sender, EventArgs e)
        {
            if (_db.Uyeler.Any(u => u.Email == txtEmail.Text))  //Email unıqe mi kontrol et?
            {
                sifirlamaKodu = rnd.Next(1000, 9999);
                MailGonder(sifirlamaKodu);
                EmailGondermeAlaniGorunurluk(false);
                SifirlamaKodAlaniGorunurluk(true);
                sifreYenilemeYapanUye = _db.Uyeler.Where(u => u.Email == txtEmail.Text).FirstOrDefault();
                txtKullaniciAdi.Text = sifreYenilemeYapanUye.KullaniciAdi;
            }
            else
            {
                MessageBox.Show("Girilen e-posta adresine kayıtlı bir üye bulunamadı!");
            }
        }

        private void MailGonder(int kod)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("berkayarslanyzl@gmail.com");
                mail.To.Add(txtEmail.Text);
                mail.Subject = "Şifre Yenileme";
                mail.Body = $"Şifre sıfırlama talebi için 4 haneli kodunuz : {kod}";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("berkayarslanyzl@gmail.com", "dvkcizljotgfubov");
                smtp.EnableSsl = true;
                smtp.Send(mail);

                MessageBox.Show("Sıfırlama kodu mailinize gönderildi");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail gönderme sırasında hata oluştu. Lütfen daha sonra tekrar deneyin");
            }
        }

        private void EmailGondermeAlaniGorunurluk(bool gorunurluk)
        {
            grpEpostaGondermeAlani.Visible = gorunurluk;
        }

        private void SifirlamaKodAlaniGorunurluk(bool gorunurluk)
        {
            grpSifirlamaKoduGirmeAlani.Visible = gorunurluk;
        }

        private void YeniSifreAlaniGorunurluk(bool gorunurluk)
        {
            grpSifreYenilemeAlani.Visible = gorunurluk;
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (mtxtSifirlamaKodu.Text == sifirlamaKodu.ToString())
            {
                SifirlamaKodAlaniGorunurluk(false);
                YeniSifreAlaniGorunurluk(true);
            }
            else
            {
                MessageBox.Show("Geçersiz sıfırlama kodu!");
                return;
            }
        }

        private void btnYeniSifreKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYeniSifre.Text))
            {
                MessageBox.Show("Lütfen yeni şifrenizi giriniz!");
                return;
            }
            if (txtYeniSifre.Text == txtYeniSifreTekrar.Text)
            {
                sifreYenilemeYapanUye.Sifre = txtYeniSifre.Text;
                _db.SaveChanges();
                MessageBox.Show("Yeni şifreniz başarıyla kaydedildi");
            }
            else
            {
                MessageBox.Show("Eksik şifre");
            }
        }

        private void chkYeniSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYeniSifreGoster.Checked == false)
            {
                txtYeniSifre.PasswordChar = '*';
            }
            else
            {
                txtYeniSifre.PasswordChar = '\0';
            }
        }

        private void chkYeniSifreTekrarGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYeniSifreTekrarGoster.Checked == false)
            {
                txtYeniSifreTekrar.PasswordChar = '*';
            }
            else
            {
                txtYeniSifreTekrar.PasswordChar = '\0';
            }
        }
    }
}
