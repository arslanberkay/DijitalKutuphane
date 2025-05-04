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
            SuspendLayout();
            // 
            // btnUyeGorunumu
            // 
            btnUyeGorunumu.Location = new Point(373, 390);
            btnUyeGorunumu.Name = "btnUyeGorunumu";
            btnUyeGorunumu.Size = new Size(193, 70);
            btnUyeGorunumu.TabIndex = 1;
            btnUyeGorunumu.Text = "Üye Görünümü";
            btnUyeGorunumu.UseVisualStyleBackColor = true;
            btnUyeGorunumu.Click += btnUyeGorunumu_Click;
            // 
            // btnUyeIslemleri
            // 
            btnUyeIslemleri.Location = new Point(373, 314);
            btnUyeIslemleri.Name = "btnUyeIslemleri";
            btnUyeIslemleri.Size = new Size(193, 70);
            btnUyeIslemleri.TabIndex = 2;
            btnUyeIslemleri.Text = "Üye İşlemleri";
            btnUyeIslemleri.UseVisualStyleBackColor = true;
            btnUyeIslemleri.Click += btnUyeIslemleri_Click;
            // 
            // btnYayineviIslemleri
            // 
            btnYayineviIslemleri.Location = new Point(373, 238);
            btnYayineviIslemleri.Name = "btnYayineviIslemleri";
            btnYayineviIslemleri.Size = new Size(193, 70);
            btnYayineviIslemleri.TabIndex = 3;
            btnYayineviIslemleri.Text = "Yayınevi İşlemleri";
            btnYayineviIslemleri.UseVisualStyleBackColor = true;
            btnYayineviIslemleri.Click += btnYayineviIslemleri_Click;
            // 
            // btnKitapIslemleri
            // 
            btnKitapIslemleri.Location = new Point(373, 162);
            btnKitapIslemleri.Name = "btnKitapIslemleri";
            btnKitapIslemleri.Size = new Size(193, 70);
            btnKitapIslemleri.TabIndex = 4;
            btnKitapIslemleri.Text = "Kitap İşlemleri";
            btnKitapIslemleri.UseVisualStyleBackColor = true;
            btnKitapIslemleri.Click += btnKitapIslemleri_Click;
            // 
            // btnKategoriIslemleri
            // 
            btnKategoriIslemleri.Location = new Point(373, 86);
            btnKategoriIslemleri.Name = "btnKategoriIslemleri";
            btnKategoriIslemleri.Size = new Size(193, 70);
            btnKategoriIslemleri.TabIndex = 5;
            btnKategoriIslemleri.Text = "Kategori İşlemleri";
            btnKategoriIslemleri.UseVisualStyleBackColor = true;
            btnKategoriIslemleri.Click += btnKategoriIslemleri_Click;
            // 
            // AdminMenuEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 564);
            Controls.Add(btnUyeGorunumu);
            Controls.Add(btnUyeIslemleri);
            Controls.Add(btnYayineviIslemleri);
            Controls.Add(btnKitapIslemleri);
            Controls.Add(btnKategoriIslemleri);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 4, 4, 4);
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
    }
}