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
            groupBox1.Location = new Point(47, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 237);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yayınevi İşlemleri";
            // 
            // mtxtTelefon
            // 
            mtxtTelefon.Location = new Point(117, 77);
            mtxtTelefon.Mask = "(999) 000-0000";
            mtxtTelefon.Name = "mtxtTelefon";
            mtxtTelefon.Size = new Size(202, 31);
            mtxtTelefon.TabIndex = 2;
            // 
            // txtUlke
            // 
            txtUlke.Location = new Point(120, 144);
            txtUlke.Name = "txtUlke";
            txtUlke.Size = new Size(199, 31);
            txtUlke.TabIndex = 1;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(120, 179);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(199, 31);
            txtAdres.TabIndex = 1;
            // 
            // txtSehir
            // 
            txtSehir.Location = new Point(120, 109);
            txtSehir.Name = "txtSehir";
            txtSehir.Size = new Size(199, 31);
            txtSehir.TabIndex = 1;
            // 
            // txtYayineviAdi
            // 
            txtYayineviAdi.Location = new Point(120, 39);
            txtYayineviAdi.Name = "txtYayineviAdi";
            txtYayineviAdi.Size = new Size(199, 31);
            txtYayineviAdi.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 181);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 0;
            label5.Text = "Adres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 147);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 0;
            label4.Text = "Ülke";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 113);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 0;
            label3.Text = "Şehir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 79);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 0;
            label2.Text = "Telefon";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 45);
            label1.Name = "label1";
            label1.Size = new Size(35, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // dgvYayinEvleri
            // 
            dgvYayinEvleri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvYayinEvleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYayinEvleri.Location = new Point(47, 329);
            dgvYayinEvleri.Name = "dgvYayinEvleri";
            dgvYayinEvleri.RowHeadersWidth = 51;
            dgvYayinEvleri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYayinEvleri.Size = new Size(1113, 353);
            dgvYayinEvleri.TabIndex = 1;
            dgvYayinEvleri.CellClick += dgvYayinEvleri_CellClick;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(78, 270);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(92, 44);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(176, 270);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(92, 44);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(274, 270);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(99, 44);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(379, 270);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(92, 44);
            btnTemizle.TabIndex = 2;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // YayineviIslemEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 724);
            Controls.Add(btnTemizle);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dgvYayinEvleri);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "YayineviIslemEkrani";
            Text = "YayineviIslemEkrani";
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
    }
}