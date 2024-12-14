using Decorator_Pattern.Beverages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Condiments
{
    public abstract class Condiment : Beverage
    {
        private string description;
        private Beverage beverage;
        public Condiment(Beverage beverage)
        {
            this.beverage = beverage;
        }

    }
}
