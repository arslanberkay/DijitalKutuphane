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
            grpKullaniciGirisi.Controls.Add(btnGirisYap);
            grpKullaniciGirisi.Controls.Add(label2);
            grpKullaniciGirisi.Controls.Add(txtSifre);
            grpKullaniciGirisi.Controls.Add(txtKullaniciAdi);
            grpKullaniciGirisi.Controls.Add(label1);
            grpKullaniciGirisi.Location = new Point(42, 176);
            grpKullaniciGirisi.Margin = new Padding(4);
            grpKullaniciGirisi.Name = "grpKullaniciGirisi";
            grpKullaniciGirisi.Padding = new Padding(4);
            grpKullaniciGirisi.Size = new Size(370, 258);
            grpKullaniciGirisi.TabIndex = 0;
            grpKullaniciGirisi.TabStop = false;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(18, 164);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(322, 55);
            btnGirisYap.TabIndex = 3;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 107);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 2;
            label2.Text = "Şifre";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(141, 101);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(199, 34);
            txtSifre.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(141, 49);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(199, 34);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._285655_user_icon;
            pictureBox1.Location = new Point(93, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(255, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // KullaniciGirisEkrani
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 476);
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
