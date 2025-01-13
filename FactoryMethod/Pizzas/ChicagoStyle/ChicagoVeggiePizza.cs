
namespace FactoryMethod.Pizzas.ChicagoStyle
{
    public class ChicagoVeggiePizza : Pizza
    {
        public ChicagoVeggiePizza()
        {
            base.name = "Chicago style Veggie pizza";
            base.dough = "Thick dough";
            base.sauce = "Shit sauce";
            toppings.Add("Pineapple");
            toppings.Add("Cucumber");
            toppings.Add("Carrot");
        }

    }
}
