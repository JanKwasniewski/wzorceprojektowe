using System;

namespace pojedynczyton
{
    
    public sealed class Singleton
    {
        
        private Singleton() { }

       
        private static Singleton ?_instance;

       
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton działa, obie zmienne zwierają tę samą instację.");
            }
            else
            {
                Console.WriteLine("Singleton nie działa, obie zmienan zawierają inne instację.");
            }
        }
    }
}
