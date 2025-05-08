namespace DijitalKütüphane.UI
{
    partial class SifreYenilemeEkrani
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
            txtEmail = new TextBox();
            label1 = new Label();
            btnSifirlamaKoduGonder = new Button();
            label2 = new Label();
            grpEpostaGondermeAlani = new GroupBox();
            grpSifirlamaKoduGirmeAlani = new GroupBox();
            mtxtSifirlamaKodu = new MaskedTextBox();
            btnOnayla = new Button();
            label3 = new Label();
            label4 = new Label();
            btnYeniSifreKaydet = new Button();
            txtYeniSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            label5 = new Label();
            label6 = new Label();
            grpSifreYenilemeAlani = new GroupBox();
            txtYeniSifreTekrar = new TextBox();
            label7 = new Label();
            chkYeniSifreTekrarGoster = new CheckBox();
            chkYeniSifreGoster = new CheckBox();
            grpEpostaGondermeAlani.SuspendLayout();
            grpSifirlamaKoduGirmeAlani.SuspendLayout();
            grpSifreYenilemeAlani.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtEmail.Location = new Point(115, 69);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(272, 32);
            txtEmail.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.Location = new Point(37, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // btnSifirlamaKoduGonder
            // 
            btnSifirlamaKoduGonder.BackColor = Color.FromArgb(52, 73, 94);
            btnSifirlamaKoduGonder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSifirlamaKoduGonder.ForeColor = SystemColors.ButtonHighlight;
            btnSifirlamaKoduGonder.Location = new Point(37, 116);
            btnSifirlamaKoduGonder.Name = "btnSifirlamaKoduGonder";
            btnSifirlamaKoduGonder.Size = new Size(350, 57);
            btnSifirlamaKoduGonder.TabIndex = 4;
            btnSifirlamaKoduGonder.Text = "Sıfırlama Kodu Gönder";
            btnSifirlamaKoduGonder.UseVisualStyleBackColor = false;
            btnSifirlamaKoduGonder.Click += btnSifirlamaKoduGonder_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.Location = new Point(37, 30);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(210, 25);
            label2.TabIndex = 2;
            label2.Text = "Şifrenizi mi unuttunuz?";
            // 
            // grpEpostaGondermeAlani
            // 
            grpEpostaGondermeAlani.Controls.Add(btnSifirlamaKoduGonder);
            grpEpostaGondermeAlani.Controls.Add(txtEmail);
            grpEpostaGondermeAlani.Controls.Add(label2);
            grpEpostaGondermeAlani.Controls.Add(label1);
            grpEpostaGondermeAlani.Location = new Point(265, 50);
            grpEpostaGondermeAlani.Name = "grpEpostaGondermeAlani";
            grpEpostaGondermeAlani.Size = new Size(434, 195);
            grpEpostaGondermeAlani.TabIndex = 5;
            grpEpostaGondermeAlani.TabStop = false;
            // 
            // grpSifirlamaKoduGirmeAlani
            // 
            grpSifirlamaKoduGirmeAlani.Controls.Add(mtxtSifirlamaKodu);
            grpSifirlamaKoduGirmeAlani.Controls.Add(btnOnayla);
            grpSifirlamaKoduGirmeAlani.Controls.Add(label3);
            grpSifirlamaKoduGirmeAlani.Controls.Add(label4);
            grpSifirlamaKoduGirmeAlani.Location = new Point(122, 251);
            grpSifirlamaKoduGirmeAlani.Name = "grpSifirlamaKoduGirmeAlani";
            grpSifirlamaKoduGirmeAlani.Size = new Size(754, 134);
            grpSifirlamaKoduGirmeAlani.TabIndex = 5;
            grpSifirlamaKoduGirmeAlani.TabStop = false;
            // 
            // mtxtSifirlamaKodu
            // 
            mtxtSifirlamaKodu.Location = new Point(184, 69);
            mtxtSifirlamaKodu.Mask = "0000";
            mtxtSifirlamaKodu.Name = "mtxtSifirlamaKodu";
            mtxtSifirlamaKodu.Size = new Size(125, 31);
            mtxtSifirlamaKodu.TabIndex = 5;
            mtxtSifirlamaKodu.ValidatingType = typeof(int);
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.FromArgb(52, 73, 94);
            btnOnayla.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnOnayla.ForeColor = SystemColors.ButtonHighlight;
            btnOnayla.Location = new Point(335, 59);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(349, 42);
            btnOnayla.TabIndex = 4;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(37, 30);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(647, 25);
            label3.TabIndex = 2;
            label3.Text = "Lütfen e-posta adresinize gönderilen 4 haneli şifre sıfırlama kodunu giriniz";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.Location = new Point(37, 69);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 2;
            label4.Text = "Sıfırlama Kodu";
            // 
            // btnYeniSifreKaydet
            // 
            btnYeniSifreKaydet.BackColor = Color.FromArgb(52, 73, 94);
            btnYeniSifreKaydet.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnYeniSifreKaydet.ForeColor = SystemColors.ButtonHighlight;
            btnYeniSifreKaydet.Location = new Point(37, 162);
            btnYeniSifreKaydet.Name = "btnYeniSifreKaydet";
            btnYeniSifreKaydet.Size = new Size(377, 57);
            btnYeniSifreKaydet.TabIndex = 10;
            btnYeniSifreKaydet.Text = "Yeni Şifre Kaydet";
            btnYeniSifreKaydet.UseVisualStyleBackColor = false;
            btnYeniSifreKaydet.Click += btnYeniSifreKaydet_Click;
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtYeniSifre.Location = new Point(201, 70);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(213, 32);
            txtYeniSifre.TabIndex = 9;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtKullaniciAdi.Location = new Point(201, 27);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.ReadOnly = true;
            txtKullaniciAdi.Size = new Size(213, 32);
            txtKullaniciAdi.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.Location = new Point(37, 77);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 7;
            label5.Text = "Yeni Şifre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.Location = new Point(37, 30);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 25);
            label6.TabIndex = 8;
            label6.Text = "Kullanıcı Adı";
            // 
            // grpSifreYenilemeAlani
            // 
            grpSifreYenilemeAlani.Controls.Add(chkYeniSifreGoster);
            grpSifreYenilemeAlani.Controls.Add(chkYeniSifreTekrarGoster);
            grpSifreYenilemeAlani.Controls.Add(btnYeniSifreKaydet);
            grpSifreYenilemeAlani.Controls.Add(txtYeniSifreTekrar);
            grpSifreYenilemeAlani.Controls.Add(txtYeniSifre);
            grpSifreYenilemeAlani.Controls.Add(label7);
            grpSifreYenilemeAlani.Controls.Add(txtKullaniciAdi);
            grpSifreYenilemeAlani.Controls.Add(label5);
            grpSifreYenilemeAlani.Controls.Add(label6);
            grpSifreYenilemeAlani.Location = new Point(265, 403);
            grpSifreYenilemeAlani.Name = "grpSifreYenilemeAlani";
            grpSifreYenilemeAlani.Size = new Size(528, 237);
            grpSifreYenilemeAlani.TabIndex = 11;
            grpSifreYenilemeAlani.TabStop = false;
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtYeniSifreTekrar.Location = new Point(201, 108);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.Size = new Size(213, 32);
            txtYeniSifreTekrar.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label7.Location = new Point(37, 115);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(160, 25);
            label7.TabIndex = 7;
            label7.Text = "Yeni Şifre (Tekrar)";
            // 
            // chkYeniSifreTekrarGoster
            // 
            chkYeniSifreTekrarGoster.AutoSize = true;
            chkYeniSifreTekrarGoster.Location = new Point(420, 108);
            chkYeniSifreTekrarGoster.Name = "chkYeniSifreTekrarGoster";
            chkYeniSifreTekrarGoster.Size = new Size(90, 29);
            chkYeniSifreTekrarGoster.TabIndex = 12;
            chkYeniSifreTekrarGoster.Text = "Göster";
            chkYeniSifreTekrarGoster.UseVisualStyleBackColor = true;
            chkYeniSifreTekrarGoster.CheckedChanged += chkYeniSifreTekrarGoster_CheckedChanged;
            // 
            // chkYeniSifreGoster
            // 
            chkYeniSifreGoster.AutoSize = true;
            chkYeniSifreGoster.Location = new Point(420, 77);
            chkYeniSifreGoster.Name = "chkYeniSifreGoster";
            chkYeniSifreGoster.Size = new Size(90, 29);
            chkYeniSifreGoster.TabIndex = 13;
            chkYeniSifreGoster.Text = "Göster";
            chkYeniSifreGoster.UseVisualStyleBackColor = true;
            chkYeniSifreGoster.CheckedChanged += chkYeniSifreGoster_CheckedChanged;
            // 
            // SifreYenilemeEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 176, 190);
            ClientSize = new Size(1033, 708);
            Controls.Add(grpSifreYenilemeAlani);
            Controls.Add(grpSifirlamaKoduGirmeAlani);
            Controls.Add(grpEpostaGondermeAlani);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "SifreYenilemeEkrani";
            Text = "SifreYenilemeEkrani";
            Load += SifreYenilemeEkrani_Load;
            grpEpostaGondermeAlani.ResumeLayout(false);
            grpEpostaGondermeAlani.PerformLayout();
            grpSifirlamaKoduGirmeAlani.ResumeLayout(false);
            grpSifirlamaKoduGirmeAlani.PerformLayout();
            grpSifreYenilemeAlani.ResumeLayout(false);
            grpSifreYenilemeAlani.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtEmail;
        private Label label1;
        private Button btnSifirlamaKoduGonder;
        private Label label2;
        private GroupBox grpEpostaGondermeAlani;
        private GroupBox grpSifirlamaKoduGirmeAlani;
        private MaskedTextBox mtxtSifirlamaKodu;
        private Button btnOnayla;
        private Label label3;
        private Label label4;
        private Button btnYeniSifreKaydet;
        private TextBox txtYeniSifre;
        private TextBox txtKullaniciAdi;
        private Label label5;
        private Label label6;
        private GroupBox grpSifreYenilemeAlani;
        private TextBox txtYeniSifreTekrar;
        private Label label7;
        private CheckBox chkYeniSifreGoster;
        private CheckBox chkYeniSifreTekrarGoster;
    }
}