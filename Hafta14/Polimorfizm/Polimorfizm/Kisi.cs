using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    public class Kisi
    {
        private string ad;
        private string soyad;
        public string getTamAd
        {
            get { return ad + " " + soyad; }
        }
        private int yas;

        protected char cinsiyet;

        Kisi(int yas, char cinsiyet)
        {
            this.yas = yas;
            this.cinsiyet= cinsiyet;
        }


        public Kisi()
        {
        }

        public virtual string KisiEkle(string ad, string soyad)
        {
            return $"{ad} {soyad} isimli kişi eklendi.";
        }


    }
}
