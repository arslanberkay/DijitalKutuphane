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
    public partial class AdminEkrani : Form
    {
        List<Kullanici> kullanicilar;
        public AdminEkrani(List<Kullanici> kullanicilarG)
        {
            InitializeComponent();
            kullanicilar = kullanicilarG;
        }

        private void AdminEkrani_Load(object sender, EventArgs e)
        {
            UyeTablosunuYenile();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            Kullanici yeniKullanici = new Kullanici();
            yeniKullanici.Id = Convert.ToInt32(txtId.Text);
            yeniKullanici.Isim = txtIsim.Text;
            yeniKullanici.Soyisim = txtSoyisim.Text;
            yeniKullanici.KullaniciAdi = txtKullaniciAdi.Text;
            yeniKullanici.Sifre = txtSifre.Text;
            yeniKullanici.OlusturulmaTarihi = Convert.ToDateTime(mtxtOlusturulmaTarihi.Text);
            yeniKullanici.Yetki = txtYetki.Text;

            kullanicilar.Add(yeniKullanici);

            UyeTablosunuYenile();


        }

        private void UyeTablosunuYenile()
        {
            dgvUyeler.DataSource = null;
            dgvUyeler.DataSource = kullanicilar;
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            kullanicilar.RemoveAt(dgvUyeler.CurrentRow.Index);

            UyeTablosunuYenile();
        }
    }
}
