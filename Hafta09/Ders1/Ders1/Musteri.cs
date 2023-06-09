using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Ders1
{
    public class Musteri
    {
        // Özellikler, Fields(alanlar)
        public string ad;
        public string soyad;
        public char cinsiyet;
        public int yas;

        public Musteri(string ad, string soyad, char cinsiyet, int yas) {
            this.ad = ad;
            this.soyad = soyad;
            this.cinsiyet = cinsiyet;
            this.yas= yas; 
        }

        public Musteri(string _ad, string _soyad)
        {
            ad = _ad;
            soyad = _soyad;
        }

        public bool Ekle(Musteri m)
        {
            if (m.yas>=18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool Ekle(int yas)
        {
            if (yas>=18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
