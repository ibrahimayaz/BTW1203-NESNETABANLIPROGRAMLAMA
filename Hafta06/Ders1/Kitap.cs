using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders1
{
    /// <summary>
    /// NESNEMİZ : KİTAP
    /// Kitabın adı, yazarı, basım yılı, fiyatı
    /// Kitab Oku(), SayfaDegistir()
    /// </summary>
    public class Kitap
    {
        /// <summary>
        /// Field(alanlar) == > Özellikler
        /// </summary>
        public string Ad;
        public string YazarAdi;
        public int BasimYili;
        public double Fiyat;

        public Kitap(string Ad, string YazarAdi, int BasimYili, double Fiyat)
        {
            this.Ad = Ad;
            this.YazarAdi = YazarAdi;
            this.BasimYili = BasimYili;
            this.Fiyat = Fiyat;
        }

        public string Oku()
        {
            return $"{Ad} isimli kitap okunuyor.";
        }

        public string SayfaDegistir(int sayfaNo)
        {
            return $"{this.Ad} isimli kitabın {sayfaNo}. sayfası açıldı.";
        }
     
    }
}
