using System.ComponentModel;

namespace TemizlikNobetiApp
{
    public partial class Form1 : Form
    {

        BindingList<Ogrenci> SeciliOgrenciListesi = new();

        public Form1()
        {
            InitializeComponent();


            KayitYoneticisi.Yukle();

            cbSinif.DisplayMember = "Ad";
            cbSinif.ValueMember = "Id";
            cbSinif.DataSource = KayitYoneticisi.Siniflar;

            lbOgrenciler.DisplayMember = "AdSoyad";
            lbOgrenciler.ValueMember = "Id";
            lbOgrenciler.DataSource = KayitYoneticisi.Ogrenciler;


            lbSecilenler.DisplayMember = "AdSoyad";
            lbSecilenler.ValueMember = "Id";
            lbSecilenler.DataSource = SeciliOgrenciListesi;


            Filtrele();
        }


        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            OgrenciEkle form = new();
            var cevap = form.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                MessageBox.Show("Yeni Ogrenci kayıt edildi.");

            }
        }


        private void Filtrele()
        {
            if (cbSinif.SelectedValue == null)
            {
                //Sýnýf seçili deðilse
                lbOgrenciler.DataSource = null;
                return;
            }

            //Sýnýf seçili
            string sinifId = cbSinif.SelectedValue.ToString();

            //LINQ ile sorgulama
            //Lambda x => x.....
            var liste = KayitYoneticisi.
                Ogrenciler.Where(x => x.SinifId == sinifId).ToList();

            lbOgrenciler.DisplayMember = "AdSoyad";
            lbOgrenciler.ValueMember = "Id";
            lbOgrenciler.DataSource = liste;
        }

        private void cbSinif_SelectedValueChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void btnYeniSinif_Click(object sender, EventArgs e)
        {
            FrmYeniSinif form = new();
            var cevap = form.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                MessageBox.Show("Yeni Sinif kayit edildi.");
            }
        }

        private void btnAta_Click(object sender, EventArgs e)
        {
            //Seçili olaný öðrenci gibi al (as=gibi)
            //Alamazsan null deðer ver
            Ogrenci ogr = lbOgrenciler.SelectedItem as Ogrenci;

            if (ogr != null)
            {

                if (SeciliOgrenciListesi.Contains(ogr))
                {
                    MessageBox.Show("Öðrenci zaten seçili");
                    return;
                }

                SeciliOgrenciListesi.Add(ogr);
            }

        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            //Seçili olaný öðrenci gibi al (as=gibi)
            //Alamazsan null deðer ver
            Ogrenci ogr = lbSecilenler.SelectedItem as Ogrenci;

            if (ogr != null)
            {
                SeciliOgrenciListesi.Remove(ogr);
            }
        }
    }
}