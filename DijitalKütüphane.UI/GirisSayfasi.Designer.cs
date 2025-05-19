namespace DijitalKütüphane.UI
{
    partial class GirisSayfasi
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
            label1 = new Label();
            txtKullaniciAdi = new TextBox();
            label2 = new Label();
            txtSifre = new TextBox();
            groupBox1 = new GroupBox();
            chkSifreGoster = new CheckBox();
            lnkSifremiUnuttum = new LinkLabel();
            lnkKayitOl = new LinkLabel();
            btnGirisYap = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.Location = new Point(43, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtKullaniciAdi.Location = new Point(180, 44);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(213, 32);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.Location = new Point(43, 94);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 0;
            label2.Text = "Şifre";
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtSifre.Location = new Point(180, 91);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(213, 32);
            txtSifre.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkSifreGoster);
            groupBox1.Controls.Add(lnkSifremiUnuttum);
            groupBox1.Controls.Add(lnkKayitOl);
            groupBox1.Controls.Add(btnGirisYap);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Controls.Add(txtKullaniciAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(254, 185);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(498, 319);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // chkSifreGoster
            // 
            chkSifreGoster.AutoSize = true;
            chkSifreGoster.Location = new Point(399, 94);
            chkSifreGoster.Name = "chkSifreGoster";
            chkSifreGoster.Size = new Size(94, 32);
            chkSifreGoster.TabIndex = 2;
            chkSifreGoster.Text = "Göster";
            chkSifreGoster.UseVisualStyleBackColor = true;
            chkSifreGoster.CheckedChanged += chkSifreGoster_CheckedChanged;
            // 
            // lnkSifremiUnuttum
            // 
            lnkSifremiUnuttum.AutoSize = true;
            lnkSifremiUnuttum.LinkColor = SystemColors.ControlDarkDark;
            lnkSifremiUnuttum.Location = new Point(43, 254);
            lnkSifremiUnuttum.Name = "lnkSifremiUnuttum";
            lnkSifremiUnuttum.Size = new Size(164, 28);
            lnkSifremiUnuttum.TabIndex = 4;
            lnkSifremiUnuttum.TabStop = true;
            lnkSifremiUnuttum.Text = "Şifremi Unuttum";
            lnkSifremiUnuttum.LinkClicked += lnkSifremiUnuttum_LinkClicked;
            // 
            // lnkKayitOl
            // 
            lnkKayitOl.AutoSize = true;
            lnkKayitOl.LinkColor = SystemColors.ControlDarkDark;
            lnkKayitOl.Location = new Point(311, 254);
            lnkKayitOl.Name = "lnkKayitOl";
            lnkKayitOl.Size = new Size(82, 28);
            lnkKayitOl.TabIndex = 5;
            lnkKayitOl.TabStop = true;
            lnkKayitOl.Text = "Kayıt Ol";
            lnkKayitOl.LinkClicked += lnkKayitOl_LinkClicked;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.FromArgb(52, 73, 94);
            btnGirisYap.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnGirisYap.ForeColor = SystemColors.ButtonHighlight;
            btnGirisYap.Location = new Point(43, 143);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(350, 57);
            btnGirisYap.TabIndex = 3;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(254, 31);
            label3.Name = "label3";
            label3.Size = new Size(498, 59);
            label3.TabIndex = 3;
            label3.Text = "Dijital Kütüphane";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(383, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 82);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(929, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 42);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // GirisSayfasi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 176, 190);
            ClientSize = new Size(986, 640);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "GirisSayfasi";
            Text = "GirisSayfasi";
            Load += GirisSayfasi_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtKullaniciAdi;
        private Label label2;
        private TextBox txtSifre;
        private GroupBox groupBox1;
        private Button btnGirisYap;
        private LinkLabel lnkSifremiUnuttum;
        private LinkLabel lnkKayitOl;
        private CheckBox chkSifreGoster;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}