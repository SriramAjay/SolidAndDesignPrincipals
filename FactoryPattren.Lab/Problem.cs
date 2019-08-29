using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattren.Lab
{

    class Pulsar
    {
        public int OriginalPrice { get { return 95000; } }
        
        public double GetPrice(int _intmodel)
        {
            if (_intmodel < 2015) { return OriginalPrice * 0.5; }
            else { return OriginalPrice * 0.2; }
        }
         
    }
    class Appache
    {
        double _dblprice = 125000;
        public double GetPrice(int _intmodel)
        {
            if (_intmodel < 2015) { return _dblprice * 0.4; }
            else { return _dblprice * 0.25; }
        }

    }
    class HeroHonda
    {
        double _dblprice = 70000;
        public double GetPrice(int _intmodel)
        {
            if (_intmodel < 2015) { return _dblprice * 0.5; }
            else { return _dblprice * 0.3; }
        }

    }
}
