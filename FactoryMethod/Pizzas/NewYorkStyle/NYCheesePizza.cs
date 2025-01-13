using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FactoryMethod.Pizzas.NewYorkStyle
{
    public class NYCheesePizza : Pizza
    {
        public NYCheesePizza()
        {
            base.name = "New York style Cheese pizza";
            base.dough = "Thin dough";
            base.sauce = "Marinara sauce";
            toppings.Add("Mozarella");
            toppings.Add("Parmigianno");
        }

    }
}
