using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijitalKütüphane.UI.Data
{
    public class Kitap
    {
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public string KitapAciklama { get; set; }
        public int SayfaSayisi { get; set; }
        public string Dil { get; set; }
        public int Adet { get; set; }
        public string Durum { get; set; }
        public DateTime BasimYili { get; set; }
        public DateTime EklenmeTarihi => DateTime.Now;
        public int RafNumarasi { get; set; }

        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }

        public int YazarId { get; set; }
        public Yazar Yazar { get; set; }

        public int YayineviId { get; set; }
        public Yayinevi YayinEvi { get; set; }
    }
}
