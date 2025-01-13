using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FactoryMethod.Pizzas.ChicagoStyle
{
    public class ChicagoCheesePizza : Pizza
    {
        public ChicagoCheesePizza()
        {
            base.name = "Chicago style Cheese pizza";
            base.dough = "Thick dough";
            base.sauce = "Marinara sauce";
            toppings.Add("Mozarella");
            toppings.Add("Parmigianno");
        }

    }
}
