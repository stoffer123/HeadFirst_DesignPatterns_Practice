using FactoryMethod.Stores;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore = new NYPizzaStore();

            pizzaStore.orderPizza("veggie");
            pizzaStore.orderPizza("cheese");

            Console.ReadKey();
        }
    }
}
