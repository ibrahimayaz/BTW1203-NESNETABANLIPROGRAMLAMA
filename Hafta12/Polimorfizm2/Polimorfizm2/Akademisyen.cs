using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm2
{
    public class Akademisyen:Calisan
    {
        private string bolum;
        private string unvan;

        public virtual bool derseGir()
        {
            Console.WriteLine("Akademisyen derse giriyor.");
            return true;
        }

        public void yemekhane(string bolum)
        {
            Console.WriteLine("Akademisyen Yemekhane Bölümü");
        }
    }
}
