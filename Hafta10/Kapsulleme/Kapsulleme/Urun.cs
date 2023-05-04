using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    public class Urun
    {
        private string _ad;
        private double _birimFiyat;
        private bool _stoktaVarMi;
        private double _kdvOrani;

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public double BirimFiyat
        {
            get
            {
                return _birimFiyat;
            }
            set { _birimFiyat = value; }
        }

        public bool StoktaVarMi
        {
            get
            {
                return _stoktaVarMi;
            }
            set { _stoktaVarMi = value; }
        }

        public double KdvOrani
        {
            get { return _kdvOrani; }
            set { _kdvOrani = value; }
        }

        //Kapsülleme
        public double KdvliBirimFiyat
        {
            get { return _birimFiyat * KdvOrani; }
        }
    }
}
