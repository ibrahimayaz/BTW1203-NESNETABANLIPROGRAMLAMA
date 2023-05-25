using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm2
{
    public class Calisan
    {
        private string adSoyad;
        private string telefon;
        private string eposta;


        public virtual void Giris(int kapiNo)
        {
            Console.WriteLine($"{kapiNo} dan giriş yapıldı.");
        }

        public void Cikis()
        {
            Console.WriteLine("Çıkış yapıldı.");
        }

        public void Yemekhane()
        {
            Console.WriteLine("Yemekhane düzenlendi.");
        }

    }
}
