using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miras2
{
    public class Kisi
    {
        //Fields (Alanlar): Sınıf içinde tanımlanan değişkenlere denir.
        //Alanlar özel yani private tanımlanmalıdır.
        //Çünkü alanların güvenlik açısından dışarıdan erişilmesi doğru bir yaklaşım değildir.
        //Ayrıca kapsülleme tekniği için böyle tanımlama yapmak gerekir.

        //Fields
        private string _ad;
        private string _soyad;
        private DateTime _dogumTarihi;

        //Özellikler: Alanları yönetmek için kullanılan bir yapıdır.
        //Genellikle public tanımlanır, bu karar yazılımcıya aittir.
        //Özellikler alanları okumak(get) ve değiştirmek(set) için kullanılır. 
        //Kapsülleme tekniğinin en önemli parçasıdır.
        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }
        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }
        public string TamAd
        {
            get { return $"{Ad} {Soyad}"; }
        }

        public DateTime DogumTarihi
        {
            get { return _dogumTarihi;}
            set { _dogumTarihi = value;}
        }
        //Kapsülleme
        public int Yas
        {
            get
            {
                var yas = (int)(DateTime.Now - DogumTarihi).TotalDays / 365;
                if (yas>=0)
                {
                    return yas;
                }
                else
                {
                    return 0;
                }
            }
        }



    }
}
