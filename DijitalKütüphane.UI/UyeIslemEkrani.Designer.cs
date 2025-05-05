namespace DijitalKütüphane.UI
{
    partial class UyeIslemEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpUyeIslemleri = new GroupBox();
            btnFotografSec = new Button();
            dtpDogumTarihi = new DateTimePicker();
            mtxtTelefon = new MaskedTextBox();
            chkSifreGoster = new CheckBox();
            txtFotograf = new TextBox();
            txtSehir = new TextBox();
            txtEmail = new TextBox();
            txtUlke = new TextBox();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label9 = new Label();
            label5 = new Label();
            label8 = new Label();
            label4 = new Label();
            label10 = new Label();
            label7 = new Label();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvUyeler = new DataGridView();
            btnTemizle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            pbFotograf = new PictureBox();
            btnGeri = new Button();
            grpUyeIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFotograf).BeginInit();
            SuspendLayout();
            // 
            // grpUyeIslemleri
            // 
            grpUyeIslemleri.Controls.Add(btnFotografSec);
            grpUyeIslemleri.Controls.Add(dtpDogumTarihi);
            grpUyeIslemleri.Controls.Add(mtxtTelefon);
            grpUyeIslemleri.Controls.Add(chkSifreGoster);
            grpUyeIslemleri.Controls.Add(txtFotograf);
            grpUyeIslemleri.Controls.Add(txtSehir);
            grpUyeIslemleri.Controls.Add(txtEmail);
            grpUyeIslemleri.Controls.Add(txtUlke);
            grpUyeIslemleri.Controls.Add(txtSifre);
            grpUyeIslemleri.Controls.Add(txtKullaniciAdi);
            grpUyeIslemleri.Controls.Add(txtSoyad);
            grpUyeIslemleri.Controls.Add(txtAd);
            grpUyeIslemleri.Controls.Add(label9);
            grpUyeIslemleri.Controls.Add(label5);
            grpUyeIslemleri.Controls.Add(label8);
            grpUyeIslemleri.Controls.Add(label4);
            grpUyeIslemleri.Controls.Add(label10);
            grpUyeIslemleri.Controls.Add(label7);
            grpUyeIslemleri.Controls.Add(label3);
            grpUyeIslemleri.Controls.Add(label6);
            grpUyeIslemleri.Controls.Add(label2);
            grpUyeIslemleri.Controls.Add(label1);
            grpUyeIslemleri.Location = new Point(67, 28);
            grpUyeIslemleri.Name = "grpUyeIslemleri";
            grpUyeIslemleri.Size = new Size(544, 459);
            grpUyeIslemleri.TabIndex = 0;
            grpUyeIslemleri.TabStop = false;
            grpUyeIslemleri.Text = "Üye İşlemleri";
            // 
            // btnFotografSec
            // 
            btnFotografSec.Location = new Point(344, 413);
            btnFotografSec.Name = "btnFotografSec";
            btnFotografSec.Size = new Size(54, 34);
            btnFotografSec.TabIndex = 5;
            btnFotografSec.Text = "Seç";
            btnFotografSec.UseVisualStyleBackColor = true;
            btnFotografSec.Click += btnFotografSec_Click;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(155, 206);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(183, 31);
            dtpDogumTarihi.TabIndex = 4;
            // 
            // mtxtTelefon
            // 
            mtxtTelefon.Location = new Point(156, 248);
            mtxtTelefon.Mask = "(999) 000-0000";
            mtxtTelefon.Name = "mtxtTelefon";
            mtxtTelefon.Size = new Size(182, 31);
            mtxtTelefon.TabIndex = 3;
            // 
            // chkSifreGoster
            // 
            chkSifreGoster.AutoSize = true;
            chkSifreGoster.Location = new Point(344, 169);
            chkSifreGoster.Name = "chkSifreGoster";
            chkSifreGoster.Size = new Size(90, 29);
            chkSifreGoster.TabIndex = 2;
            chkSifreGoster.Text = "Göster";
            chkSifreGoster.UseVisualStyleBackColor = true;
            // 
            // txtFotograf
            // 
            txtFotograf.Location = new Point(156, 416);
            txtFotograf.Name = "txtFotograf";
            txtFotograf.ReadOnly = true;
            txtFotograf.Size = new Size(182, 31);
            txtFotograf.TabIndex = 1;
            // 
            // txtSehir
            // 
            txtSehir.Location = new Point(156, 374);
            txtSehir.Name = "txtSehir";
            txtSehir.Size = new Size(182, 31);
            txtSehir.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(156, 290);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(182, 31);
            txtEmail.TabIndex = 1;
            // 
            // txtUlke
            // 
            txtUlke.Location = new Point(156, 332);
            txtUlke.Name = "txtUlke";
            txtUlke.Size = new Size(182, 31);
            txtUlke.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(156, 164);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(182, 31);
            txtSifre.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(156, 122);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(182, 31);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(156, 80);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(182, 31);
            txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(156, 38);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(182, 31);
            txtAd.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 419);
            label9.Name = "label9";
            label9.Size = new Size(83, 25);
            label9.TabIndex = 0;
            label9.Text = "Fotoğraf";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 209);
            label5.Name = "label5";
            label5.Size = new Size(123, 25);
            label5.TabIndex = 0;
            label5.Text = "Doğum Tarihi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 377);
            label8.Name = "label8";
            label8.Size = new Size(54, 25);
            label8.TabIndex = 0;
            label8.Text = "Şehir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 167);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 0;
            label4.Text = "Şifre";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 293);
            label10.Name = "label10";
            label10.Size = new Size(56, 25);
            label10.TabIndex = 0;
            label10.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 335);
            label7.Name = "label7";
            label7.Size = new Size(49, 25);
            label7.TabIndex = 0;
            label7.Text = "Ülke";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 125);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 0;
            label3.Text = "Kullanıcı Adı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 251);
            label6.Name = "label6";
            label6.Size = new Size(73, 25);
            label6.TabIndex = 0;
            label6.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 83);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 0;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 41);
            label1.Name = "label1";
            label1.Size = new Size(35, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // dgvUyeler
            // 
            dgvUyeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUyeler.Location = new Point(31, 513);
            dgvUyeler.Name = "dgvUyeler";
            dgvUyeler.RowHeadersWidth = 51;
            dgvUyeler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUyeler.Size = new Size(1416, 288);
            dgvUyeler.TabIndex = 2;
            dgvUyeler.CellClick += dgvUyeler_CellClick;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(617, 425);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(130, 45);
            btnTemizle.TabIndex = 3;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(617, 373);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(130, 45);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(617, 321);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(130, 45);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(617, 269);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(130, 45);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // pbFotograf
            // 
            pbFotograf.Location = new Point(617, 40);
            pbFotograf.Name = "pbFotograf";
            pbFotograf.Size = new Size(277, 222);
            pbFotograf.SizeMode = PictureBoxSizeMode.Zoom;
            pbFotograf.TabIndex = 7;
            pbFotograf.TabStop = false;
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(-3, 1);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(64, 36);
            btnGeri.TabIndex = 8;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // UyeIslemEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1477, 813);
            Controls.Add(btnGeri);
            Controls.Add(pbFotograf);
            Controls.Add(btnTemizle);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dgvUyeler);
            Controls.Add(grpUyeIslemleri);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "UyeIslemEkrani";
            Text = "UyeIslemEkrani";
            Load += UyeIslemEkrani_Load;
            grpUyeIslemleri.ResumeLayout(false);
            grpUyeIslemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFotograf).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpUyeIslemleri;
        private DateTimePicker dtpDogumTarihi;
        private MaskedTextBox mtxtTelefon;
        private CheckBox chkSifreGoster;
        private TextBox txtSehir;
        private TextBox txtUlke;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label9;
        private Label label5;
        private Label label8;
        private Label label4;
        private Label label7;
        private Label label3;
        private Label label6;
        private Label label2;
        private Label label1;
        private DataGridView dgvUyeler;
        private Button btnTemizle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private TextBox txtEmail;
        private Label label10;
        private Button btnFotografSec;
        private TextBox txtFotograf;
        private PictureBox pbFotograf;
        private Button btnGeri;
    }
}