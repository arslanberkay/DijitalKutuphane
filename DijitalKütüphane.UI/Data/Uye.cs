using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijitalKütüphane.UI.Data
{
    public class Uye
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public DateTime UyelikTarihi => DateTime.Now; //Otomatik olarak kayıt olduğu tarih atansın
        public int UyelikSuresi { get; set; }
        public DateTime UyelikBitisTarihi => UyelikTarihi.AddMonths(UyelikSuresi); //Üyelik süresini 3 6 9 12 aylık seçsin. Üyelik bitişi otomatik atasın
        public string Fotograf { get; set; }

    }
}
