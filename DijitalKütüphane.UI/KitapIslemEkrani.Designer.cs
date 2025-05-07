namespace DijitalKütüphane.UI
{
    partial class KitapIslemEkrani
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
            btnGeri = new Button();
            label1 = new Label();
            txtAd = new TextBox();
            grpKitapIslemleri = new GroupBox();
            nudSayfaSayisi = new NumericUpDown();
            nudAdet = new NumericUpDown();
            mtxtRafNumarasi = new MaskedTextBox();
            mtxtBasimYili = new MaskedTextBox();
            cbDil = new ComboBox();
            cbDurum = new ComboBox();
            cbYazar = new ComboBox();
            cbKategori = new ComboBox();
            cbYayinevi = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtAciklama = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnTemizle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            dgvKitaplar = new DataGridView();
            grpKitapIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSayfaSayisi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            SuspendLayout();
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(52, 73, 94);
            btnGeri.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnGeri.ForeColor = SystemColors.ButtonHighlight;
            btnGeri.Location = new Point(13, 13);
            btnGeri.Margin = new Padding(4);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(75, 40);
            btnGeri.TabIndex = 2;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.Location = new Point(51, 42);
            label1.Name = "label1";
            label1.Size = new Size(36, 25);
            label1.TabIndex = 7;
            label1.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtAd.Location = new Point(172, 39);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(242, 32);
            txtAd.TabIndex = 0;
            // 
            // grpKitapIslemleri
            // 
            grpKitapIslemleri.Controls.Add(nudSayfaSayisi);
            grpKitapIslemleri.Controls.Add(nudAdet);
            grpKitapIslemleri.Controls.Add(mtxtRafNumarasi);
            grpKitapIslemleri.Controls.Add(mtxtBasimYili);
            grpKitapIslemleri.Controls.Add(cbDil);
            grpKitapIslemleri.Controls.Add(cbDurum);
            grpKitapIslemleri.Controls.Add(cbYazar);
            grpKitapIslemleri.Controls.Add(cbKategori);
            grpKitapIslemleri.Controls.Add(cbYayinevi);
            grpKitapIslemleri.Controls.Add(label11);
            grpKitapIslemleri.Controls.Add(label10);
            grpKitapIslemleri.Controls.Add(label9);
            grpKitapIslemleri.Controls.Add(label8);
            grpKitapIslemleri.Controls.Add(txtAciklama);
            grpKitapIslemleri.Controls.Add(label7);
            grpKitapIslemleri.Controls.Add(label6);
            grpKitapIslemleri.Controls.Add(label5);
            grpKitapIslemleri.Controls.Add(label4);
            grpKitapIslemleri.Controls.Add(label3);
            grpKitapIslemleri.Controls.Add(label2);
            grpKitapIslemleri.Controls.Add(txtAd);
            grpKitapIslemleri.Controls.Add(label1);
            grpKitapIslemleri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpKitapIslemleri.Location = new Point(99, 53);
            grpKitapIslemleri.Name = "grpKitapIslemleri";
            grpKitapIslemleri.Size = new Size(871, 294);
            grpKitapIslemleri.TabIndex = 0;
            grpKitapIslemleri.TabStop = false;
            grpKitapIslemleri.Text = "Kitap İşlemleri";
            // 
            // nudSayfaSayisi
            // 
            nudSayfaSayisi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            nudSayfaSayisi.Location = new Point(172, 77);
            nudSayfaSayisi.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudSayfaSayisi.Name = "nudSayfaSayisi";
            nudSayfaSayisi.Size = new Size(242, 32);
            nudSayfaSayisi.TabIndex = 2;
            // 
            // nudAdet
            // 
            nudAdet.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            nudAdet.Location = new Point(172, 195);
            nudAdet.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(242, 32);
            nudAdet.TabIndex = 7;
            // 
            // mtxtRafNumarasi
            // 
            mtxtRafNumarasi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            mtxtRafNumarasi.Location = new Point(607, 237);
            mtxtRafNumarasi.Mask = "0000";
            mtxtRafNumarasi.Name = "mtxtRafNumarasi";
            mtxtRafNumarasi.Size = new Size(212, 32);
            mtxtRafNumarasi.TabIndex = 10;
            mtxtRafNumarasi.ValidatingType = typeof(int);
            // 
            // mtxtBasimYili
            // 
            mtxtBasimYili.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            mtxtBasimYili.Location = new Point(607, 198);
            mtxtBasimYili.Mask = "0000";
            mtxtBasimYili.Name = "mtxtBasimYili";
            mtxtBasimYili.Size = new Size(212, 32);
            mtxtBasimYili.TabIndex = 8;
            mtxtBasimYili.ValidatingType = typeof(int);
            // 
            // cbDil
            // 
            cbDil.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDil.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cbDil.FormattingEnabled = true;
            cbDil.Location = new Point(607, 115);
            cbDil.Name = "cbDil";
            cbDil.Size = new Size(212, 33);
            cbDil.TabIndex = 4;
            // 
            // cbDurum
            // 
            cbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDurum.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cbDurum.FormattingEnabled = true;
            cbDurum.Location = new Point(172, 233);
            cbDurum.Name = "cbDurum";
            cbDurum.Size = new Size(242, 33);
            cbDurum.TabIndex = 9;
            // 
            // cbYazar
            // 
            cbYazar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYazar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cbYazar.FormattingEnabled = true;
            cbYazar.Location = new Point(607, 157);
            cbYazar.Name = "cbYazar";
            cbYazar.Size = new Size(212, 33);
            cbYazar.TabIndex = 6;
            // 
            // cbKategori
            // 
            cbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKategori.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cbKategori.FormattingEnabled = true;
            cbKategori.Location = new Point(172, 115);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(242, 33);
            cbKategori.TabIndex = 3;
            // 
            // cbYayinevi
            // 
            cbYayinevi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYayinevi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cbYayinevi.FormattingEnabled = true;
            cbYayinevi.Location = new Point(172, 155);
            cbYayinevi.Name = "cbYayinevi";
            cbYayinevi.Size = new Size(242, 33);
            cbYayinevi.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label11.Location = new Point(479, 240);
            label11.Name = "label11";
            label11.Size = new Size(129, 25);
            label11.TabIndex = 27;
            label11.Text = "Raf Numarası";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label10.Location = new Point(479, 201);
            label10.Name = "label10";
            label10.Size = new Size(94, 25);
            label10.TabIndex = 25;
            label10.Text = "Basım Yılı";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label9.Location = new Point(479, 163);
            label9.Name = "label9";
            label9.Size = new Size(57, 25);
            label9.TabIndex = 23;
            label9.Text = "Yazar";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label8.Location = new Point(479, 123);
            label8.Name = "label8";
            label8.Size = new Size(36, 25);
            label8.TabIndex = 21;
            label8.Text = "Dil";
            // 
            // txtAciklama
            // 
            txtAciklama.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtAciklama.Location = new Point(607, 39);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(212, 69);
            txtAciklama.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label7.Location = new Point(479, 42);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 19;
            label7.Text = "Açıklama";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.Location = new Point(51, 236);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 17;
            label6.Text = "Durum";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.Location = new Point(51, 198);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 15;
            label5.Text = "Adet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.Location = new Point(51, 159);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 13;
            label4.Text = "Yayınevi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(51, 120);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 11;
            label3.Text = "Kategori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.Location = new Point(51, 81);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 9;
            label2.Text = "Sayfa Sayısı";
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(52, 73, 94);
            btnTemizle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnTemizle.ForeColor = SystemColors.ButtonHighlight;
            btnTemizle.Location = new Point(594, 353);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(150, 50);
            btnTemizle.TabIndex = 4;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(52, 73, 94);
            btnGuncelle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnGuncelle.ForeColor = SystemColors.ButtonHighlight;
            btnGuncelle.Location = new Point(429, 353);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(150, 50);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(52, 73, 94);
            btnSil.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSil.ForeColor = SystemColors.ButtonHighlight;
            btnSil.Location = new Point(264, 353);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(150, 50);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(52, 73, 94);
            btnEkle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnEkle.ForeColor = SystemColors.ButtonHighlight;
            btnEkle.Location = new Point(99, 353);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(150, 50);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dgvKitaplar.BackgroundColor = Color.FromArgb(164, 176, 190);
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplar.Location = new Point(99, 418);
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.RowHeadersWidth = 51;
            dgvKitaplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKitaplar.Size = new Size(1236, 362);
            dgvKitaplar.TabIndex = 14;
            dgvKitaplar.CellClick += dgvKitaplar_CellClick;
            // 
            // KitapIslemEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 176, 190);
            ClientSize = new Size(1404, 814);
            Controls.Add(dgvKitaplar);
            Controls.Add(btnTemizle);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(grpKitapIslemleri);
            Controls.Add(btnGeri);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "KitapIslemEkrani";
            Text = "KitapIslemEkrani";
            WindowState = FormWindowState.Maximized;
            Load += KitapIslemEkrani_Load;
            grpKitapIslemleri.ResumeLayout(false);
            grpKitapIslemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSayfaSayisi).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGeri;
        private Label label1;
        private TextBox txtAd;
        private GroupBox grpKitapIslemleri;
        private Label label8;
        private TextBox txtAciklama;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label11;
        private Label label10;
        private Label label9;
        private ComboBox cbYazar;
        private ComboBox cbYayinevi;
        private ComboBox cbKategori;
        private Button btnTemizle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private DataGridView dgvKitaplar;
        private ComboBox cbDurum;
        private ComboBox cbDil;
        private MaskedTextBox mtxtBasimYili;
        private NumericUpDown nudSayfaSayisi;
        private NumericUpDown nudAdet;
        private MaskedTextBox mtxtRafNumarasi;
    }
}