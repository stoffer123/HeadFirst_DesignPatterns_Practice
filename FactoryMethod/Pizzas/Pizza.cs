using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Pizzas
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();
        public void prepare()
        {
            Console.WriteLine($"Preparing {name}");
            Console.WriteLine($"Tossing dough of type: {dough}");
            Console.WriteLine($"Adding {sauce}");
            Console.WriteLine("Adding toppings:");
            foreach (string s in toppings)
            {
                Console.WriteLine(s);
            }
        }
        public void bake()
        {
            Console.WriteLine("Baking for 25minutes at 300c");
        }
        public void cut()
        {
            Console.WriteLine("Cutting the pizza");
        }
        public void box()
        {
            Console.WriteLine("Boxing the pizza");
        }

        public string ToString()
        {
            return name;
        }

    }
}
