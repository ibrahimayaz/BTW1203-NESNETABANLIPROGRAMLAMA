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
        abstract public int Yas { get; set; }

        public abstract char Cinsiyet { get; set; }


        public abstract string Konus();


        public string Kos()
        {
            return "Koşuyor.";
        }





    }
}
