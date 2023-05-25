using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm2
{
    public class Memur:Calisan
    {
        private string departman;
        private string mesai;

        public void calis()
        {
            Console.WriteLine("Memur çalışıyor.");
        }

        public override void Giris(int kapiNo)
        {
            Console.WriteLine($"{kapiNo} numaralı kapıdan memur giriş yaptı. ");
        }
    }
}
