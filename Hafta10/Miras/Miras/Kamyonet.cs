using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miras
{
    public class Kamyonet:Arac
    {
        private string _yakitTipi;

        public string YakitTipi
        {
            get { return _yakitTipi; }
            set { _yakitTipi = value; }
        }

        public bool Calistir()
        {
            Console.WriteLine("Kamyonet çalışıyor.");
            return true;
        }


    }
}
