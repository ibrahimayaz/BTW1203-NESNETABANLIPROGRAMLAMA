using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm2
{
    public class BilgiIslem:Memur
    {
        private string gorev;
        public void networkKurulum()
        {
            Console.WriteLine("Network kurulumu yapılıyor.");
        }

        public override void Giris(int kapiNo)
        {
            Console.WriteLine($"{kapiNo} numaralı kapıdan bilgi işlem elemanı giriş yaptı.");
        }
    }
}
