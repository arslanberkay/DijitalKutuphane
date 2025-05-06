using DijitalKütüphane.UI.Context;
using DijitalKütüphane.UI.Data;
using Microsoft.EntityFrameworkCore;
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
    public partial class KitapIslemEkrani : Form
    {
        private readonly DijitalKutuphaneDbContext _db;
        public KitapIslemEkrani()
        {
            InitializeComponent();
            _db = new DijitalKutuphaneDbContext();
        }

        private void KitapIslemEkrani_Load(object sender, EventArgs e)
        {
            KitapListele();
            KategoriGetir();
            YayineviGetir();
            YazarGetir();
            cbDurum.Items.AddRange(new string[] { "Rafta", "Ödünçte" });
            cbDil.Items.AddRange(new string[] { "Türkçe", "İngilizce", "Fransızca", "Almanca" });
        }

        private void KategoriGetir()
        {
            cbKategori.DataSource = _db.Kategoriler.ToList();
            cbKategori.DisplayMember = "KategoriAdi";
            cbKategori.ValueMember = "Id";
            cbKategori.SelectedIndex = -1;
        }

        private void YayineviGetir()
        {
            cbYayinevi.DataSource = _db.YayinEvleri.ToList();
            cbYayinevi.DisplayMember = "YayineviAdi";
            cbYayinevi.ValueMember = "Id";
            cbYayinevi.SelectedIndex = -1;
        }

        private void YazarGetir()
        {
            cbYazar.DataSource = _db.Yazarlar.Select(y => new
            {
                y.Id,
                AdSoyad = y.Ad + " " + y.Soyad,
                y.Email

            })
                .ToList();
            cbYazar.DisplayMember = "AdSoyad";
            cbYazar.ValueMember = "Id";
            cbYazar.SelectedIndex = -1;
        }

        private void KitapListele()
        {
            var kitaplar = _db.Kitaplar
                .Include(k=>k.Kategori) //Include içinde sadece Navigation proplar kullanılır.
                .Include(k=>k.YayinEvi)
                .Include(k=>k.Yazar)
                .Select(k => new
                {
                    k.Id,
                    k.KitapAdi,
                    k.KitapAciklama,
                    k.SayfaSayisi,
                    k.Dil,
                    k.Kategori.KategoriAdi,
                    Yazar = k.Yazar.Ad + " " + k.Yazar.Soyad,
                    k.Adet,
                    k.YayinEvi.YayineviAdi,
                    k.BasimYili,
                    k.Durum,
                    k.RafNumarasi
                })
                .ToList();
            dgvKitaplar.DataSource = kitaplar;
        }

        private bool ValidateInputs()
        {
            foreach (var control in grpKitapIslemleri.Controls)
            {
                if ((control is TextBox txt && string.IsNullOrWhiteSpace(txt.Text)) || (control is ComboBox cb && cb.SelectedItem == null) || control is MaskedTextBox mtxt && string.IsNullOrWhiteSpace(mtxt.Text) || control is NumericUpDown nud && nud.Value == 0)
                {
                    MessageBox.Show("Kitap bilgileri eksiksiz doldurulmalıdır!");
                    return false;
                }
            }

            return true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) { return; }

            Kitap kitap = new Kitap
            {
                KitapAdi = txtAd.Text,
                KitapAciklama = txtAciklama.Text,
                SayfaSayisi = Convert.ToInt32(nudSayfaSayisi.Text),
                Dil = cbDil.SelectedItem.ToString(),
                KategoriId = (int)cbKategori.SelectedValue,
                YayineviId = (int)cbYayinevi.SelectedValue,
                YazarId = (int)cbYazar.SelectedValue,
                Adet = Convert.ToInt32(nudAdet.Text),
                BasimYili = mtxtBasimYili.Text,
                Durum = cbDurum.SelectedItem.ToString(),
                RafNumarasi = Convert.ToInt32(mtxtRafNumarasi.Text)
            };

            _db.Kitaplar.Add(kitap);
            _db.SaveChanges();

            MessageBox.Show("Kitap başarıyla eklendi");
            KitapListele();
            KitapIslemleriTemizle();

        }

        private void KitapIslemleriTemizle()
        {
            foreach (var control in grpKitapIslemleri.Controls)
            {
                if (control is TextBox txt)
                {
                    txt.Text = string.Empty;
                }
                else if (control is MaskedTextBox mtxt)
                {
                    mtxt.Text = string.Empty;
                }
                else if (control is ComboBox cb)
                {
                    cb.SelectedItem = null;
                }
                else if (control is NumericUpDown nud)
                {
                    nud.Value = 0;
                }
            }
        }
    }
}
