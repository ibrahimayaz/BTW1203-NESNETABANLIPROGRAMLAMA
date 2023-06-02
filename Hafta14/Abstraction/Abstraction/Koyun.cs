using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Koyun : Hayvan
    {
        public override int Yas { get; set; }
        public override char Cinsiyet { get; set; }

        public override string Konus()
        {
            return "Meeeee mee mee";
        }
    }
}
