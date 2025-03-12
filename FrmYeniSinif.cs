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
    public partial class FrmYeniSinif : Form
    {
        public FrmYeniSinif()
        {
            InitializeComponent();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Sinif yeni = new();
            //Benzersiz bir kimlik numarası oluştur
            yeni.Id = Guid.NewGuid().ToString();

            yeni.Ad = txtSinifEkle.Text;

            KayitYoneticisi.Siniflar.Add(yeni);

            KayitYoneticisi.Kaydet();
            DialogResult = DialogResult.OK;//Diyalog Formunu Kapatır
            //Form kapatılırken geriye cevap "OK" döner
        }
    }
}
