using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijitalKütüphane.UI.Data
{
    public class Yazar
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public List<Kitap> Kitaplar { get; set; }
    }
}
