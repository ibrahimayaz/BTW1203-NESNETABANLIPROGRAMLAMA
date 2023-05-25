using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm2
{
    public class LabAsistani:Asistan
    {
        public bool lablaraGir()
        {

            Console.WriteLine("Lab Asistanı lablara giriyor.");
            return true;
        }
        public override bool derseGir()
        {

            Console.WriteLine("Lab Asistanı derse giriyor.");
            return true;
        }
    }
}
