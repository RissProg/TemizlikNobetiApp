using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemizlikNobetiApp
{
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();
            cbSinif.DisplayMember = "Ad";
            cbSinif.ValueMember = "Id";//SelectedValue kullanabilmek için
            cbSinif.DataSource = KayitYoneticisi.Siniflar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci yeni = new();
            yeni.Id = Guid.NewGuid().ToString();
            yeni.Ad = txtAd.Text;
            yeni.Soyad = txtSoyad.Text;
            yeni.Numara = Convert.ToInt32(mtbNumara.Text);

            yeni.SinifId = cbSinif.SelectedValue.ToString();

            KayitYoneticisi.Ogrenciler.Add(yeni);
            KayitYoneticisi.Kaydet();
            DialogResult = DialogResult.OK;
        }

      
    }
}