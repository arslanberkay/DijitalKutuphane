namespace DijitalKütüphane.UI
{
    partial class KategoriIslemEkrani
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
            groupBox1 = new GroupBox();
            txtAciklama = new TextBox();
            txtAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvKategoriler = new DataGridView();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnTemizle = new Button();
            btnGeri = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKategoriler).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAciklama);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(90, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(527, 188);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kategori İşlemleri";
            // 
            // txtAciklama
            // 
            txtAciklama.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtAciklama.Location = new Point(131, 82);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(300, 82);
            txtAciklama.TabIndex = 1;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtAd.Location = new Point(131, 45);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(300, 32);
            txtAd.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F);
            label2.Location = new Point(31, 87);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 0;
            label2.Text = "Açıklama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F);
            label1.Location = new Point(31, 45);
            label1.Name = "label1";
            label1.Size = new Size(36, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // dgvKategoriler
            // 
            dgvKategoriler.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dgvKategoriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvKategoriler.BackgroundColor = Color.FromArgb(164, 176, 190);
            dgvKategoriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKategoriler.Location = new Point(90, 338);
            dgvKategoriler.Name = "dgvKategoriler";
            dgvKategoriler.RowHeadersWidth = 51;
            dgvKategoriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKategoriler.Size = new Size(1192, 386);
            dgvKategoriler.TabIndex = 1;
            dgvKategoriler.CellClick += dgvKategoriler_CellClick;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(52, 73, 94);
            btnEkle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnEkle.ForeColor = SystemColors.ButtonHighlight;
            btnEkle.Location = new Point(90, 265);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(125, 50);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(52, 73, 94);
            btnSil.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSil.ForeColor = SystemColors.ButtonHighlight;
            btnSil.Location = new Point(224, 265);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(125, 50);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(52, 73, 94);
            btnGuncelle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnGuncelle.ForeColor = SystemColors.ButtonHighlight;
            btnGuncelle.Location = new Point(358, 265);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(125, 50);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(52, 73, 94);
            btnTemizle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnTemizle.ForeColor = SystemColors.ButtonHighlight;
            btnTemizle.Location = new Point(492, 265);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(125, 50);
            btnTemizle.TabIndex = 4;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(52, 73, 94);
            btnGeri.ForeColor = SystemColors.ButtonHighlight;
            btnGeri.Location = new Point(12, 12);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(75, 40);
            btnGeri.TabIndex = 6;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // KategoriIslemEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 176, 190);
            ClientSize = new Size(1344, 799);
            Controls.Add(btnGeri);
            Controls.Add(btnTemizle);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dgvKategoriler);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "KategoriIslemEkrani";
            Text = "KategoriIslemEkrani";
            WindowState = FormWindowState.Maximized;
            Load += KategoriIslemEkrani_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKategoriler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtAciklama;
        private TextBox txtAd;
        private Label label2;
        private Label label1;
        private DataGridView dgvKategoriler;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnTemizle;
        private Button btnGeri;
    }
}