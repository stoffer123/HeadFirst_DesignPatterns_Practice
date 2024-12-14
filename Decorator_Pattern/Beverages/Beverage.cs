using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Beverages
{
    public abstract class Beverage
    {
        string description;
        public Beverage()
        {
            description = "Beverage";
        }

        public abstract double Cost();

        public abstract string Description();

    }
}
