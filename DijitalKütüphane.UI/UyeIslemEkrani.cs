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
                if ((control is TextBox txt && string.IsNullOrWhiteSpace(txt.Text)) || control is MaskedTextBox mtxt && string.IsNullOrWhiteSpace(mtxt.Text) || control is DateTimePicker dtp && dtp.Value > DateTime.Now)
                {
                    MessageBox.Show("Üye bilgileri eksiksiz doldurulmalıdır!");
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
        }

        private void dgvUyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }
    }
}
