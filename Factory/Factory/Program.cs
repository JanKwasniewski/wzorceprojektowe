using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rodzaj pizzy [margherita/quattroformaggi]");

            var pizzaType = Console.ReadLine();

            var pizzaFactory = new PizzaFactory();

            var pizza = pizzaFactory.GetPizza(pizzaType);

            pizza.PrintIngridients();

            Console.ReadKey();
        }
    }
}