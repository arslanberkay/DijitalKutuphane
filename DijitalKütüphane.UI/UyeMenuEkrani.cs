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
    public partial class UyeMenuEkrani : Form
    {
        public UyeMenuEkrani()
        {
            InitializeComponent();
        }

        private void btnKitapOduncAl_Click(object sender, EventArgs e)
        {
            UyeKitapOduncIslemEkrani uyeKitapOduncIslemEkrani = new UyeKitapOduncIslemEkrani();
            uyeKitapOduncIslemEkrani.Show();
            this.Hide();
        }

        private void btnKitaplarim_Click(object sender, EventArgs e)
        {
            UyeGorunumEkrani uyeGorunumEkrani = new UyeGorunumEkrani();
            uyeGorunumEkrani.Show();
            this.Hide();    
        }
    }
}
