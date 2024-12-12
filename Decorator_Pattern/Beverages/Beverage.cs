using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Beverages
{
    abstract class Beverage
    {
        private double cost;
        private string description;

        public Beverage()
        {
            cost = 0.0;
            description = "Beverage";
        }
    }
}
