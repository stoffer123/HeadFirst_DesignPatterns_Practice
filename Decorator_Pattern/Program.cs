using Decorator_Pattern.Beverages;
using Decorator_Pattern.Condiments;

namespace Decorator_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a Beverage of type HouseBlend
            Beverage beverage1 = new HouseBlend(); //Create base coffee HouseBlend
            beverage1 = new Whip(beverage1);  //Add Whip
            beverage1 = new Whip(beverage1); //Add more Whip
            beverage1 = new Sugar(beverage1); //Add sugar

            Console.WriteLine(beverage1.Cost()); //Write the cost
            Console.WriteLine(beverage1.Description()); //Write description
        }
    }
}
