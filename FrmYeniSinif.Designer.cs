namespace TemizlikNobetiApp
{
    partial class FrmYeniSinif
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
            label2 = new Label();
            txtSinifEkle = new TextBox();
            lblSinifAdi = new Label();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(58, 9);
            label2.Name = "label2";
            label2.Size = new Size(158, 42);
            label2.TabIndex = 0;
            label2.Text = "Sinif Ekle";
            // 
            // txtSinifEkle
            // 
            txtSinifEkle.Location = new Point(155, 58);
            txtSinifEkle.Name = "txtSinifEkle";
            txtSinifEkle.Size = new Size(120, 25);
            txtSinifEkle.TabIndex = 1;
            // 
            // lblSinifAdi
            // 
            lblSinifAdi.AutoSize = true;
            lblSinifAdi.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSinifAdi.Location = new Point(12, 55);
            lblSinifAdi.Name = "lblSinifAdi";
            lblSinifAdi.Size = new Size(136, 25);
            lblSinifAdi.TabIndex = 2;
            lblSinifAdi.Text = "Sinif Ekle :";
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnKaydet.Location = new Point(155, 89);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(120, 40);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // FrmYeniSinif
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(286, 156);
            Controls.Add(btnKaydet);
            Controls.Add(lblSinifAdi);
            Controls.Add(txtSinifEkle);
            Controls.Add(label2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmYeniSinif";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmYeniSinif";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtSinifEkle;
        private Label lblSinifAdi;
        private Button btnKaydet;
    }
}