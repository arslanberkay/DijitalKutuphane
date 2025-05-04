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
            groupBox1.Location = new Point(50, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 142);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kategori İşlemleri";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(119, 78);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(179, 31);
            txtAciklama.TabIndex = 1;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(119, 41);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(179, 31);
            txtAd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 83);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 0;
            label2.Text = "Açıklama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 41);
            label1.Name = "label1";
            label1.Size = new Size(35, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // dgvKategoriler
            // 
            dgvKategoriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvKategoriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKategoriler.Location = new Point(50, 258);
            dgvKategoriler.Name = "dgvKategoriler";
            dgvKategoriler.RowHeadersWidth = 51;
            dgvKategoriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKategoriler.Size = new Size(1161, 381);
            dgvKategoriler.TabIndex = 1;
            dgvKategoriler.CellClick += dgvKategoriler_CellClick;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(70, 188);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(130, 45);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(206, 188);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(130, 45);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(342, 188);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(130, 45);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(478, 188);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(118, 45);
            btnTemizle.TabIndex = 2;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // KategoriIslemEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 710);
            Controls.Add(btnTemizle);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dgvKategoriler);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "KategoriIslemEkrani";
            Text = "KategoriIslemEkrani";
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
    }
}