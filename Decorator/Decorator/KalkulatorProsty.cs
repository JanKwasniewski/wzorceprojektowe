namespace Dekorator
{
    class KalkulatorProsty : IKalkulator
    {
        public string RodzajKalkulatora { get; set; }

        public KalkulatorProsty(string rodzajKalkulatora)
        {
            RodzajKalkulatora = rodzajKalkulatora;
        }

        public double Dodawanie(double a, double b)
        {
            return a + b;
        }

        public double Odejmowanie(double a, double b)
        {
            return a - b;
        }

        public double Dzielenie(double a, double b)
        {
            if (b == 0.0)
            {
                return 0;
            }
            return a / b;
        }

        public double Mnozenie(double a, double b)
        {
            return a * b;
        }

        public string WyswietlRodzajKalkulatora()
        {
            return RodzajKalkulatora;
        }
    }
}
