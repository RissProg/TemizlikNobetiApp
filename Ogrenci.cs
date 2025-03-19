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

        //Sinif modelinden gelen Id ===> SinifId olacak
        public string SinifId { get; set; }

        public string AdSoyad
        {
            get
            {
                return $"{Ad} {Soyad} (TP: {TemizlikPuani} )";
            }
        }

        public int TemizlikPuani
        {
            get
            {
                //return 0;
                //Bu öğrencinin id sini temizlik kayitlari içinde say
                int sayi = KayitYoneticisi.TemizlikKayitlari.
                    Count(x => x.OgrenciId == Id);

                return sayi;
            }
        }
    }
}
