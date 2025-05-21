namespace DijitalKütüphane.UI
{
    partial class UyeKitapOduncIslemEkrani
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
            btnTumKitaplar = new Button();
            button2 = new Button();
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            cbFiltreleme = new ComboBox();
            lstvKitaplar = new ListView();
            btnMusaitOlanKitaplar = new Button();
            btnCokOkunanBesKitap = new Button();
            btnOduncAl = new Button();
            txtFiltreleme = new TextBox();
            SuspendLayout();
            // 
            // btnTumKitaplar
            // 
            btnTumKitaplar.BackColor = Color.FromArgb(52, 73, 94);
            btnTumKitaplar.FlatStyle = FlatStyle.Popup;
            btnTumKitaplar.ForeColor = SystemColors.ButtonHighlight;
            btnTumKitaplar.Location = new Point(1435, 114);
            btnTumKitaplar.Name = "btnTumKitaplar";
            btnTumKitaplar.Size = new Size(204, 83);
            btnTumKitaplar.TabIndex = 1;
            btnTumKitaplar.Text = "Tüm Kitaplar";
            btnTumKitaplar.UseVisualStyleBackColor = false;
            btnTumKitaplar.Click += btnTumKitaplar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(52, 73, 94);
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(38, 114);
            button2.Name = "button2";
            button2.Size = new Size(204, 83);
            button2.TabIndex = 2;
            button2.Text = "Kitap Ara";
            button2.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(52, 73, 94);
            button6.FlatStyle = FlatStyle.Popup;
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(38, 415);
            button6.Name = "button6";
            button6.Size = new Size(204, 83);
            button6.TabIndex = 8;
            button6.Text = "Yayınevine Göre Arama";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(52, 73, 94);
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(38, 313);
            button5.Name = "button5";
            button5.Size = new Size(204, 83);
            button5.TabIndex = 7;
            button5.Text = "Kategoriye Göre Arama";
            button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(52, 73, 94);
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(38, 215);
            button3.Name = "button3";
            button3.Size = new Size(204, 83);
            button3.TabIndex = 6;
            button3.Text = "Yazara Göre Arama";
            button3.UseVisualStyleBackColor = false;
            // 
            // cbFiltreleme
            // 
            cbFiltreleme.FormattingEnabled = true;
            cbFiltreleme.Location = new Point(596, 49);
            cbFiltreleme.Name = "cbFiltreleme";
            cbFiltreleme.Size = new Size(453, 33);
            cbFiltreleme.TabIndex = 9;
            // 
            // lstvKitaplar
            // 
            lstvKitaplar.Location = new Point(310, 114);
            lstvKitaplar.Name = "lstvKitaplar";
            lstvKitaplar.Size = new Size(1059, 563);
            lstvKitaplar.TabIndex = 10;
            lstvKitaplar.UseCompatibleStateImageBehavior = false;
            // 
            // btnMusaitOlanKitaplar
            // 
            btnMusaitOlanKitaplar.BackColor = Color.FromArgb(52, 73, 94);
            btnMusaitOlanKitaplar.FlatStyle = FlatStyle.Popup;
            btnMusaitOlanKitaplar.ForeColor = SystemColors.ButtonHighlight;
            btnMusaitOlanKitaplar.Location = new Point(1435, 321);
            btnMusaitOlanKitaplar.Name = "btnMusaitOlanKitaplar";
            btnMusaitOlanKitaplar.Size = new Size(204, 83);
            btnMusaitOlanKitaplar.TabIndex = 11;
            btnMusaitOlanKitaplar.Text = "Müsait Olan Kitaplar";
            btnMusaitOlanKitaplar.UseVisualStyleBackColor = false;
            // 
            // btnCokOkunanBesKitap
            // 
            btnCokOkunanBesKitap.BackColor = Color.FromArgb(52, 73, 94);
            btnCokOkunanBesKitap.FlatStyle = FlatStyle.Popup;
            btnCokOkunanBesKitap.ForeColor = SystemColors.ButtonHighlight;
            btnCokOkunanBesKitap.Location = new Point(1435, 218);
            btnCokOkunanBesKitap.Name = "btnCokOkunanBesKitap";
            btnCokOkunanBesKitap.Size = new Size(204, 83);
            btnCokOkunanBesKitap.TabIndex = 12;
            btnCokOkunanBesKitap.Text = "Çok Okunan 5 Kitap";
            btnCokOkunanBesKitap.UseVisualStyleBackColor = false;
            // 
            // btnOduncAl
            // 
            btnOduncAl.BackColor = Color.FromArgb(52, 73, 94);
            btnOduncAl.FlatStyle = FlatStyle.Popup;
            btnOduncAl.ForeColor = SystemColors.ButtonHighlight;
            btnOduncAl.Location = new Point(310, 698);
            btnOduncAl.Name = "btnOduncAl";
            btnOduncAl.Size = new Size(1059, 70);
            btnOduncAl.TabIndex = 13;
            btnOduncAl.Text = "Ödünç Al";
            btnOduncAl.UseVisualStyleBackColor = false;
            // 
            // txtFiltreleme
            // 
            txtFiltreleme.Location = new Point(138, 51);
            txtFiltreleme.Name = "txtFiltreleme";
            txtFiltreleme.Size = new Size(452, 31);
            txtFiltreleme.TabIndex = 14;
            // 
            // UyeKitapOduncIslemEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 176, 190);
            ClientSize = new Size(1672, 833);
            Controls.Add(txtFiltreleme);
            Controls.Add(btnOduncAl);
            Controls.Add(btnMusaitOlanKitaplar);
            Controls.Add(btnCokOkunanBesKitap);
            Controls.Add(lstvKitaplar);
            Controls.Add(cbFiltreleme);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnTumKitaplar);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "UyeKitapOduncIslemEkrani";
            Text = "UyeKitapOduncIslemEkrani";
            Load += UyeKitapOduncIslemEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTumKitaplar;
        private Button button2;
        private Button button6;
        private Button button5;
        private Button button3;
        private ComboBox cbFiltreleme;
        private ListView lstvKitaplar;
        private Button btnMusaitOlanKitaplar;
        private Button btnCokOkunanBesKitap;
        private Button btnOduncAl;
        private TextBox txtFiltreleme;
    }
}