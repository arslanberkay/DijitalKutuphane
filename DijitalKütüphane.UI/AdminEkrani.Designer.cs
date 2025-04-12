namespace DijitalKütüphane.UI
{
    partial class AdminEkrani
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvUyeler = new DataGridView();
            label1 = new Label();
            dgvKitaplar = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            label4 = new Label();
            txtSoyisim = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtKullaniciAdi = new TextBox();
            txtYetki = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtSifre = new TextBox();
            label7 = new Label();
            txtIsim = new TextBox();
            grpUyeIslemleri = new GroupBox();
            mtxtOlusturulmaTarihi = new MaskedTextBox();
            btnUyeEkle = new Button();
            btnUyeSil = new Button();
            btnUyeGuncelle = new Button();
            btnUyeTemizle = new Button();
            grpKitapIslemleri = new GroupBox();
            mtxtKitapBasimYili = new MaskedTextBox();
            txtKitapAd = new TextBox();
            txtKitapId = new TextBox();
            label17 = new Label();
            label18 = new Label();
            label16 = new Label();
            txtKitapYayinEvi = new TextBox();
            label13 = new Label();
            label10 = new Label();
            txtKitapAdet = new TextBox();
            txtKitapDil = new TextBox();
            label15 = new Label();
            txtKitapSayfa = new TextBox();
            label14 = new Label();
            label11 = new Label();
            txtKitapTur = new TextBox();
            label12 = new Label();
            txtKitapYazar = new TextBox();
            btnKitapEkle = new Button();
            btnKitapSil = new Button();
            btnKitapGuncelle = new Button();
            btnKitapTemizle = new Button();
            btnUyeAra = new Button();
            btnUyeYenile = new Button();
            txtUyeIdArama = new TextBox();
            btnKitapAra = new Button();
            btnKitapYenile = new Button();
            txtKitapIdArama = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            grpUyeIslemleri.SuspendLayout();
            grpKitapIslemleri.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUyeler
            // 
            dgvUyeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUyeler.BackgroundColor = Color.White;
            dgvUyeler.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(70, 130, 180);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUyeler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUyeler.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUyeler.EnableHeadersVisualStyles = false;
            dgvUyeler.GridColor = Color.LightGray;
            dgvUyeler.Location = new Point(37, 63);
            dgvUyeler.Margin = new Padding(4);
            dgvUyeler.Name = "dgvUyeler";
            dgvUyeler.RowHeadersWidth = 51;
            dgvUyeler.RowTemplate.Height = 25;
            dgvUyeler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUyeler.Size = new Size(873, 276);
            dgvUyeler.TabIndex = 0;
            dgvUyeler.CellClick += dgvUyeler_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(466, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 31);
            label1.TabIndex = 1;
            label1.Text = "Üyeler";
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvKitaplar.BackgroundColor = Color.White;
            dgvKitaplar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(70, 130, 180);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvKitaplar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvKitaplar.DefaultCellStyle = dataGridViewCellStyle4;
            dgvKitaplar.EnableHeadersVisualStyles = false;
            dgvKitaplar.Location = new Point(943, 63);
            dgvKitaplar.Margin = new Padding(4);
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.RowHeadersWidth = 51;
            dgvKitaplar.RowTemplate.Height = 25;
            dgvKitaplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKitaplar.Size = new Size(866, 276);
            dgvKitaplar.TabIndex = 0;
            dgvKitaplar.CellClick += dgvKitaplar_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(1389, 20);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 31);
            label2.TabIndex = 1;
            label2.Text = "Kitaplar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 43);
            label3.Name = "label3";
            label3.Size = new Size(31, 28);
            label3.TabIndex = 2;
            label3.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(158, 46);
            txtId.Name = "txtId";
            txtId.Size = new Size(231, 34);
            txtId.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 87);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 2;
            label4.Text = "Soyisim";
            // 
            // txtSoyisim
            // 
            txtSoyisim.Location = new Point(158, 89);
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(231, 34);
            txtSoyisim.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 131);
            label5.Name = "label5";
            label5.Size = new Size(120, 28);
            label5.TabIndex = 2;
            label5.Text = "Kullanıcı Adı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 175);
            label6.Name = "label6";
            label6.Size = new Size(53, 28);
            label6.TabIndex = 2;
            label6.Text = "Yetki";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(158, 132);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(231, 34);
            txtKullaniciAdi.TabIndex = 3;
            // 
            // txtYetki
            // 
            txtYetki.Location = new Point(158, 175);
            txtYetki.Name = "txtYetki";
            txtYetki.Size = new Size(231, 34);
            txtYetki.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(429, 129);
            label8.Name = "label8";
            label8.Size = new Size(51, 28);
            label8.TabIndex = 2;
            label8.Text = "Şifre";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(429, 90);
            label9.Name = "label9";
            label9.Size = new Size(154, 28);
            label9.TabIndex = 2;
            label9.Text = "Oluşturma Tarihi";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(603, 129);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(217, 34);
            txtSifre.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(429, 51);
            label7.Name = "label7";
            label7.Size = new Size(47, 28);
            label7.TabIndex = 2;
            label7.Text = "İsim";
            // 
            // txtIsim
            // 
            txtIsim.Location = new Point(603, 45);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(217, 34);
            txtIsim.TabIndex = 3;
            // 
            // grpUyeIslemleri
            // 
            grpUyeIslemleri.Controls.Add(mtxtOlusturulmaTarihi);
            grpUyeIslemleri.Controls.Add(label3);
            grpUyeIslemleri.Controls.Add(txtYetki);
            grpUyeIslemleri.Controls.Add(label7);
            grpUyeIslemleri.Controls.Add(label5);
            grpUyeIslemleri.Controls.Add(txtSoyisim);
            grpUyeIslemleri.Controls.Add(label8);
            grpUyeIslemleri.Controls.Add(txtSifre);
            grpUyeIslemleri.Controls.Add(label4);
            grpUyeIslemleri.Controls.Add(txtKullaniciAdi);
            grpUyeIslemleri.Controls.Add(label9);
            grpUyeIslemleri.Controls.Add(txtIsim);
            grpUyeIslemleri.Controls.Add(label6);
            grpUyeIslemleri.Controls.Add(txtId);
            grpUyeIslemleri.Location = new Point(37, 358);
            grpUyeIslemleri.Name = "grpUyeIslemleri";
            grpUyeIslemleri.Size = new Size(873, 226);
            grpUyeIslemleri.TabIndex = 4;
            grpUyeIslemleri.TabStop = false;
            grpUyeIslemleri.Text = "Üye İşlemleri";
            // 
            // mtxtOlusturulmaTarihi
            // 
            mtxtOlusturulmaTarihi.Location = new Point(603, 87);
            mtxtOlusturulmaTarihi.Mask = "00/00/0000 90:00";
            mtxtOlusturulmaTarihi.Name = "mtxtOlusturulmaTarihi";
            mtxtOlusturulmaTarihi.Size = new Size(215, 34);
            mtxtOlusturulmaTarihi.TabIndex = 4;
            mtxtOlusturulmaTarihi.ValidatingType = typeof(DateTime);
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.Location = new Point(37, 590);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(195, 39);
            btnUyeEkle.TabIndex = 5;
            btnUyeEkle.Text = "Ekle";
            btnUyeEkle.UseVisualStyleBackColor = true;
            btnUyeEkle.Click += btnUyeEkle_Click;
            // 
            // btnUyeSil
            // 
            btnUyeSil.Location = new Point(258, 590);
            btnUyeSil.Name = "btnUyeSil";
            btnUyeSil.Size = new Size(195, 39);
            btnUyeSil.TabIndex = 5;
            btnUyeSil.Text = "Sil";
            btnUyeSil.UseVisualStyleBackColor = true;
            btnUyeSil.Click += btnUyeSil_Click;
            // 
            // btnUyeGuncelle
            // 
            btnUyeGuncelle.Location = new Point(479, 590);
            btnUyeGuncelle.Name = "btnUyeGuncelle";
            btnUyeGuncelle.Size = new Size(211, 39);
            btnUyeGuncelle.TabIndex = 5;
            btnUyeGuncelle.Text = "Güncelle";
            btnUyeGuncelle.UseVisualStyleBackColor = true;
            btnUyeGuncelle.Click += btnUyeGuncelle_Click;
            // 
            // btnUyeTemizle
            // 
            btnUyeTemizle.Location = new Point(716, 590);
            btnUyeTemizle.Name = "btnUyeTemizle";
            btnUyeTemizle.Size = new Size(194, 39);
            btnUyeTemizle.TabIndex = 5;
            btnUyeTemizle.Text = "Temizle";
            btnUyeTemizle.UseVisualStyleBackColor = true;
            btnUyeTemizle.Click += btnUyeTemizle_Click;
            // 
            // grpKitapIslemleri
            // 
            grpKitapIslemleri.Controls.Add(mtxtKitapBasimYili);
            grpKitapIslemleri.Controls.Add(txtKitapAd);
            grpKitapIslemleri.Controls.Add(txtKitapId);
            grpKitapIslemleri.Controls.Add(label17);
            grpKitapIslemleri.Controls.Add(label18);
            grpKitapIslemleri.Controls.Add(label16);
            grpKitapIslemleri.Controls.Add(txtKitapYayinEvi);
            grpKitapIslemleri.Controls.Add(label13);
            grpKitapIslemleri.Controls.Add(label10);
            grpKitapIslemleri.Controls.Add(txtKitapAdet);
            grpKitapIslemleri.Controls.Add(txtKitapDil);
            grpKitapIslemleri.Controls.Add(label15);
            grpKitapIslemleri.Controls.Add(txtKitapSayfa);
            grpKitapIslemleri.Controls.Add(label14);
            grpKitapIslemleri.Controls.Add(label11);
            grpKitapIslemleri.Controls.Add(txtKitapTur);
            grpKitapIslemleri.Controls.Add(label12);
            grpKitapIslemleri.Controls.Add(txtKitapYazar);
            grpKitapIslemleri.Location = new Point(947, 358);
            grpKitapIslemleri.Name = "grpKitapIslemleri";
            grpKitapIslemleri.Size = new Size(866, 271);
            grpKitapIslemleri.TabIndex = 6;
            grpKitapIslemleri.TabStop = false;
            grpKitapIslemleri.Text = "Kitap İşlemleri";
            // 
            // mtxtKitapBasimYili
            // 
            mtxtKitapBasimYili.Location = new Point(553, 217);
            mtxtKitapBasimYili.Mask = "00/00/0000";
            mtxtKitapBasimYili.Name = "mtxtKitapBasimYili";
            mtxtKitapBasimYili.Size = new Size(236, 34);
            mtxtKitapBasimYili.TabIndex = 4;
            mtxtKitapBasimYili.ValidatingType = typeof(DateTime);
            // 
            // txtKitapAd
            // 
            txtKitapAd.Location = new Point(553, 37);
            txtKitapAd.Name = "txtKitapAd";
            txtKitapAd.Size = new Size(236, 34);
            txtKitapAd.TabIndex = 3;
            // 
            // txtKitapId
            // 
            txtKitapId.Location = new Point(105, 43);
            txtKitapId.Name = "txtKitapId";
            txtKitapId.Size = new Size(266, 34);
            txtKitapId.TabIndex = 3;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(453, 40);
            label17.Name = "label17";
            label17.Size = new Size(37, 28);
            label17.TabIndex = 2;
            label17.Text = "Ad";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(451, 85);
            label18.Name = "label18";
            label18.Size = new Size(87, 28);
            label18.TabIndex = 2;
            label18.Text = "Yayın Evi";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(451, 220);
            label16.Name = "label16";
            label16.Size = new Size(94, 28);
            label16.TabIndex = 2;
            label16.Text = "Basım Yılı";
            // 
            // txtKitapYayinEvi
            // 
            txtKitapYayinEvi.Location = new Point(551, 82);
            txtKitapYayinEvi.Name = "txtKitapYayinEvi";
            txtKitapYayinEvi.Size = new Size(236, 34);
            txtKitapYayinEvi.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(35, 49);
            label13.Name = "label13";
            label13.Size = new Size(31, 28);
            label13.TabIndex = 2;
            label13.Text = "ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(35, 184);
            label10.Name = "label10";
            label10.Size = new Size(36, 28);
            label10.TabIndex = 2;
            label10.Text = "Dil";
            // 
            // txtKitapAdet
            // 
            txtKitapAdet.Location = new Point(551, 172);
            txtKitapAdet.Name = "txtKitapAdet";
            txtKitapAdet.Size = new Size(236, 34);
            txtKitapAdet.TabIndex = 3;
            // 
            // txtKitapDil
            // 
            txtKitapDil.Location = new Point(105, 178);
            txtKitapDil.Name = "txtKitapDil";
            txtKitapDil.Size = new Size(266, 34);
            txtKitapDil.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(453, 130);
            label15.Name = "label15";
            label15.Size = new Size(40, 28);
            label15.TabIndex = 2;
            label15.Text = "Tür";
            // 
            // txtKitapSayfa
            // 
            txtKitapSayfa.Location = new Point(105, 133);
            txtKitapSayfa.Name = "txtKitapSayfa";
            txtKitapSayfa.Size = new Size(266, 34);
            txtKitapSayfa.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(451, 175);
            label14.Name = "label14";
            label14.Size = new Size(54, 28);
            label14.TabIndex = 2;
            label14.Text = "Adet";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 94);
            label11.Name = "label11";
            label11.Size = new Size(57, 28);
            label11.TabIndex = 2;
            label11.Text = "Yazar";
            // 
            // txtKitapTur
            // 
            txtKitapTur.Location = new Point(553, 127);
            txtKitapTur.Name = "txtKitapTur";
            txtKitapTur.Size = new Size(236, 34);
            txtKitapTur.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(35, 139);
            label12.Name = "label12";
            label12.Size = new Size(59, 28);
            label12.TabIndex = 2;
            label12.Text = "Sayfa";
            // 
            // txtKitapYazar
            // 
            txtKitapYazar.Location = new Point(105, 88);
            txtKitapYazar.Name = "txtKitapYazar";
            txtKitapYazar.Size = new Size(266, 34);
            txtKitapYazar.TabIndex = 3;
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.Location = new Point(945, 644);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(199, 39);
            btnKitapEkle.TabIndex = 5;
            btnKitapEkle.Text = "Ekle";
            btnKitapEkle.UseVisualStyleBackColor = true;
            btnKitapEkle.Click += btnUyeEkle_Click;
            // 
            // btnKitapSil
            // 
            btnKitapSil.Location = new Point(1171, 644);
            btnKitapSil.Name = "btnKitapSil";
            btnKitapSil.Size = new Size(191, 39);
            btnKitapSil.TabIndex = 5;
            btnKitapSil.Text = "Sil";
            btnKitapSil.UseVisualStyleBackColor = true;
            btnKitapSil.Click += btnUyeSil_Click;
            // 
            // btnKitapGuncelle
            // 
            btnKitapGuncelle.Location = new Point(1389, 644);
            btnKitapGuncelle.Name = "btnKitapGuncelle";
            btnKitapGuncelle.Size = new Size(204, 39);
            btnKitapGuncelle.TabIndex = 5;
            btnKitapGuncelle.Text = "Güncelle";
            btnKitapGuncelle.UseVisualStyleBackColor = true;
            btnKitapGuncelle.Click += btnUyeGuncelle_Click;
            // 
            // btnKitapTemizle
            // 
            btnKitapTemizle.Location = new Point(1620, 644);
            btnKitapTemizle.Name = "btnKitapTemizle";
            btnKitapTemizle.Size = new Size(189, 39);
            btnKitapTemizle.TabIndex = 5;
            btnKitapTemizle.Text = "Temizle";
            btnKitapTemizle.UseVisualStyleBackColor = true;
            btnKitapTemizle.Click += btnUyeTemizle_Click;
            // 
            // btnUyeAra
            // 
            btnUyeAra.Font = new Font("Segoe UI", 10.2F);
            btnUyeAra.Location = new Point(37, 22);
            btnUyeAra.Name = "btnUyeAra";
            btnUyeAra.Size = new Size(67, 34);
            btnUyeAra.TabIndex = 7;
            btnUyeAra.Text = "Ara";
            btnUyeAra.UseVisualStyleBackColor = true;
            btnUyeAra.Click += btnUyeAra_Click;
            // 
            // btnUyeYenile
            // 
            btnUyeYenile.Font = new Font("Segoe UI", 10.2F);
            btnUyeYenile.Location = new Point(213, 21);
            btnUyeYenile.Name = "btnUyeYenile";
            btnUyeYenile.Size = new Size(90, 34);
            btnUyeYenile.TabIndex = 7;
            btnUyeYenile.Text = "Yenile";
            btnUyeYenile.UseVisualStyleBackColor = true;
            btnUyeYenile.Click += btnUyeYenile_Click;
            // 
            // txtUyeIdArama
            // 
            txtUyeIdArama.Font = new Font("Segoe UI", 10.2F);
            txtUyeIdArama.Location = new Point(110, 22);
            txtUyeIdArama.Name = "txtUyeIdArama";
            txtUyeIdArama.Size = new Size(97, 30);
            txtUyeIdArama.TabIndex = 8;
            // 
            // btnKitapAra
            // 
            btnKitapAra.Font = new Font("Segoe UI", 10.2F);
            btnKitapAra.Location = new Point(947, 22);
            btnKitapAra.Name = "btnKitapAra";
            btnKitapAra.Size = new Size(67, 34);
            btnKitapAra.TabIndex = 7;
            btnKitapAra.Text = "Ara";
            btnKitapAra.UseVisualStyleBackColor = true;
            btnKitapAra.Click += btnKitapAra_Click;
            // 
            // btnKitapYenile
            // 
            btnKitapYenile.Font = new Font("Segoe UI", 10.2F);
            btnKitapYenile.Location = new Point(1123, 21);
            btnKitapYenile.Name = "btnKitapYenile";
            btnKitapYenile.Size = new Size(90, 34);
            btnKitapYenile.TabIndex = 7;
            btnKitapYenile.Text = "Yenile";
            btnKitapYenile.UseVisualStyleBackColor = true;
            btnKitapYenile.Click += btnKitapYenile_Click;
            // 
            // txtKitapIdArama
            // 
            txtKitapIdArama.Font = new Font("Segoe UI", 10.2F);
            txtKitapIdArama.Location = new Point(1020, 22);
            txtKitapIdArama.Name = "txtKitapIdArama";
            txtKitapIdArama.Size = new Size(97, 30);
            txtKitapIdArama.TabIndex = 8;
            // 
            // AdminEkrani
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1861, 717);
            Controls.Add(txtKitapIdArama);
            Controls.Add(txtUyeIdArama);
            Controls.Add(btnKitapYenile);
            Controls.Add(btnUyeYenile);
            Controls.Add(btnKitapAra);
            Controls.Add(btnUyeAra);
            Controls.Add(grpKitapIslemleri);
            Controls.Add(btnKitapTemizle);
            Controls.Add(btnUyeTemizle);
            Controls.Add(btnKitapGuncelle);
            Controls.Add(btnKitapSil);
            Controls.Add(btnKitapEkle);
            Controls.Add(btnUyeGuncelle);
            Controls.Add(grpUyeIslemleri);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUyeSil);
            Controls.Add(dgvKitaplar);
            Controls.Add(dgvUyeler);
            Controls.Add(btnUyeEkle);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "AdminEkrani";
            Text = "Admin Ekranı";
            Load += AdminEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            grpUyeIslemleri.ResumeLayout(false);
            grpUyeIslemleri.PerformLayout();
            grpKitapIslemleri.ResumeLayout(false);
            grpKitapIslemleri.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUyeler;
        private Label label1;
        private DataGridView dgvKitaplar;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private Label label4;
        private TextBox txtSoyisim;
        private Label label5;
        private Label label6;
        private TextBox txtKullaniciAdi;
        private TextBox txtYetki;
        private Label label8;
        private Label label9;
        private TextBox txtSifre;
        private Label label7;
        private TextBox txtIsim;
        private GroupBox grpUyeIslemleri;
        private Button btnUyeEkle;
        private Button btnUyeSil;
        private Button btnUyeGuncelle;
        private Button btnUyeTemizle;
        private MaskedTextBox mtxtOlusturulmaTarihi;
        private GroupBox grpKitapIslemleri;
        private TextBox txtKitapAd;
        private TextBox txtKitapId;
        private Label label17;
        private Label label16;
        private Label label13;
        private Label label10;
        private TextBox txtKitapAdet;
        private TextBox txtKitapDil;
        private Label label15;
        private TextBox txtKitapSayfa;
        private Label label14;
        private Label label11;
        private TextBox txtKitapTur;
        private Label label12;
        private TextBox txtKitapYazar;
        private Label label18;
        private TextBox txtKitapYayinEvi;
        private Button btnKitapEkle;
        private Button btnKitapSil;
        private Button btnKitapGuncelle;
        private Button btnKitapTemizle;
        private MaskedTextBox mtxtKitapBasimYili;
        private Button btnUyeAra;
        private Button btnUyeYenile;
        private TextBox txtUyeIdArama;
        private Button btnKitapAra;
        private Button btnKitapYenile;
        private TextBox txtKitapIdArama;
    }
}