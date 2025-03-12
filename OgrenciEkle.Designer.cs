namespace TemizlikNobetiApp
{
    partial class OgrenciEkle
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
            label1 = new Label();
            panel1 = new Panel();
            cbSinif = new ComboBox();
            mtbNumara = new MaskedTextBox();
            button1 = new Button();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(50, 3);
            label1.Name = "label1";
            label1.Size = new Size(146, 23);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Ekle";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(cbSinif);
            panel1.Controls.Add(mtbNumara);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtSoyad);
            panel1.Controls.Add(txtAd);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 255);
            panel1.TabIndex = 1;
            // 
            // cbSinif
            // 
            cbSinif.FormattingEnabled = true;
            cbSinif.Location = new Point(116, 163);
            cbSinif.Name = "cbSinif";
            cbSinif.Size = new Size(131, 25);
            cbSinif.TabIndex = 4;
            // 
            // mtbNumara
            // 
            mtbNumara.Location = new Point(116, 195);
            mtbNumara.Mask = "00000";
            mtbNumara.Name = "mtbNumara";
            mtbNumara.Size = new Size(127, 25);
            mtbNumara.TabIndex = 3;
            mtbNumara.ValidatingType = typeof(int);
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(116, 222);
            button1.Name = "button1";
            button1.Size = new Size(128, 30);
            button1.TabIndex = 2;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(116, 133);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(128, 25);
            txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(116, 102);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(128, 25);
            txtAd.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(5, 195);
            label6.Name = "label6";
            label6.Size = new Size(110, 23);
            label6.TabIndex = 0;
            label6.Text = "Numara :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(5, 165);
            label5.Name = "label5";
            label5.Size = new Size(75, 23);
            label5.TabIndex = 0;
            label5.Text = "Sinif :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(5, 132);
            label4.Name = "label4";
            label4.Size = new Size(90, 23);
            label4.TabIndex = 0;
            label4.Text = "Soyad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(8, 100);
            label3.Name = "label3";
            label3.Size = new Size(53, 23);
            label3.TabIndex = 0;
            label3.Text = "Ad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(8, 41);
            label2.Name = "label2";
            label2.Size = new Size(184, 23);
            label2.TabIndex = 0;
            label2.Text = "Öğrenci Bilgileri";
            // 
            // OgrenciEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 276);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OgrenciEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OgrenciEkle";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox txtSinif;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private MaskedTextBox mtbNumara;
        private ComboBox cbSinif;
    }
}