using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm4
{
    public class Ucak:Arac
    {
        public bool KanatKontrol()
        {
            return true;
        }

        private string Uc()
        {
            Console.WriteLine("Uçak uçuyor");
            return "Uçak uçuyor";
        } 

        public override void Ekle(string ad)
        {
            Console.WriteLine("Uçak eklendi");
        }
    }
}
