using FactoryMethod.Pizzas;

namespace FactoryMethod.Stores
{
    public abstract class PizzaStore
    {
        public Pizza orderPizza(string type)
        {
            Pizza pizza = createPizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        protected abstract Pizza createPizza(string type);
    }
}
