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
    public partial class YazarIslemEkrani : Form
    {
        private readonly DijitalKutuphaneDbContext _db;
        public YazarIslemEkrani()
        {
            InitializeComponent();
            _db = new DijitalKutuphaneDbContext();
        }

        private void YazarIslemEkrani_Load(object sender, EventArgs e)
        {
            YazarListele();
        }

        private void YazarListele()
        {
            dgvYazarlar.DataSource = _db.Yazarlar.ToList();
            dgvYazarlar.ClearSelection();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Yazar bilgileri eksiksiz doldurulmalıdır!");
                return false;
            }
            return true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) { return; }

            Yazar yazar = new Yazar
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Email = txtEmail.Text
            };

            _db.Yazarlar.Add(yazar);
            _db.SaveChanges();

            MessageBox.Show("Yazar başarıyla eklendi");
            YazarListele();
            YazarBilgileriTemizle();
        }

        Yazar secilenYazar;
        private void dgvYazarlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvYazarlar.SelectedRows.Count == 0) { return; }

            secilenYazar = dgvYazarlar.SelectedRows[0].DataBoundItem as Yazar;

            txtAd.Text = secilenYazar.Ad;
            txtSoyad.Text = secilenYazar.Soyad;
            txtEmail.Text = secilenYazar.Email;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvYazarlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz yazarı seçiniz!");
                return;
            }

            _db.Yazarlar.Remove(secilenYazar);
            _db.SaveChanges();

            secilenYazar = null;

            MessageBox.Show("Yazar başarıyla silindi");
            YazarListele();
            YazarBilgileriTemizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvYazarlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz yazarı seçiniz!");
                return;
            }

            secilenYazar.Ad = txtAd.Text;
            secilenYazar.Soyad = txtSoyad.Text;
            secilenYazar.Email = txtEmail.Text;


            _db.SaveChanges();
            secilenYazar = null;

            MessageBox.Show("Yazar başarıyla güncellendi");
            YazarListele();
            YazarBilgileriTemizle();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            YazarBilgileriTemizle();
        }

        private void YazarBilgileriTemizle()
        {
            foreach (var control in grpYazarIslemleri.Controls)
            {
                if (control is TextBox txt)
                {
                    txt.Text = string.Empty;
                }
            }
            dgvYazarlar.ClearSelection();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AdminMenuEkrani adminMenuEkrani = new AdminMenuEkrani();
            adminMenuEkrani.ShowDialog();
            this.Hide();
        }
    }
}
