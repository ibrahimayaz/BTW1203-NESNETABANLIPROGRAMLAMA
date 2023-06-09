using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Koyun : Hayvan
    {

        //Hayvan sınıfı soyut bir sınıf olduğu için ve 
        //Hayvan sınıfı içerisinde soyut özellik ve soyut metotlar olduğundan dolayı
        //o metodları ezmek yani geçersiz kılmak zorundasın !

        public override int Yas { get; set; }
        public override char Cinsiyet { get; set; }

        public override string Konus()
        {
            return "Meeeee mee mee";
        }
    }
}
