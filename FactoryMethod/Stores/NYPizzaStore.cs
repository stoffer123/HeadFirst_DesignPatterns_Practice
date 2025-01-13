using FactoryMethod.Pizzas;
using FactoryMethod.Pizzas.NewYorkStyle;

namespace FactoryMethod.Stores
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            Pizza pizza = null;

            if(type == "cheese")
            {
                pizza = new NYCheesePizza();
            }else if(type == "veggie")
            {
                pizza = new NYVeggiePizza();
            }


            return pizza;
        }
    }
}
