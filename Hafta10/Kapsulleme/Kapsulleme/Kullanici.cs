using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    public class Kullanici
    {
        //Field (Alanlar)
        private string _ad;
        private string _soyad;
        private string _parola;
        private string _sonuc;

        //Properties(Özellikler)
        public string Ad
        {
            get
            {
                return _ad;
            }
            set { _ad = value; }
        }
        public string Soyad
        {
            get
            {
                return _soyad;
            }
            set { _soyad = value; }
        }
        public string Parola
        {
            get
            {
                return _parola;
            }
            set { _parola = value; }
        }
        public string Sonuc
        {
            get
            {
                return _sonuc ?? "Erişiminiz yoktur";
            }
            set {
                if (Parola=="123")
                {
                    _sonuc = value;
                }
            }
        }

        public Kullanici(string ad, string soyad, string sonuc, string parola) { 
            this.Ad = ad;
            this.Soyad = soyad;
            this.Parola = parola;
            this.Sonuc = sonuc;
        }
    }
}
