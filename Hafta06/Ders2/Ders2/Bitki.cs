using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2
{
    //Nesnemiz Bitki
    //Fields (alanları) => Adı, Türü, EkimTarihi, EkimBoyu, TazeMi
    //Sulama()
    public class Bitki
    {
        public string Ad;
        public string Turu;
        public double EkimBoyu;
        public bool TazeMi;
        public bool ToprakKuruMu;

        public Bitki(string Ad, string Turu, double EkimBoyu, bool ToprakKuruMu)
        {
            this.Ad = Ad;
            this.Turu = Turu;
            this.EkimBoyu= EkimBoyu; 
            this.ToprakKuruMu= ToprakKuruMu;
        }
        public Bitki(bool TazeMi, double EkimBoyu, bool ToprakKuruMu)
        {
            this.TazeMi = TazeMi;
            this.EkimBoyu = EkimBoyu;
            this.ToprakKuruMu = ToprakKuruMu;
        }


        public bool Sulama()
        {
            if (this.ToprakKuruMu==true)
            {
                Console.WriteLine("Sulama yapılıyor..");
                return true;
            }
            else
            {
                Console.WriteLine("Toprak kuru, sulamaya gerek yoktur..");
                return false;
            }
        }


    }
}


//SORU: Urun adında bir sınıf oluşturunuz. 
//Bu sınıfa ait 3 adet fields (alan) tanımlayın aynı zamanda bu sınıfa ait 1 fonksiyon tanımlaması yapınız.
//Bu fonksiyon ürünün fiyatının kdvli halini döndersin.
//Bu sınıftan nesne türetmesi yapınız. Türettiğiniz nesneden fonksiyonu çağırınız.