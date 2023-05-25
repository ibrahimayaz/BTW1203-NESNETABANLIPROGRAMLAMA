using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{

    /// <summary>
    /// Süper sınıfımız >> Ata sınıfımız >> Üst sınıfımız.
    /// </summary>
    public class Animals
    {
        private string name;
        private int age;


        public virtual void Speak()
        {
            Console.WriteLine("Hayvan konuşuyor.");
        }
    }
}
