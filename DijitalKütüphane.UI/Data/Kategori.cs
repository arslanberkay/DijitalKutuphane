using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijitalKütüphane.UI.Data
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public string Aciklamasi { get; set; }

        public List<Kitap> Kitaplar { get; set; }
    }
}
