using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miras
{
    public class Arac
    {
        private string _ad;

        private int _modelYili;

        private double _fiyat;


        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }    
        }

        public int ModelYili
        {
            get { return _modelYili; }
            set { _modelYili = value; }
        }

        public double Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }

        public bool Calistir()
        {
            Console.WriteLine("Araç çalışıyor.");
            return true;
        }


    }
}
