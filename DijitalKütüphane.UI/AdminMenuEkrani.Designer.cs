namespace DijitalKütüphane.UI
{
    partial class AdminMenuEkrani
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
            btnUyeGorunumu = new Button();
            btnUyeIslemleri = new Button();
            btnYayineviIslemleri = new Button();
            btnKitapIslemleri = new Button();
            btnKategoriIslemleri = new Button();
            btnYazarIslemleri = new Button();
            SuspendLayout();
            // 
            // btnUyeGorunumu
            // 
            btnUyeGorunumu.BackColor = Color.FromArgb(52, 73, 94);
            btnUyeGorunumu.ForeColor = SystemColors.ButtonHighlight;
            btnUyeGorunumu.Location = new Point(834, 466);
            btnUyeGorunumu.Name = "btnUyeGorunumu";
            btnUyeGorunumu.Size = new Size(225, 225);
            btnUyeGorunumu.TabIndex = 5;
            btnUyeGorunumu.Text = "Üye Görünümü";
            btnUyeGorunumu.UseVisualStyleBackColor = false;
            btnUyeGorunumu.Click += btnUyeGorunumu_Click;
            // 
            // btnUyeIslemleri
            // 
            btnUyeIslemleri.BackColor = Color.FromArgb(52, 73, 94);
            btnUyeIslemleri.ForeColor = SystemColors.ButtonHighlight;
            btnUyeIslemleri.Location = new Point(502, 466);
            btnUyeIslemleri.Name = "btnUyeIslemleri";
            btnUyeIslemleri.Size = new Size(225, 225);
            btnUyeIslemleri.TabIndex = 4;
            btnUyeIslemleri.Text = "Üye İşlemleri";
            btnUyeIslemleri.UseVisualStyleBackColor = false;
            btnUyeIslemleri.Click += btnUyeIslemleri_Click;
            // 
            // btnYayineviIslemleri
            // 
            btnYayineviIslemleri.BackColor = Color.FromArgb(52, 73, 94);
            btnYayineviIslemleri.ForeColor = SystemColors.ButtonHighlight;
            btnYayineviIslemleri.Location = new Point(170, 466);
            btnYayineviIslemleri.Name = "btnYayineviIslemleri";
            btnYayineviIslemleri.Size = new Size(225, 225);
            btnYayineviIslemleri.TabIndex = 3;
            btnYayineviIslemleri.Text = "Yayınevi İşlemleri";
            btnYayineviIslemleri.UseVisualStyleBackColor = false;
            btnYayineviIslemleri.Click += btnYayineviIslemleri_Click;
            // 
            // btnKitapIslemleri
            // 
            btnKitapIslemleri.BackColor = Color.FromArgb(52, 73, 94);
            btnKitapIslemleri.ForeColor = SystemColors.ButtonHighlight;
            btnKitapIslemleri.Location = new Point(502, 121);
            btnKitapIslemleri.Name = "btnKitapIslemleri";
            btnKitapIslemleri.Size = new Size(225, 225);
            btnKitapIslemleri.TabIndex = 1;
            btnKitapIslemleri.Text = "Kitap İşlemleri";
            btnKitapIslemleri.UseVisualStyleBackColor = false;
            btnKitapIslemleri.Click += btnKitapIslemleri_Click;
            // 
            // btnKategoriIslemleri
            // 
            btnKategoriIslemleri.BackColor = Color.FromArgb(52, 73, 94);
            btnKategoriIslemleri.ForeColor = SystemColors.ButtonHighlight;
            btnKategoriIslemleri.Location = new Point(170, 114);
            btnKategoriIslemleri.Name = "btnKategoriIslemleri";
            btnKategoriIslemleri.Size = new Size(225, 225);
            btnKategoriIslemleri.TabIndex = 0;
            btnKategoriIslemleri.Text = "Kategori İşlemleri";
            btnKategoriIslemleri.UseVisualStyleBackColor = false;
            btnKategoriIslemleri.Click += btnKategoriIslemleri_Click;
            // 
            // btnYazarIslemleri
            // 
            btnYazarIslemleri.BackColor = Color.FromArgb(52, 73, 94);
            btnYazarIslemleri.ForeColor = SystemColors.ButtonHighlight;
            btnYazarIslemleri.Location = new Point(834, 121);
            btnYazarIslemleri.Name = "btnYazarIslemleri";
            btnYazarIslemleri.Size = new Size(225, 225);
            btnYazarIslemleri.TabIndex = 2;
            btnYazarIslemleri.Text = "Yazar İşlemleri";
            btnYazarIslemleri.UseVisualStyleBackColor = false;
            btnYazarIslemleri.Click += btnYazarIslemleri_Click;
            // 
            // AdminMenuEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 176, 190);
            ClientSize = new Size(1266, 765);
            Controls.Add(btnUyeGorunumu);
            Controls.Add(btnUyeIslemleri);
            Controls.Add(btnYazarIslemleri);
            Controls.Add(btnYayineviIslemleri);
            Controls.Add(btnKitapIslemleri);
            Controls.Add(btnKategoriIslemleri);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "AdminMenuEkrani";
            Text = "AdminMenuEkrani";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUyeGorunumu;
        private Button btnUyeIslemleri;
        private Button btnYayineviIslemleri;
        private Button btnKitapIslemleri;
        private Button btnKategoriIslemleri;
        private Button btnYazarIslemleri;
    }
}