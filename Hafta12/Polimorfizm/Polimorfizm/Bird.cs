using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    public class Bird:Animals
    {
        public override void Speak()
        {
            Console.WriteLine("Kuş konuşuyor..");
        }
    }
}
