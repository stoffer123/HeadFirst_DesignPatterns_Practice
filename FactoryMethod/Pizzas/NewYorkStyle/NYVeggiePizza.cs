
namespace FactoryMethod.Pizzas.NewYorkStyle
{
    public class NYVeggiePizza : Pizza
    {
        public NYVeggiePizza()
        {
            base.name = "New York style Veggie pizza";
            base.dough = "Thin dough";
            base.sauce = "Marinara sauce";
            toppings.Add("Pineapple");
            toppings.Add("Cucumber");
            toppings.Add("Carrot");
        }

    }
}
