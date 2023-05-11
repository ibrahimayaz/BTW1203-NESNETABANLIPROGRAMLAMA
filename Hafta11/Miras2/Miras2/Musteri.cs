using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miras2
{
    public class Musteri:Kisi
    {

        public string SepeteEkle()
        {
            return $"{this.TamAd} isim-soyisimli müşteri ürünü sepete eklendi.";
        }
    }
}
