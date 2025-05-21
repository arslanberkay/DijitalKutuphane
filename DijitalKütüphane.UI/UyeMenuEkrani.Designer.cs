namespace DijitalKütüphane.UI
{
    partial class UyeMenuEkrani
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
            btnKitapOduncAl = new Button();
            btnKitaplarim = new Button();
            SuspendLayout();
            // 
            // btnKitapOduncAl
            // 
            btnKitapOduncAl.BackColor = Color.FromArgb(52, 73, 94);
            btnKitapOduncAl.FlatStyle = FlatStyle.Popup;
            btnKitapOduncAl.ForeColor = SystemColors.ButtonHighlight;
            btnKitapOduncAl.Location = new Point(399, 154);
            btnKitapOduncAl.Name = "btnKitapOduncAl";
            btnKitapOduncAl.Size = new Size(260, 115);
            btnKitapOduncAl.TabIndex = 3;
            btnKitapOduncAl.Text = "Kitap Ödünç Al";
            btnKitapOduncAl.UseVisualStyleBackColor = false;
            btnKitapOduncAl.Click += btnKitapOduncAl_Click;
            // 
            // btnKitaplarim
            // 
            btnKitaplarim.BackColor = Color.FromArgb(52, 73, 94);
            btnKitaplarim.FlatStyle = FlatStyle.Popup;
            btnKitaplarim.ForeColor = SystemColors.ButtonHighlight;
            btnKitaplarim.Location = new Point(399, 308);
            btnKitaplarim.Name = "btnKitaplarim";
            btnKitaplarim.Size = new Size(260, 115);
            btnKitaplarim.TabIndex = 3;
            btnKitaplarim.Text = "Kitaplarım";
            btnKitaplarim.UseVisualStyleBackColor = false;
            btnKitaplarim.Click += btnKitaplarim_Click;
            // 
            // UyeMenuEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 176, 190);
            ClientSize = new Size(1178, 672);
            Controls.Add(btnKitaplarim);
            Controls.Add(btnKitapOduncAl);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "UyeMenuEkrani";
            Text = "UyeMenuEkrani";
            ResumeLayout(false);
        }

        #endregion

        private Button btnKitapOduncAl;
        private Button btnKitaplarim;
    }
}