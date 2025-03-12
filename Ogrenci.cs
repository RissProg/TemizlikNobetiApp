using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemizlikNobetiApp
{
    public class Ogrenci
    {
        public string Id { get; set; }
        public int Numara { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }


        public string SinifId { get; set; }

        public string AdSoyad
        {
            get
            {
                return Ad + " " + Soyad;
            }
        }
    }
}
