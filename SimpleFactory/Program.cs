using SimpleFactory;
using SimpleFactory.Pizzas;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            SimplePizzaFactory pizzaFactory = new SimplePizzaFactory();

            Pizza pizza1 = pizzaFactory.createPizza("veggiePizza");
            
            pizza1.consume();

            Pizza pizza2 = pizzaFactory.createPizza("cheesePizza");
            pizza2.consume();

            Console.ReadKey();
            
        }
    }
}
