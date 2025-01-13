using FactoryMethod.Stores;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nypizzaStore = new NYPizzaStore();


            nypizzaStore.orderPizza("veggie");
            Console.WriteLine("");
            nypizzaStore.orderPizza("cheese");

            Console.WriteLine("");
            Console.WriteLine("");


            PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();

            chicagoPizzaStore.orderPizza("veggie");
            Console.WriteLine("");
            chicagoPizzaStore.orderPizza("cheese");


            Console.ReadKey();
        }
    }
}
