﻿namespace DijitalKütüphane.UI
{
    partial class YazarIslemEkrani
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
            btnTemizle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            dgvYazarlar = new DataGridView();
            grpYazarIslemleri = new GroupBox();
            txtEmail = new TextBox();
            txtSoyad = new TextBox();
            label3 = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnGeri = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvYazarlar).BeginInit();
            grpYazarIslemleri.SuspendLayout();
            SuspendLayout();
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(52, 73, 94);
            btnTemizle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnTemizle.ForeColor = SystemColors.ButtonHighlight;
            btnTemizle.Location = new Point(477, 227);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(118, 45);
            btnTemizle.TabIndex = 4;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(52, 73, 94);
            btnGuncelle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnGuncelle.ForeColor = SystemColors.ButtonHighlight;
            btnGuncelle.Location = new Point(341, 227);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(130, 45);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(52, 73, 94);
            btnSil.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnSil.ForeColor = SystemColors.ButtonHighlight;
            btnSil.Location = new Point(205, 227);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(130, 45);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(52, 73, 94);
            btnEkle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnEkle.ForeColor = SystemColors.ButtonHighlight;
            btnEkle.Location = new Point(69, 227);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(130, 45);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvYazarlar
            // 
            dgvYazarlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvYazarlar.BackgroundColor = Color.FromArgb(164, 176, 190);
            dgvYazarlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYazarlar.Location = new Point(49, 297);
            dgvYazarlar.Name = "dgvYazarlar";
            dgvYazarlar.RowHeadersWidth = 51;
            dgvYazarlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYazarlar.Size = new Size(1161, 381);
            dgvYazarlar.TabIndex = 4;
            dgvYazarlar.CellClick += dgvYazarlar_CellClick;
            // 
            // grpYazarIslemleri
            // 
            grpYazarIslemleri.Controls.Add(txtEmail);
            grpYazarIslemleri.Controls.Add(txtSoyad);
            grpYazarIslemleri.Controls.Add(label3);
            grpYazarIslemleri.Controls.Add(txtAd);
            grpYazarIslemleri.Controls.Add(label2);
            grpYazarIslemleri.Controls.Add(label1);
            grpYazarIslemleri.Location = new Point(49, 39);
            grpYazarIslemleri.Name = "grpYazarIslemleri";
            grpYazarIslemleri.Size = new Size(370, 160);
            grpYazarIslemleri.TabIndex = 0;
            grpYazarIslemleri.TabStop = false;
            grpYazarIslemleri.Text = "Yazar İşlemleri";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(119, 115);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 31);
            txtEmail.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(119, 78);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(179, 31);
            txtSoyad.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 120);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(119, 41);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(179, 31);
            txtAd.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 83);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 0;
            label2.Text = "Soyad";
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
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(52, 73, 94);
            btnGeri.ForeColor = SystemColors.ButtonHighlight;
            btnGeri.Location = new Point(12, -3);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(64, 36);
            btnGeri.TabIndex = 5;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // YazarIslemEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 176, 190);
            ClientSize = new Size(1308, 792);
            Controls.Add(btnGeri);
            Controls.Add(btnTemizle);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dgvYazarlar);
            Controls.Add(grpYazarIslemleri);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "YazarIslemEkrani";
            Text = "YazarIslemEkrani";
            Load += YazarIslemEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)dgvYazarlar).EndInit();
            grpYazarIslemleri.ResumeLayout(false);
            grpYazarIslemleri.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTemizle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private DataGridView dgvYazarlar;
        private GroupBox grpYazarIslemleri;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private Label label3;
        private Button btnGeri;
    }
}