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
            btnGeri = new Button();
            SuspendLayout();
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(2, 1);
            btnGeri.Margin = new Padding(4, 4, 4, 4);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(80, 45);
            btnGeri.TabIndex = 6;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // UyeGorunumEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnGeri);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 4, 4, 4);
            Name = "UyeGorunumEkrani";
            Text = "UyeGorunumEkrani";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGeri;
    }
}