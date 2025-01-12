using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Pizzas
{
    class CheesePizza : Pizza
    {
        public void prepare()
        {
            Console.WriteLine("Preparing cheese pizza");
        }
        public void bake()
        {
            Console.WriteLine("Baking cheese pizza");
        }

        public void cut()
        {
            Console.WriteLine("Cutting cheese pizza");
        }

        public void box()
        {
            Console.WriteLine("Boxing cheese pizza");
        }

        public void consume()
        {
            Console.WriteLine("Consuming cheese pizza");
        }

    }
}
