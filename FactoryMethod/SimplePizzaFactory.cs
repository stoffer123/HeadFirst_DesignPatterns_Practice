using SimpleFactory.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class SimplePizzaFactory
    {
        public Pizza createPizza(string type)
        {
            Pizza pizza = null;

            if(type == "veggiePizza")
            {
                pizza = new VeggiePizza();
            }else if(type == "cheesePizza")
            {
                pizza = new CheesePizza();
            }

            if (pizza != null)
            {
                pizza.prepare();
                pizza.bake();
                pizza.cut();
                pizza.box();
            }

            return pizza;
        }
    }
}
