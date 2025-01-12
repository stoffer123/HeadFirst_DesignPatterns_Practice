using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Pizzas
{
    class VeggiePizza : Pizza
    {
        public void prepare()
        {
            Console.WriteLine("Preparing veggie pizza");
        }
        public void bake()
        {
            Console.WriteLine("Baking veggie pizza");
        }

        public void cut()
        {
            Console.WriteLine("Cutting veggie pizza");
        }

        public void box()
        {
            Console.WriteLine("Boxing veggie pizza");
        }

        public void consume()
        {
            Console.WriteLine("Consuming veggie pizza");
        }
    }
}
