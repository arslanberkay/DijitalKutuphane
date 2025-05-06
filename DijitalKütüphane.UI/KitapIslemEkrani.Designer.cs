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
            groupBox1 = new GroupBox();
            cbYazar = new ComboBox();
            cbKategori = new ComboBox();
            cbYayinevi = new ComboBox();
            txtRafNo = new TextBox();
            label11 = new Label();
            txtBasimYili = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtDil = new TextBox();
            label8 = new Label();
            txtAciklama = new TextBox();
            label7 = new Label();
            txtDurum = new TextBox();
            label6 = new Label();
            txtAdet = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtSayfaSayisi = new TextBox();
            label2 = new Label();
            btnTemizle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            dgvKitaplar = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            SuspendLayout();
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(1, 2);
            btnGeri.Margin = new Padding(4);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(80, 45);
            btnGeri.TabIndex = 6;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 65);
            label1.Name = "label1";
            label1.Size = new Size(35, 25);
            label1.TabIndex = 7;
            label1.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(172, 62);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(169, 31);
            txtAd.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbYazar);
            groupBox1.Controls.Add(cbKategori);
            groupBox1.Controls.Add(cbYayinevi);
            groupBox1.Controls.Add(txtRafNo);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtBasimYili);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtDil);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtAciklama);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtDurum);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtAdet);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSayfaSayisi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(92, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(750, 309);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap İşlemleri";
            // 
            // cbYazar
            // 
            cbYazar.FormattingEnabled = true;
            cbYazar.Location = new Point(475, 175);
            cbYazar.Name = "cbYazar";
            cbYazar.Size = new Size(212, 33);
            cbYazar.TabIndex = 29;
            // 
            // cbKategori
            // 
            cbKategori.FormattingEnabled = true;
            cbKategori.Location = new Point(172, 141);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(169, 33);
            cbKategori.TabIndex = 29;
            // 
            // cbYayinevi
            // 
            cbYayinevi.FormattingEnabled = true;
            cbYayinevi.Location = new Point(172, 175);
            cbYayinevi.Name = "cbYayinevi";
            cbYayinevi.Size = new Size(169, 33);
            cbYayinevi.TabIndex = 29;
            // 
            // txtRafNo
            // 
            txtRafNo.Location = new Point(475, 258);
            txtRafNo.Name = "txtRafNo";
            txtRafNo.Size = new Size(212, 31);
            txtRafNo.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(354, 257);
            label11.Name = "label11";
            label11.Size = new Size(122, 25);
            label11.TabIndex = 27;
            label11.Text = "Raf Numarası";
            // 
            // txtBasimYili
            // 
            txtBasimYili.Location = new Point(475, 217);
            txtBasimYili.Name = "txtBasimYili";
            txtBasimYili.Size = new Size(212, 31);
            txtBasimYili.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(354, 217);
            label10.Name = "label10";
            label10.Size = new Size(91, 25);
            label10.TabIndex = 25;
            label10.Text = "Basım Yılı";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(354, 177);
            label9.Name = "label9";
            label9.Size = new Size(53, 25);
            label9.TabIndex = 23;
            label9.Text = "Yazar";
            // 
            // txtDil
            // 
            txtDil.Location = new Point(475, 135);
            txtDil.Name = "txtDil";
            txtDil.Size = new Size(212, 31);
            txtDil.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(354, 137);
            label8.Name = "label8";
            label8.Size = new Size(35, 25);
            label8.TabIndex = 21;
            label8.Text = "Dil";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(475, 59);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(212, 69);
            txtAciklama.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(354, 62);
            label7.Name = "label7";
            label7.Size = new Size(85, 25);
            label7.TabIndex = 19;
            label7.Text = "Açıklama";
            // 
            // txtDurum
            // 
            txtDurum.Location = new Point(172, 252);
            txtDurum.Name = "txtDurum";
            txtDurum.Size = new Size(169, 31);
            txtDurum.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 255);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 17;
            label6.Text = "Durum";
            // 
            // txtAdet
            // 
            txtAdet.Location = new Point(172, 214);
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(169, 31);
            txtAdet.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 217);
            label5.Name = "label5";
            label5.Size = new Size(52, 25);
            label5.TabIndex = 15;
            label5.Text = "Adet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 179);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 13;
            label4.Text = "Yayınevi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 141);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 11;
            label3.Text = "Kategori";
            // 
            // txtSayfaSayisi
            // 
            txtSayfaSayisi.Location = new Point(172, 100);
            txtSayfaSayisi.Name = "txtSayfaSayisi";
            txtSayfaSayisi.Size = new Size(169, 31);
            txtSayfaSayisi.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 103);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 9;
            label2.Text = "Sayfa Sayısı";
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(548, 368);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(118, 45);
            btnTemizle.TabIndex = 13;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(412, 368);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(130, 45);
            btnGuncelle.TabIndex = 12;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(276, 368);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(130, 45);
            btnSil.TabIndex = 11;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(140, 368);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(130, 45);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplar.Location = new Point(22, 429);
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.RowHeadersWidth = 51;
            dgvKitaplar.Size = new Size(1352, 362);
            dgvKitaplar.TabIndex = 14;
            // 
            // KitapIslemEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 814);
            Controls.Add(dgvKitaplar);
            Controls.Add(btnTemizle);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(groupBox1);
            Controls.Add(btnGeri);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "KitapIslemEkrani";
            Text = "KitapIslemEkrani";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGeri;
        private Label label1;
        private TextBox txtAd;
        private GroupBox groupBox1;
        private TextBox txtDil;
        private Label label8;
        private TextBox txtAciklama;
        private Label label7;
        private TextBox txtDurum;
        private Label label6;
        private TextBox txtAdet;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtSayfaSayisi;
        private Label label2;
        private TextBox txtRafNo;
        private Label label11;
        private TextBox txtBasimYili;
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
    }
}