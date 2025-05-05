using DijitalKütüphane.UI.Context;
using DijitalKütüphane.UI.Data;
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
    public partial class UyeIslemEkrani : Form
    {
        private readonly DijitalKutuphaneDbContext _db;
        public UyeIslemEkrani()
        {
            InitializeComponent();
            _db = new DijitalKutuphaneDbContext();
        }

        private void UyeListele()
        {
            dgvUyeler.DataSource = _db.Uyeler.ToList();
            dgvUyeler.ClearSelection();
        }


        private void UyeIslemEkrani_Load(object sender, EventArgs e)
        {
            UyeListele();
        }

        private bool ValidateInputs()
        {
            foreach (var control in grpUyeIslemleri.Controls)
            {
                if (control is TextBox txt)
                {
                    if (txt.Name == "txtFotograf")
                    {
                        continue;
                    }
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        MessageBox.Show("Üye bilgileri eksiksiz doldurulmalıdır!");
                        return false;
                    }
                }
                else if (control is MaskedTextBox mtxt && string.IsNullOrWhiteSpace(mtxt.Text))
                {
                    MessageBox.Show("Üye bilgileri eksiksiz doldurulmalıdır!");
                    return false;
                }
                else if (control is DateTimePicker dtp && dtp.Value > DateTime.Now)
                {
                    MessageBox.Show("Doğum tarihi gelecekte olamaz!");
                    return false;
                }
            }
            return true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) { return; }

            Uye uye = new Uye
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                KullaniciAdi = txtKullaniciAdi.Text,
                Sifre = txtSifre.Text,
                DogumTarihi = dtpDogumTarihi.Value,
                Telefon = mtxtTelefon.Text,
                Email = txtEmail.Text,
                Ulke = txtUlke.Text,
                Sehir = txtSehir.Text,
                Fotograf = txtFotograf.Text,
            };

            _db.Uyeler.Add(uye);
            _db.SaveChanges();

            MessageBox.Show("Üye başarıyla kaydedildi");
            UyeListele();
            UyeBilgileriTemizle();
        }

        private void UyeBilgileriTemizle()
        {
            foreach (var control in grpUyeIslemleri.Controls)
            {
                if (control is TextBox txt)
                {
                    txt.Text = string.Empty;

                }
                else if (control is MaskedTextBox mtxt)
                {
                    mtxt.Text = string.Empty;
                }
                else if (control is DateTimePicker dtp)
                {
                    dtp.Value = DateTime.Now;
                }
            }
            pbFotograf.Image = null;
        }

        Uye secilenUye;
        private void dgvUyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenUye = dgvUyeler.SelectedRows[0].DataBoundItem as Uye;

            txtAd.Text = secilenUye.Ad;
            txtSoyad.Text = secilenUye.Soyad;
            txtKullaniciAdi.Text = secilenUye.KullaniciAdi;
            txtSifre.Text = secilenUye.Sifre;
            dtpDogumTarihi.Value = secilenUye.DogumTarihi;
            mtxtTelefon.Text = secilenUye.Telefon;
            txtEmail.Text = secilenUye.Email;
            txtUlke.Text = secilenUye.Ulke;
            txtSehir.Text = secilenUye.Sehir;
            txtFotograf.Text = secilenUye.Fotograf;
            pbFotograf.Image = null;

            if (!string.IsNullOrWhiteSpace(secilenUye.Fotograf))
            {
                pbFotograf.Image = Image.FromFile(secilenUye.Fotograf);
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz üyeyi seçiniz!");
                return;
            }

            _db.Uyeler.Remove(secilenUye);
            _db.SaveChanges();

            secilenUye = null;

            MessageBox.Show("Üye başarıyla silindi");
            UyeListele();
            UyeBilgileriTemizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz üyeyi seçiniz!");
                return;
            }

            if (!ValidateInputs()) { return; }

            secilenUye.Ad = txtAd.Text;
            secilenUye.Soyad = txtSoyad.Text;
            secilenUye.KullaniciAdi = txtKullaniciAdi.Text;
            secilenUye.Sifre = txtSifre.Text;
            secilenUye.DogumTarihi = dtpDogumTarihi.Value;
            secilenUye.Telefon = mtxtTelefon.Text;
            secilenUye.Email = txtEmail.Text;
            secilenUye.Ulke = txtUlke.Text;
            secilenUye.Sehir = txtSehir.Text;
            secilenUye.Fotograf = txtFotograf.Text;

            _db.SaveChanges();

            secilenUye = null;

            MessageBox.Show("Üye başarıyla güncellendi");
            UyeListele();
            UyeBilgileriTemizle();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            UyeBilgileriTemizle();
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

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AdminMenuEkrani adminMenuEkrani = new AdminMenuEkrani();
            adminMenuEkrani.ShowDialog();
            this.Hide();
        }
    }
}
