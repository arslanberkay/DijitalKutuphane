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
    public partial class KategoriIslemEkrani : Form
    {
        private readonly DijitalKutuphaneDbContext _db;

        public KategoriIslemEkrani()
        {
            InitializeComponent();
            _db = new DijitalKutuphaneDbContext();
        }

        private void KategoriIslemEkrani_Load(object sender, EventArgs e)
        {
            KategoriListele();
        }

        private void KategoriListele()
        {
            dgvKategoriler.DataSource = _db.Kategoriler.ToList();
            dgvKategoriler.ClearSelection();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtAciklama.Text))
            {
                MessageBox.Show("Kategori bilgileri eksiksiz doldurulmalıdır!");
                return false;
            }
            return true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            Kategori kategori = new Kategori
            {
                KategoriAdi = txtAd.Text,
                Aciklamasi = txtAciklama.Text,
            };

            _db.Kategoriler.Add(kategori);
            _db.SaveChanges();

            MessageBox.Show("Kategori başarıyla eklenmiştir");
            KategoriListele();
            KategoriBilgileriTemizle();
        }

        private void KategoriBilgileriTemizle()
        {
            txtAd.Text = txtAciklama.Text = string.Empty;
        }

        Kategori secilenKategori;
        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenKategori = dgvKategoriler.SelectedRows[0].DataBoundItem as Kategori;

            txtAd.Text = secilenKategori.KategoriAdi;
            txtAciklama.Text = secilenKategori.Aciklamasi;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKategoriler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kategoriyi seçiniz!");
                return;
            }
            _db.Kategoriler.Remove(secilenKategori);
            _db.SaveChanges();

            secilenKategori = null;

            MessageBox.Show("Kategori başarıyla silinmiştir");
            KategoriListele();
            KategoriBilgileriTemizle();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvKategoriler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kategoriyi seçiniz!");
                return;
            }
            if (!ValidateInputs())
            {
                return;
            }

            secilenKategori.KategoriAdi = txtAd.Text;
            secilenKategori.Aciklamasi = txtAciklama.Text;

            _db.SaveChanges();
            secilenKategori = null;

            MessageBox.Show("Kategori başarıyla güncellenmiştir");
            KategoriListele();
            KategoriBilgileriTemizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            KategoriBilgileriTemizle();
            dgvKategoriler.ClearSelection();
        }
    }
}
