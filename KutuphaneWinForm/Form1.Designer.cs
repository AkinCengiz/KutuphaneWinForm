namespace KutuphaneWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnYazarIslemleri = new Button();
            btnKitapIslemleri = new Button();
            SuspendLayout();
            // 
            // btnYazarIslemleri
            // 
            btnYazarIslemleri.BackColor = Color.FromArgb(192, 0, 0);
            btnYazarIslemleri.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYazarIslemleri.ForeColor = Color.White;
            btnYazarIslemleri.Location = new Point(15, 17);
            btnYazarIslemleri.Margin = new Padding(4);
            btnYazarIslemleri.Name = "btnYazarIslemleri";
            btnYazarIslemleri.Size = new Size(150, 105);
            btnYazarIslemleri.TabIndex = 0;
            btnYazarIslemleri.Text = "Yazar İşlemleri";
            btnYazarIslemleri.UseVisualStyleBackColor = false;
            btnYazarIslemleri.Click += btnYazarIslemleri_Click;
            // 
            // btnKitapIslemleri
            // 
            btnKitapIslemleri.BackColor = Color.Black;
            btnKitapIslemleri.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKitapIslemleri.ForeColor = Color.White;
            btnKitapIslemleri.Location = new Point(173, 17);
            btnKitapIslemleri.Margin = new Padding(4);
            btnKitapIslemleri.Name = "btnKitapIslemleri";
            btnKitapIslemleri.Size = new Size(150, 105);
            btnKitapIslemleri.TabIndex = 1;
            btnKitapIslemleri.Text = "Kitap İşlemleri";
            btnKitapIslemleri.UseVisualStyleBackColor = false;
            btnKitapIslemleri.Click += btnKitapIslemleri_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 496);
            Controls.Add(btnKitapIslemleri);
            Controls.Add(btnYazarIslemleri);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnYazarIslemleri;
        private Button btnKitapIslemleri;
    }
}
