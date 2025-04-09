using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijitalKütüphane.UI.Models
{
    public class Kitap
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Yazar { get; set; }
        public string Dil { get; set; }
        public string YayinEvi { get; set; }
        public string Tur { get; set; }
        public int Adet { get; set; }
        public int Sayfa { get; set; }
        public DateTime BasimYili { get; set; }
    }
}
