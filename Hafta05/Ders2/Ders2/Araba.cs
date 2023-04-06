using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ders2
{

    /// <summary>
    /// Nesnemis araba olduğunu varsayarsak...
    /// Arabanın özellikleri:
    /// Rengi,
    /// Markası,
    /// YakıtTipi,
    /// Model
    /// Arabanın İşlevleri:
    /// Fren()
    /// Gaz()
    /// FarAc()
    /// FarKapat()
    /// </summary>
    public class Araba
    {
        //Field(Alanlar)
        public string renk = "Kırmızı";
        string marka = "Volvo";
        string yakitTipi = "Elektrik";
        public int model = 2023;

        //Değer döndermeyen bir method.
        public void Fren()
        {
            Console.WriteLine("Araba duruyor...");
        }
       

        
    }
}
