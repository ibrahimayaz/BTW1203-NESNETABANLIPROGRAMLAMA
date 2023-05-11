using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miras2
{
    public class Personel:Kisi
    {
        private string _departmanAdi;

        public string DepartmanAdi { 
            get { return _departmanAdi; }
            set { _departmanAdi = value;}
        }

       
    }
}
