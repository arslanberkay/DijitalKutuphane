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
        public KayitOlEkrani()
        {
            InitializeComponent();
        }

        private void KayitOlEkrani_Load(object sender, EventArgs e)
        {
            cbUyelikSuresi.Items.AddRange(new string[] { "3 ay", "6 ay", "9 ay", "1 yıl" });
        }





        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            //Bir tane hata olsa dahi true olup çıkar!
            if (!txtAd.ValidateTextBox("Ad alanı doldurulmalıdır!") || 
                !txtSoyad.ValidateTextBox("Soyad alanı doldurulmalıdır!") ||
                !txtKullaniciAdi.ValidateTextBox("Kullanıcı adı alanı doldurulmalıdır!") || 
                !txtSifre.ValidateTextBox("Şifre alanı doldurulmalıdır!") || 
                !txtEmail.ValidateTextBox("Email alanı doldurulmalıdır!") || 
                !txtUlke.ValidateTextBox("Ülke alanı doldurulmalıdır!") || 
                !txtSehir.ValidateTextBox("Şehir alanı doldurulmalıdır!") || 
                !mtxtTelefon.ValidateMaskedTextBox("Telefon alanı doldurulmalıdır!") || 
                !dtpDogumTarihi.ValidateDateTimePicker("Doğum tarihi ileri bir tarih olamaz!") ||
                !cbUyelikSuresi.ValidateComboBox("Lütfen bir üyelik süresi seçiniz!"))
            {
                return;
            }



        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            GirisSayfasi girisSayfasi = new GirisSayfasi();
            girisSayfasi.Show();
            this.Hide();
        }


    }
}
