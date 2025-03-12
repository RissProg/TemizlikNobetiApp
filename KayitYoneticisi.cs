using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TemizlikNobetiApp
{
    public static class KayitYoneticisi
    {
        public static BindingList<Sinif> Siniflar { get; set; }

        public static void Kaydet()
        {

            string metin = JsonSerializer.Serialize(Siniflar);

            File.WriteAllText("siniflar.txt", metin);
        }

        public static void Yukle()
        {

            if (File.Exists("siniflar.txt"))
            {
                string metin = File.ReadAllText("siniflar.txt");

                var liste = JsonSerializer.Deserialize<List<Sinif>>(metin);
                Siniflar = new BindingList<Sinif>(liste);
            }
            else
            {

                Siniflar = new BindingList<Sinif>();
            }
        }
    }
}
