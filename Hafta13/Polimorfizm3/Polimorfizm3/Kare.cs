using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm3
{
    public class Kare:Sekil
    {
        public override double AlanHesapla()
        {
            Console.WriteLine($"Karenin alan hesabı: {kenarA * kenarA}");
            return kenarA * kenarA;
        }
        public double AlanHesapla(double sayi1)
        {
            return sayi1 * kenarB;
        }


    }
}
