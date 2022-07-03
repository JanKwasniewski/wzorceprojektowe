using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class PizzaFactory
    {
        public Pizza GetPizza(string name)
        {
            Pizza pizza = null;

            if (name == "margherita")
            {
                pizza = new Margherita();
            }
            else if (name == "quattroformaggi")
            {
                pizza = new QuatroFormaggi();
            }
            else 
            {
                pizza = new Margherita();
            }

            return pizza;
        }

    }
}
