using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm4
{
    public class Arac
    {
        private string ad;
        private string marka;
        private bool sifirMi;


        public virtual void Ekle(string ad)
        {
            Console.WriteLine("Araç eklendi");
        }

        public virtual void Calistir(string ad)
        {
            Console.WriteLine("Araç çalıştı");
        }

        public virtual string Durdur()
        {
            Console.WriteLine("Araç duruyor");
            return "Araç duruyor";
        }

       
    }
}
