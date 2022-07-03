using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator
{
    class KalkulatorNaukowy : Dekorator
    {
        public KalkulatorNaukowy(IKalkulator ob, string b) : base(ob)
        {
            RodzajKalkulatora = b;
        }

        public double PierwiastekStopnia2(double a)
        {
            if (a < 0)
                return 0;
            return Math.Sqrt(a);
        }

        public string WyswietlRodzajKalkulatora()
        {
            return RodzajKalkulatora;
        }
    }
}