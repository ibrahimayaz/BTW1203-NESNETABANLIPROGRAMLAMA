using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{

    //Üst sınıf
    abstract public  class Hayvan
    {
        public string Ad { get; set; }
        //Soyut Özellik
        abstract public int Yas { get; set; }

        public abstract char Cinsiyet { get; set; }

        //Soyut Metod
        public abstract string Konus();

        //Somut Metoddur.
        public string Kos()
        {
            return "Koşuyor.";
        }





    }
}
