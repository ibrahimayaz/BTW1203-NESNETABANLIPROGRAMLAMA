using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Kedi:Hayvan
    {
        public override char Cinsiyet { get; set; }
        public override int Yas { get; set; }

     
        public override string Konus()
        {
            return "Miyav Miyav...";
        }
    }
}
