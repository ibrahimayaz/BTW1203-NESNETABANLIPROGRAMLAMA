using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciMetod
{
    public class Elektronik
    {
        private string _ad;
        private string _marka;
        private float _fiyat;


        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }
        public string Marka
        {
            get { return _marka; }
            set { _marka = value; }
        }
        public float Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }

        public Elektronik(string ad, string marka, float fiyat) {
            this.Ad = ad;
            this.Marka = marka;
            this.Fiyat = fiyat;
        }

        public void UrunEkle()
        {
            Console.WriteLine($"{_marka} Markasına ait {_ad} ürünü {_fiyat} fiyatıyla eklendi.");
        }
    }
}
