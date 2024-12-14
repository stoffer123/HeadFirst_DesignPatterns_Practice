using Decorator_Pattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Condiments
{
    public class Sugar : Condiment
    {
        Beverage beverage;
        string description;
        double cost;

        public Sugar(Beverage beverage) : base(beverage)
        {
            this.beverage = beverage;
            this.description = "Sugar";
            this.cost = 1;
        }

        public override double Cost()
        {
            return beverage.Cost() + cost;
        }

        public override string Description()
        {
            return beverage.Description() + "Sugar";
        }
    }
}
