using FactoryMethod.Pizzas;
using FactoryMethod.Pizzas.ChicagoStyle;

namespace FactoryMethod.Stores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            Pizza pizza = null;

            if(type == "cheese")
            {
                pizza = new ChicagoCheesePizza();
            }else if(type == "veggie")
            {
                pizza = new ChicagoVeggiePizza();
            }


            return pizza;
        }
    }
}
