﻿using System;
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
    public partial class AdminMenuEkrani : Form
    {
        public AdminMenuEkrani()
        {
            InitializeComponent();
        }

        private void btnKategoriIslemleri_Click(object sender, EventArgs e)
        {
            KategoriIslemEkrani kategoriIslemEkrani = new KategoriIslemEkrani();
            kategoriIslemEkrani.Show();
            this.Hide();
        }

        private void btnKitapIslemleri_Click(object sender, EventArgs e)
        {
            KitapIslemEkrani kitapIslemEkrani = new KitapIslemEkrani();
            kitapIslemEkrani.Show();
            this.Hide();
        }

        private void btnYayineviIslemleri_Click(object sender, EventArgs e)
        {
            YayineviIslemEkrani yayineviIslemEkrani = new YayineviIslemEkrani();
            yayineviIslemEkrani.Show();
            this.Hide();
        }

        private void btnUyeIslemleri_Click(object sender, EventArgs e)
        {
            UyeIslemEkrani uyeIslemEkrani = new UyeIslemEkrani();
            uyeIslemEkrani.Show();
            this.Hide();
        }

        private void btnUyeGorunumu_Click(object sender, EventArgs e)
        {

        }

        private void btnYazarIslemleri_Click(object sender, EventArgs e)
        {
            YazarIslemEkrani yazarIslemEkrani = new YazarIslemEkrani();
            yazarIslemEkrani.Show();
            this.Hide();
        }
    }
}
