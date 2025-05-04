using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijitalKütüphane.UI.Data
{
    public class Yayinevi
    {
        public int Id { get; set; }
        public string YayineviAdi { get; set; }
        public string Telefon { get; set; }
        public string Sehir { get; set; }
        public string Ulke { get; set; }
        public string Adres { get; set; }

        public List<Kitap> Kitaplar { get; set; }
    }
}
