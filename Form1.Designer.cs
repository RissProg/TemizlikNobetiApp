namespace TemizlikNobetiApp
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
            cbSinif = new ComboBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnOgrenciEkle = new Button();
            label1 = new Label();
            btnYeniSinif = new Button();
            lbOgrenciler = new ListBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            lbSecilenler = new ListBox();
            btnOnayla = new Button();
            label2 = new Label();
            btnAta = new Button();
            btnCikar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // cbSinif
            // 
            cbSinif.FormattingEnabled = true;
            cbSinif.Location = new Point(3, 108);
            cbSinif.Name = "cbSinif";
            cbSinif.Size = new Size(194, 25);
            cbSinif.TabIndex = 0;
            cbSinif.SelectedValueChanged += cbSinif_SelectedValueChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnOgrenciEkle);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnYeniSinif);
            panel1.Controls.Add(lbOgrenciler);
            panel1.Controls.Add(cbSinif);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 426);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cleaning;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnOgrenciEkle
            // 
            btnOgrenciEkle.BackColor = Color.FromArgb(255, 192, 128);
            btnOgrenciEkle.Cursor = Cursors.Hand;
            btnOgrenciEkle.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnOgrenciEkle.Location = new Point(101, 378);
            btnOgrenciEkle.Name = "btnOgrenciEkle";
            btnOgrenciEkle.Size = new Size(96, 45);
            btnOgrenciEkle.TabIndex = 4;
            btnOgrenciEkle.Text = "Öğrenci Ekle";
            btnOgrenciEkle.UseVisualStyleBackColor = false;
            btnOgrenciEkle.Click += btnOgrenciEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(48, 82);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 3;
            label1.Text = "Siniflar";
            // 
            // btnYeniSinif
            // 
            btnYeniSinif.BackColor = Color.FromArgb(255, 192, 128);
            btnYeniSinif.Cursor = Cursors.Hand;
            btnYeniSinif.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnYeniSinif.Location = new Point(0, 378);
            btnYeniSinif.Name = "btnYeniSinif";
            btnYeniSinif.Size = new Size(95, 45);
            btnYeniSinif.TabIndex = 2;
            btnYeniSinif.Text = "Sinif Ekle";
            btnYeniSinif.UseVisualStyleBackColor = false;
            btnYeniSinif.Click += btnYeniSinif_Click;
            // 
            // lbOgrenciler
            // 
            lbOgrenciler.FormattingEnabled = true;
            lbOgrenciler.ItemHeight = 17;
            lbOgrenciler.Location = new Point(3, 144);
            lbOgrenciler.Name = "lbOgrenciler";
            lbOgrenciler.Size = new Size(194, 225);
            lbOgrenciler.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 128);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnAta);
            panel2.Controls.Add(btnCikar);
            panel2.Location = new Point(257, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 400);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.broom;
            pictureBox2.Location = new Point(167, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(162, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 255, 192);
            panel3.Controls.Add(lbSecilenler);
            panel3.Controls.Add(btnOnayla);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(18, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(460, 278);
            panel3.TabIndex = 1;
            // 
            // lbSecilenler
            // 
            lbSecilenler.FormattingEnabled = true;
            lbSecilenler.ItemHeight = 17;
            lbSecilenler.Location = new Point(59, 50);
            lbSecilenler.Name = "lbSecilenler";
            lbSecilenler.Size = new Size(331, 157);
            lbSecilenler.TabIndex = 3;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.FromArgb(255, 192, 192);
            btnOnayla.Cursor = Cursors.Hand;
            btnOnayla.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnOnayla.ImageAlign = ContentAlignment.BottomCenter;
            btnOnayla.Location = new Point(235, 215);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(155, 33);
            btnOnayla.TabIndex = 2;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(59, 11);
            label2.Name = "label2";
            label2.Size = new Size(330, 23);
            label2.TabIndex = 0;
            label2.Text = "Bu Hafta Temizlik Yapacaklar";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAta
            // 
            btnAta.BackColor = Color.FromArgb(255, 192, 192);
            btnAta.Cursor = Cursors.Hand;
            btnAta.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAta.Location = new Point(335, 13);
            btnAta.Name = "btnAta";
            btnAta.Size = new Size(143, 48);
            btnAta.TabIndex = 0;
            btnAta.Text = "Ata -->";
            btnAta.UseVisualStyleBackColor = false;
            btnAta.Click += btnAta_Click;
            // 
            // btnCikar
            // 
            btnCikar.BackColor = Color.FromArgb(255, 224, 192);
            btnCikar.Cursor = Cursors.Hand;
            btnCikar.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCikar.Location = new Point(18, 13);
            btnCikar.Name = "btnCikar";
            btnCikar.Size = new Size(143, 48);
            btnCikar.TabIndex = 0;
            btnCikar.Text = "<-- Çıkar";
            btnCikar.UseVisualStyleBackColor = false;
            btnCikar.Click += btnCikar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Temizlik Nobeti App";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbSinif;
        private Panel panel1;
        private ListBox lbOgrenciler;
        private Button btnYeniSinif;
        private Label label1;
        private Panel panel2;
        private Button btnAta;
        private Button btnCikar;
        private Panel panel3;
        private ListBox lbSecilenler;
        private Button btnOnayla;
        private Label label2;
        private Button btnOgrenciEkle;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}