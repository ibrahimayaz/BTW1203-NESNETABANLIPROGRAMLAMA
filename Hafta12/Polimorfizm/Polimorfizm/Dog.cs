using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    public class Dog:Animals
    {

        //Geçersiz kılma işlemi burada override anahtar cümlesiyle gerçekleştirildi.
        //Override ibaresini ekleyebilmek için üst sınıf olan Animals sınıfının Speak metoduna virtual ibaresi eklenmelidir.
        public override void Speak()
        {
            Console.WriteLine("Hav hav.....");
        }
    }
}
