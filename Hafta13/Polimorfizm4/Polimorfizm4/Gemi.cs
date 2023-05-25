using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm4
{
    public class Gemi:Arac
    {
        public override string Durdur()
        {
            Console.WriteLine("Gemi duruyor");
            return "Gemi duruyor";
        }

        public override void Calistir(string ad)
        {
            Console.WriteLine("Gemi çalışıyor");
        }
    }
}
