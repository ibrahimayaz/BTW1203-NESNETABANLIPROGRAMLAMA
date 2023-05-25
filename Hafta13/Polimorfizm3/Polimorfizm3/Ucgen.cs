using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm3
{
    public class Ucgen:Sekil
    {
        public override double AlanHesapla()
        {
            Console.WriteLine($"Ücgenin alan hesabı: {(yukseklik * kenarB) / 2}");
            return (yukseklik * kenarB) / 2;
        }
       
    }
}
