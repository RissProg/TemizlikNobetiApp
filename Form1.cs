namespace TemizlikNobetiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            KayitYoneticisi.Yukle();

            cbSinif.DisplayMember = "Ad";
            cbSinif.DataSource = KayitYoneticisi.Siniflar;
        }

        private void btnYeniSinif_Click(object sender, EventArgs e)
        {
            FrmYeniSinif form = new();
            var cevap = form.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                MessageBox.Show("Yeni Sýnýf kayýt edildi.");
            }
        }
    }
}