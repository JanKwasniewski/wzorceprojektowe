using System;
namespace Dekorator
{
    class Program
    {
        static void Main(string[] args)
        {
            KalkulatorProsty KalProsty = new KalkulatorProsty("Prosty");
            Console.WriteLine(KalProsty.WyswietlRodzajKalkulatora());

            KalkulatorNaukowy KalNau = new KalkulatorNaukowy(KalProsty, "Naukowy");
            Console.WriteLine(KalNau.WyswietlRodzajKalkulatora());

            Console.WriteLine(KalNau.Dodawanie(2, 2));
            Console.WriteLine(KalNau.PierwiastekStopnia2(4));
            Console.ReadLine();
        }
    }
}