using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Decorator_Pattern.Beverages
{
    public class HouseBlend : Beverage
    {
        private double cost;
        private string description;

        public HouseBlend()
        {
            description = "HouseBlend";
            cost = 2;
        }

        public override double Cost()
        {
            return cost;
        }

        public override string Description()
        {
            return description;
        }
    }
}
