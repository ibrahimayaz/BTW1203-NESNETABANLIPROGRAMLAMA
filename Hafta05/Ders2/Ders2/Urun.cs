using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2
{
    /// <summary>
    /// Ürün nesnesi:
    /// Ürünün Özellikleri:
    /// Fiyatı
    /// Markası
    /// Adı
    /// Rengi
    /// YeniMi
    /// Ürünün işlevleri:
    /// Ac()
    /// </summary>
    public class Urun
    {
        double fiyat = 5;
        public string marka;
        public string adi;
        string rengi;
        bool yeniMi;

        //Yapılandırı Method = Kurucu Metod = Yapıcı Metod
        //Yapılandırıcı Methodlar sınıf adıyla aynı isimde olmalıdır.
        //Yapılandırıcı methodlar değer döndermezler !!!
        public Urun(string telefonAdi, string markaAdi)
        {
            marka = markaAdi;
            adi = telefonAdi;
            rengi = "Siyah";
            yeniMi = true;
        }

    }
}
