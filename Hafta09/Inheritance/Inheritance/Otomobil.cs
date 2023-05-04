using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Otomobil:Arac
    {
        public string _yakitTipi;
        public Otomobil(string yakitTipi)
        {
            _yakitTipi = yakitTipi;
        }
        private string Git()
        {
            return $"Yakıt tipi {_yakitTipi} olan otomobil gidiyor.";
        }

        public string Dur()
        {
            return "Otomobil duruyor.";
        }

        public bool FarYak()
        {
            return true;
        }

        private bool FarSondur()
        {
            return true;
        }
    }
}
