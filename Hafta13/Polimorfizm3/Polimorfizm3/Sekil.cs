using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm3
{
    //Üst sınıf == Ata sınıf
    public class Sekil
    {
        //Nitelikler (Değişkenler)
        private string ad;
        private string renk;

        public double kenarA;
        public double kenarB;
        public double kenarC;
        public double yukseklik;


        //Davranışlar(Metodlar)
        public virtual double AlanHesapla()
        {
            Console.WriteLine("Şekil Alan hesabı");
            return 0;
        }

    }
}
