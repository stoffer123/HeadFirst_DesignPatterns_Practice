using Decorator_Pattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Condiments
{
    public class Whip : Condiment
    {
        private Beverage beverage;
        private double cost;
        private string description;
        public Whip(Beverage beverage) : base(beverage)
        {
            this.beverage = beverage;
            cost = 2;
            description = "Whip";
        }

        public override double Cost()
        {
            return beverage.Cost() + cost;
        }

        public override string Description()
        {
            return beverage.Description() + description;
        }
    }

}
