using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    public class Ogrenci
    {
        //camelCase yazım kuralına göre yazılmalıdır.
        //Sınıf içinde tanımlanan değişkenlere field (alan) denir.
        private string _ad;
        private string _soyad;
        private DateTime _dogumTarihi;


        //Properties(Özellik)
        //PascalCase yazım kuralına göre yazılmalıdır.
        public string Ad
        {
            get { return _ad; } //Okuma yapma özelliğini verdik.
            set { _ad = value; }
        }

        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }

        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }
        }


        //Kapsülleme yapıldı.
        //Bu Özellik sadece okuma yapar.
        public string TamAd
        {
            get { return _ad + " " +_soyad; }
        }


        public TimeSpan Yas
        {
            get { return (DateTime.Now - _dogumTarihi); }
        }

        

    }
}
