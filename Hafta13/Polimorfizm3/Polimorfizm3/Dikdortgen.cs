using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm3
{
    public class Dikdortgen:Sekil
    {
        private double CevreHesaple()
        {
            return 2 * kenarA + 2 * kenarB;
        }

        public override double AlanHesapla()
        {
            Console.WriteLine($"Dikdörtgen Alan Hesabı: {kenarA*kenarB}");
            return kenarA * kenarB;
        }
    }
}
