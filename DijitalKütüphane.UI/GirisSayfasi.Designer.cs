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
            btnGirisYap = new Button();
            lnkKayitOl = new LinkLabel();
            lnkSifremiUnuttum = new LinkLabel();
            chkSifreGoster = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.Location = new Point(42, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtKullaniciAdi.Location = new Point(179, 57);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(213, 32);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.Location = new Point(42, 107);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 0;
            label2.Text = "Şifre";
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtSifre.Location = new Point(179, 104);
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
            groupBox1.Location = new Point(269, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(498, 334);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.FromArgb(52, 73, 94);
            btnGirisYap.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnGirisYap.ForeColor = SystemColors.ButtonHighlight;
            btnGirisYap.Location = new Point(42, 156);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(350, 57);
            btnGirisYap.TabIndex = 2;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            // 
            // lnkKayitOl
            // 
            lnkKayitOl.AutoSize = true;
            lnkKayitOl.LinkColor = SystemColors.ControlDarkDark;
            lnkKayitOl.Location = new Point(310, 267);
            lnkKayitOl.Name = "lnkKayitOl";
            lnkKayitOl.Size = new Size(82, 28);
            lnkKayitOl.TabIndex = 3;
            lnkKayitOl.TabStop = true;
            lnkKayitOl.Text = "Kayıt Ol";
            // 
            // lnkSifremiUnuttum
            // 
            lnkSifremiUnuttum.AutoSize = true;
            lnkSifremiUnuttum.LinkColor = SystemColors.ControlDarkDark;
            lnkSifremiUnuttum.Location = new Point(42, 267);
            lnkSifremiUnuttum.Name = "lnkSifremiUnuttum";
            lnkSifremiUnuttum.Size = new Size(164, 28);
            lnkSifremiUnuttum.TabIndex = 3;
            lnkSifremiUnuttum.TabStop = true;
            lnkSifremiUnuttum.Text = "Şifremi Unuttum";
            // 
            // chkSifreGoster
            // 
            chkSifreGoster.AutoSize = true;
            chkSifreGoster.Location = new Point(398, 107);
            chkSifreGoster.Name = "chkSifreGoster";
            chkSifreGoster.Size = new Size(94, 32);
            chkSifreGoster.TabIndex = 4;
            chkSifreGoster.Text = "Göster";
            chkSifreGoster.UseVisualStyleBackColor = true;
            // 
            // GirisSayfasi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 176, 190);
            ClientSize = new Size(1042, 657);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 4, 4, 4);
            Name = "GirisSayfasi";
            Text = "GirisSayfasi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}