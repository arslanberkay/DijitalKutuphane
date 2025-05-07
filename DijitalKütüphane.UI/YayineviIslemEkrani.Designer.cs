namespace DijitalKütüphane.UI
{
    partial class YayineviIslemEkrani
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
            mtxtTelefon = new MaskedTextBox();
            txtUlke = new TextBox();
            txtAdres = new TextBox();
            txtSehir = new TextBox();
            txtYayineviAdi = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvYayinEvleri = new DataGridView();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnTemizle = new Button();
            btnGeri = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvYayinEvleri).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mtxtTelefon);
            groupBox1.Controls.Add(txtUlke);
            groupBox1.Controls.Add(txtAdres);
            groupBox1.Controls.Add(txtSehir);
            groupBox1.Controls.Add(txtYayineviAdi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(91, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 295);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yayınevi İşlemleri";
            // 
            // mtxtTelefon
            // 
            mtxtTelefon.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            mtxtTelefon.Location = new Point(120, 79);
            mtxtTelefon.Mask = "(999) 000-0000";
            mtxtTelefon.Name = "mtxtTelefon";
            mtxtTelefon.Size = new Size(277, 32);
            mtxtTelefon.TabIndex = 1;
            // 
            // txtUlke
            // 
            txtUlke.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtUlke.Location = new Point(120, 159);
            txtUlke.Name = "txtUlke";
            txtUlke.Size = new Size(277, 32);
            txtUlke.TabIndex = 3;
            // 
            // txtAdres
            // 
            txtAdres.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtAdres.Location = new Point(120, 197);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(277, 77);
            txtAdres.TabIndex = 4;
            // 
            // txtSehir
            // 
            txtSehir.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtSehir.Location = new Point(120, 119);
            txtSehir.Name = "txtSehir";
            txtSehir.Size = new Size(277, 32);
            txtSehir.TabIndex = 2;
            // 
            // txtYayineviAdi
            // 
            txtYayineviAdi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtYayineviAdi.Location = new Point(120, 39);
            txtYayineviAdi.Name = "txtYayineviAdi";
            txtYayineviAdi.Size = new Size(277, 32);
            txtYayineviAdi.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F);
            label5.Location = new Point(31, 197);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 0;
            label5.Text = "Adres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F);
            label4.Location = new Point(31, 159);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 0;
            label4.Text = "Ülke";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F);
            label3.Location = new Point(31, 121);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 0;
            label3.Text = "Şehir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F);
            label2.Location = new Point(31, 83);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 0;
            label2.Text = "Telefon";
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
            // dgvYayinEvleri
            // 
            dgvYayinEvleri.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dgvYayinEvleri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvYayinEvleri.BackgroundColor = Color.FromArgb(164, 176, 190);
            dgvYayinEvleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYayinEvleri.Location = new Point(91, 441);
            dgvYayinEvleri.Name = "dgvYayinEvleri";
            dgvYayinEvleri.RowHeadersWidth = 51;
            dgvYayinEvleri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYayinEvleri.Size = new Size(1154, 305);
            dgvYayinEvleri.TabIndex = 1;
            dgvYayinEvleri.CellClick += dgvYayinEvleri_CellClick;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(52, 73, 94);
            btnEkle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnEkle.ForeColor = SystemColors.ButtonHighlight;
            btnEkle.Location = new Point(91, 373);
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
            btnSil.Location = new Point(227, 373);
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
            btnGuncelle.Location = new Point(363, 373);
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
            btnTemizle.Location = new Point(499, 373);
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
            // YayineviIslemEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 176, 190);
            ClientSize = new Size(1296, 802);
            Controls.Add(btnGeri);
            Controls.Add(btnTemizle);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dgvYayinEvleri);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = Color.Black;
            Margin = new Padding(4);
            Name = "YayineviIslemEkrani";
            Text = "YayineviIslemEkrani";
            WindowState = FormWindowState.Maximized;
            Load += YayineviIslemEkrani_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvYayinEvleri).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox mtxtTelefon;
        private TextBox txtUlke;
        private TextBox txtAdres;
        private TextBox txtSehir;
        private TextBox txtYayineviAdi;
        private Label label5;
        private DataGridView dgvYayinEvleri;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnTemizle;
        private Button btnGeri;
    }
}