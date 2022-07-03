using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Margherita : Pizza
    {
        public Margherita()
        {
            ingridients.Add("Ser");
            ingridients.Add("Pomidory");
            ingridients.Add("Bazylia");
            
        }
    }
}
