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
    public partial class UyeKitapOduncIslemEkrani : Form
    {
        private readonly DijitalKutuphaneDbContext _db;
        public UyeKitapOduncIslemEkrani()
        {
            InitializeComponent();
            _db = new DijitalKutuphaneDbContext();
        }

        private void UyeKitapOduncIslemEkrani_Load(object sender, EventArgs e)
        {
            TabloOlustur();
        }

        private void TabloOlustur()
        {
            lstvKitaplar.View = View.Details;
            lstvKitaplar.GridLines = true;
            lstvKitaplar.Columns.Add("Kitap Adı", 150);
            lstvKitaplar.Columns.Add("Açıklaması", 200);
            lstvKitaplar.Columns.Add("Sayfa Sayısı", 75);
            lstvKitaplar.Columns.Add("Kategori", 150);
            lstvKitaplar.Columns.Add("Dil", 100);
            lstvKitaplar.Columns.Add("Yayınevi", 150);
            lstvKitaplar.Columns.Add("Yazar", 150);
            lstvKitaplar.Columns.Add("Adet", 75);
            lstvKitaplar.Columns.Add("Basım Yılı", 100);
            lstvKitaplar.Columns.Add("Durum", 100);
        }

        private void TabloyaAktar(List<Kitap> kitaplar)
        {
            lstvKitaplar.Items.Clear();

            foreach (var kitap in kitaplar)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = kitap.KitapAdi;
                listViewItem.SubItems.Add(kitap.KitapAciklama);
                listViewItem.SubItems.Add(kitap.SayfaSayisi.ToString());
                listViewItem.SubItems.Add(kitap.Kategori.KategoriAdi);
                listViewItem.SubItems.Add(kitap.Dil);
                listViewItem.SubItems.Add(kitap.YayinEvi.YayineviAdi);
                listViewItem.SubItems.Add(kitap.Yazar.Ad + kitap.Yazar.Soyad);
                listViewItem.SubItems.Add(kitap.Adet.ToString());
                listViewItem.SubItems.Add(kitap.BasimYili);
                listViewItem.SubItems.Add(kitap.Durum);

                lstvKitaplar.Items.Add(listViewItem);
            }
        }

        private void btnTumKitaplar_Click(object sender, EventArgs e)
        {
            var tumKitaplar = _db.Kitaplar
                .Include(k=>k.Kategori)
                .Include(k=>k.Yazar)
                .Include(k=>k.YayinEvi)
                .ToList();
            TabloyaAktar(tumKitaplar);
        }
    }
}
