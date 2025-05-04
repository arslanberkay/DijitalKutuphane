using DijitalKütüphane.UI.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijitalKütüphane.UI.Context
{
    public class DijitalKutuphaneDbContext : DbContext
    {
        public DbSet<Admin> Adminler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Yayinevi> YayinEvleri { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-C3QHSI5J\\SQLEXPRESS;database=DijitalKutuphaneDb;trusted_connection=true;trustservercertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>().HasData
                (
                new Kategori { Id = 1, KategoriAdi = "Klasik", Aciklamasi = "Dünya edebiyatında önemli yer edinmiş eserler" },
                new Kategori { Id = 2, KategoriAdi = "Kişisel Gelişim", Aciklamasi = "Bireysel gelişim ve motivasyon kitapları" },
                new Kategori { Id = 3, KategoriAdi = "Macera", Aciklamasi = "Sürükleyici ve aksiyon dolu hikayeler" },
                    new Kategori { Id = 4, KategoriAdi = "Fantastik", Aciklamasi = "Hayal gücüne dayalı kurgu evrenlerde geçen hikayeler" },
                new Kategori { Id = 5, KategoriAdi = "Yazılım", Aciklamasi = "Programlama, algoritmalar ve yazılım geliştirme konuları" },
                new Kategori { Id = 6, KategoriAdi = "Psikoloji", Aciklamasi = "İnsan davranışı ve zihin yapısını inceleyen kitaplar" },
                new Kategori { Id = 7, KategoriAdi = "Bilim Kurgu", Aciklamasi = "Bilimsel temelli hayal gücüyle zenginleştirilmiş eserler" },
                new Kategori { Id = 8, KategoriAdi = "Tarih", Aciklamasi = "Geçmiş olayları anlatan tarihsel içerikler" },
                new Kategori { Id = 9, KategoriAdi = "Biyografi", Aciklamasi = "Gerçek kişilerin yaşam öykülerini anlatan eserler" }
                );

        }
    }
}
