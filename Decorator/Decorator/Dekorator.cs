using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator
{
    abstract class Dekorator : IKalkulator
    {
        protected IKalkulator kalkulator;
        public string RodzajKalkulatora { get; set; }

        public Dekorator(IKalkulator ob)
        {
            kalkulator = ob;
        }

        public double Dodawanie(double a, double b)
        {
            return kalkulator.Dodawanie(a, b);
        }

        public double Odejmowanie(double a, double b)
        {
            return kalkulator.Odejmowanie(a, b);
        }

        public double Dzielenie(double a, double b)
        {
            return kalkulator.Dzielenie(a, b);
        }

        public double Mnozenie(double a, double b)
        {
            return kalkulator.Mnozenie(a, b);
        }

        public string WyswietlRodzajKalkulatora()
        {
            return kalkulator.WyswietlRodzajKalkulatora();
        }
    }
}
