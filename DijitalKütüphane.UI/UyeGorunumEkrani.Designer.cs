namespace DijitalKütüphane.UI
{
    partial class UyeGorunumEkrani
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
            button1 = new Button();
            listView1 = new ListView();
            btnGeri = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 73, 94);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(32, 92);
            button1.Name = "button1";
            button1.Size = new Size(204, 83);
            button1.TabIndex = 0;
            button1.Text = "Kitaplarım";
            button1.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(272, 92);
            listView1.Name = "listView1";
            listView1.Size = new Size(1232, 674);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(52, 73, 94);
            btnGeri.ForeColor = SystemColors.ButtonHighlight;
            btnGeri.Location = new Point(32, 12);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(75, 40);
            btnGeri.TabIndex = 7;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = false;
            // 
            // UyeGorunumEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 176, 190);
            ClientSize = new Size(1771, 839);
            Controls.Add(btnGeri);
            Controls.Add(listView1);
            Controls.Add(button1);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "UyeGorunumEkrani";
            Text = "UyeGorunumEkrani";
            Load += UyeGorunumEkrani_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListView listView1;
        private Button btnGeri;
    }
}