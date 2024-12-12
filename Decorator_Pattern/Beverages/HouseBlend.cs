using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Decorator_Pattern.Beverages
{
    class HouseBlend : Beverage
    {
        private double cost;
        private string description;

        public HouseBlend()
        {
            description = "HouseBlend";
            cost = 2;
        }

        


    }
}
