namespace DijitalKütüphane.UI
{
    partial class KullaniciGirisEkrani
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpKullaniciGirisi = new GroupBox();
            btnGirisYap = new Button();
            label2 = new Label();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            grpKullaniciGirisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grpKullaniciGirisi
            // 
            grpKullaniciGirisi.Controls.Add(label2);
            grpKullaniciGirisi.Controls.Add(txtSifre);
            grpKullaniciGirisi.Controls.Add(txtKullaniciAdi);
            grpKullaniciGirisi.Controls.Add(label1);
            grpKullaniciGirisi.Location = new Point(48, 184);
            grpKullaniciGirisi.Margin = new Padding(4);
            grpKullaniciGirisi.Name = "grpKullaniciGirisi";
            grpKullaniciGirisi.Padding = new Padding(4);
            grpKullaniciGirisi.Size = new Size(350, 123);
            grpKullaniciGirisi.TabIndex = 0;
            grpKullaniciGirisi.TabStop = false;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.SteelBlue;
            btnGirisYap.ForeColor = Color.White;
            btnGirisYap.Location = new Point(57, 314);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(322, 55);
            btnGirisYap.TabIndex = 2;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(11, 75);
            label2.Name = "label2";
            label2.Size = new Size(56, 28);
            label2.TabIndex = 0;
            label2.Text = "Şifre";
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.White;
            txtSifre.ForeColor = Color.Black;
            txtSifre.Location = new Point(156, 72);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(183, 34);
            txtSifre.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = Color.White;
            txtKullaniciAdi.ForeColor = Color.Black;
            txtKullaniciAdi.Location = new Point(156, 28);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(183, 34);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(11, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 28);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._9034845_library_icon;
            pictureBox1.Location = new Point(150, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // KullaniciGirisEkrani
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(439, 418);
            Controls.Add(btnGirisYap);
            Controls.Add(pictureBox1);
            Controls.Add(grpKullaniciGirisi);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "KullaniciGirisEkrani";
            Text = "Kullanıcı Giriş";
            Load += Form1_Load;
            grpKullaniciGirisi.ResumeLayout(false);
            grpKullaniciGirisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpKullaniciGirisi;
        private Button btnGirisYap;
        private Label label2;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
