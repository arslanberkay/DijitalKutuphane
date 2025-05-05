using DijitalKütüphane.UI.Context;
using DijitalKütüphane.UI.Data;
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
    public partial class YayineviIslemEkrani : Form
    {
        private readonly DijitalKutuphaneDbContext _db;
        public YayineviIslemEkrani()
        {
            InitializeComponent();
            _db = new DijitalKutuphaneDbContext();
        }

        private void YayineviIslemEkrani_Load(object sender, EventArgs e)
        {
            YayineviListele();
        }

        private void YayineviListele()
        {
            dgvYayinEvleri.DataSource = _db.YayinEvleri.ToList();
            dgvYayinEvleri.ClearSelection();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtYayineviAdi.Text) || string.IsNullOrWhiteSpace(mtxtTelefon.Text) || string.IsNullOrWhiteSpace(txtSehir.Text) || string.IsNullOrWhiteSpace(txtUlke.Text) || string.IsNullOrWhiteSpace(txtAdres.Text))
            {
                MessageBox.Show("Lütfen yayınevi bilgilerini eksiksiz doldurunuz!");
                return false;
            }
            return true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            Yayinevi yayinevi = new Yayinevi
            {
                YayineviAdi = txtYayineviAdi.Text,
                Telefon = mtxtTelefon.Text,
                Sehir = txtSehir.Text,
                Ulke = txtUlke.Text,
                Adres = txtAdres.Text,
            };

            _db.YayinEvleri.Add(yayinevi);
            _db.SaveChanges();

            MessageBox.Show("Yayınevi başarıyla kaydedildi");
            YayineviListele();
            YayineviBilgileriTemizle();
        }

        private void YayineviBilgileriTemizle()
        {
            txtYayineviAdi.Text = mtxtTelefon.Text = txtSehir.Text = txtUlke.Text = txtAdres.Text = string.Empty;
            dgvYayinEvleri.ClearSelection();
        }

        private Yayinevi SeciliYayinevi()
        {
            int secilenYayineviId = (int)dgvYayinEvleri.SelectedRows[0].Cells["Id"].Value;
            var secilenYayinevi = _db.YayinEvleri.Find(secilenYayineviId);
            return secilenYayinevi;
        }

        Yayinevi secilenYayinEvi;
        private void dgvYayinEvleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenYayinEvi = SeciliYayinevi();

            txtYayineviAdi.Text = secilenYayinEvi.YayineviAdi;
            mtxtTelefon.Text = secilenYayinEvi.Telefon;
            txtSehir.Text = secilenYayinEvi.Sehir;
            txtUlke.Text = secilenYayinEvi.Ulke;
            txtAdres.Text = secilenYayinEvi.Adres;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvYayinEvleri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz yayınevini seçiniz!");
                return;
            }

            _db.YayinEvleri.Remove(secilenYayinEvi);
            _db.SaveChanges();

            secilenYayinEvi = null;

            MessageBox.Show("Yayınevi başarıyla silindi");
            YayineviListele();
            YayineviBilgileriTemizle();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvYayinEvleri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz yayınevini seçiniz!");
                return;
            }

            secilenYayinEvi.YayineviAdi = txtYayineviAdi.Text;
            secilenYayinEvi.Telefon = mtxtTelefon.Text;
            secilenYayinEvi.Sehir = txtSehir.Text;
            secilenYayinEvi.Ulke = txtUlke.Text;
            secilenYayinEvi.Adres = txtAdres.Text;

            _db.SaveChanges();

            secilenYayinEvi = null;

            MessageBox.Show("Yayınevi başarıyla güncellendi");
            YayineviListele();
            YayineviBilgileriTemizle();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            YayineviBilgileriTemizle();

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AdminMenuEkrani adminMenuEkrani = new AdminMenuEkrani();
            adminMenuEkrani.ShowDialog();
            this.Hide();
        }
    }
}
