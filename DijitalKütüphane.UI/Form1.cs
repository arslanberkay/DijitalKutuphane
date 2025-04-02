namespace DijitalKütüphane.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Kullanıcı Adı alanı doldurulmalıdır!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Şifre alanı doldurulmalıdır!");
                return;
            }

            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Hide();
        }
    }
}
