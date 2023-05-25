using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm2
{
    public class OgretimGorevlisi:Akademisyen
    {
        private int kapiNo;
        public void SenatoToplanti()
        {
            Console.WriteLine("Öğretim Görevlileri senatoda toplanıyor.");
        }

        public void SinavYap()
        {
            Console.WriteLine("Öğretim Görevlisi sınav yapıyor.");
        }
    }
}
