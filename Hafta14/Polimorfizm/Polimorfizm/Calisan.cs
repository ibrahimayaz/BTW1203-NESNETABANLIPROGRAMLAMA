using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    public class Calisan:Kisi
    {

      

        private int maas;
        private int girisYili;

        //Hizmet yılı 5-10 arasında ise 20% zamlı, 10-15 arasında ise 25% zamlı olsun değilse taban maaş alsın
        public double MaasHesapla(int girisYili, int maas)
        {
            int kacYil = DateTime.Now.Year - girisYili;

            if (5<=kacYil && kacYil<=10)
            {
                return maas * 1.20;
            }
            else if(10 < kacYil && kacYil <= 15)
            {
                return maas * 1.25;
            }
            else
            {
                return maas;
            }
        }

        public override string KisiEkle(string ad, string soyad)
        {
            base.KisiEkle(ad, soyad);
            return $"{ad} {soyad} isimli çalışan eklendi.";
        }


    }
}
