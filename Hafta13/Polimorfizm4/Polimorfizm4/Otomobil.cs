using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm4
{
    public class Otomobil:Arac
    {
        private bool elektrikliMi;


        public bool Calistir()
        {
            Console.WriteLine("Otomobil Çalışıyor");
            return true;
        }

    }
}
