using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm2
{
    public class Asistan:Akademisyen
    {
        private DateTime ofisSaati;

        public void quizYap()
        {
            Console.WriteLine("Asistan quiz yapıyor.");
        }

        public override bool derseGir()
        {

            Console.WriteLine("Asistan derse giriyor.");
            return true;
        }

    }
}
