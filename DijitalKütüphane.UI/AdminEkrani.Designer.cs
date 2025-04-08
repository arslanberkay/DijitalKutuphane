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
            groupBox1 = new GroupBox();
            mtxtOlusturulmaTarihi = new MaskedTextBox();
            btnUyeEkle = new Button();
            btnUyeSil = new Button();
            btnUyeGuncelle = new Button();
            btnUyeTemizle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUyeler
            // 
            dgvUyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUyeler.Location = new Point(37, 63);
            dgvUyeler.Margin = new Padding(4);
            dgvUyeler.Name = "dgvUyeler";
            dgvUyeler.RowHeadersWidth = 51;
            dgvUyeler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUyeler.Size = new Size(818, 276);
            dgvUyeler.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(365, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 1;
            label1.Text = "Üyeler";
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplar.Location = new Point(897, 63);
            dgvKitaplar.Margin = new Padding(4);
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.RowHeadersWidth = 51;
            dgvKitaplar.Size = new Size(817, 276);
            dgvKitaplar.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1259, 19);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
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
            txtId.Size = new Size(178, 34);
            txtId.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 91);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 2;
            label4.Text = "Soyisim";
            // 
            // txtSoyisim
            // 
            txtSoyisim.Location = new Point(158, 94);
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(178, 34);
            txtSoyisim.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 139);
            label5.Name = "label5";
            label5.Size = new Size(120, 28);
            label5.TabIndex = 2;
            label5.Text = "Kullanıcı Adı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 187);
            label6.Name = "label6";
            label6.Size = new Size(53, 28);
            label6.TabIndex = 2;
            label6.Text = "Yetki";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(158, 142);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(178, 34);
            txtKullaniciAdi.TabIndex = 3;
            // 
            // txtYetki
            // 
            txtYetki.Location = new Point(158, 190);
            txtYetki.Name = "txtYetki";
            txtYetki.Size = new Size(178, 34);
            txtYetki.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(386, 141);
            label8.Name = "label8";
            label8.Size = new Size(51, 28);
            label8.TabIndex = 2;
            label8.Text = "Şifre";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(386, 95);
            label9.Name = "label9";
            label9.Size = new Size(154, 28);
            label9.TabIndex = 2;
            label9.Text = "Oluşturma Tarihi";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(562, 138);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(178, 34);
            txtSifre.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(386, 49);
            label7.Name = "label7";
            label7.Size = new Size(47, 28);
            label7.TabIndex = 2;
            label7.Text = "İsim";
            // 
            // txtIsim
            // 
            txtIsim.Location = new Point(562, 46);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(178, 34);
            txtIsim.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mtxtOlusturulmaTarihi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtYetki);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtSoyisim);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtKullaniciAdi);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtIsim);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtId);
            groupBox1.Location = new Point(37, 367);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(818, 244);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Üye İşlemleri";
            // 
            // mtxtOlusturulmaTarihi
            // 
            mtxtOlusturulmaTarihi.Location = new Point(562, 92);
            mtxtOlusturulmaTarihi.Mask = "00/00/0000 90:00";
            mtxtOlusturulmaTarihi.Name = "mtxtOlusturulmaTarihi";
            mtxtOlusturulmaTarihi.Size = new Size(176, 34);
            mtxtOlusturulmaTarihi.TabIndex = 4;
            mtxtOlusturulmaTarihi.ValidatingType = typeof(DateTime);
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.Location = new Point(37, 629);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(181, 39);
            btnUyeEkle.TabIndex = 5;
            btnUyeEkle.Text = "Ekle";
            btnUyeEkle.UseVisualStyleBackColor = true;
            btnUyeEkle.Click += btnUyeEkle_Click;
            // 
            // btnUyeSil
            // 
            btnUyeSil.Location = new Point(246, 629);
            btnUyeSil.Name = "btnUyeSil";
            btnUyeSil.Size = new Size(180, 39);
            btnUyeSil.TabIndex = 5;
            btnUyeSil.Text = "Sil";
            btnUyeSil.UseVisualStyleBackColor = true;
            btnUyeSil.Click += btnUyeSil_Click;
            // 
            // btnUyeGuncelle
            // 
            btnUyeGuncelle.Location = new Point(454, 629);
            btnUyeGuncelle.Name = "btnUyeGuncelle";
            btnUyeGuncelle.Size = new Size(190, 39);
            btnUyeGuncelle.TabIndex = 5;
            btnUyeGuncelle.Text = "Güncelle";
            btnUyeGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnUyeTemizle
            // 
            btnUyeTemizle.Location = new Point(672, 629);
            btnUyeTemizle.Name = "btnUyeTemizle";
            btnUyeTemizle.Size = new Size(181, 39);
            btnUyeTemizle.TabIndex = 5;
            btnUyeTemizle.Text = "Temizle";
            btnUyeTemizle.UseVisualStyleBackColor = true;
            // 
            // AdminEkrani
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1750, 727);
            Controls.Add(btnUyeTemizle);
            Controls.Add(btnUyeGuncelle);
            Controls.Add(btnUyeSil);
            Controls.Add(btnUyeEkle);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvKitaplar);
            Controls.Add(dgvUyeler);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "AdminEkrani";
            Text = "Admin Ekranı";
            Load += AdminEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private Button btnUyeEkle;
        private Button btnUyeSil;
        private Button btnUyeGuncelle;
        private Button btnUyeTemizle;
        private MaskedTextBox mtxtOlusturulmaTarihi;
    }
}