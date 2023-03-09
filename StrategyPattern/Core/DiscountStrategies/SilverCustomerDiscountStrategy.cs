using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Core.DiscountStrategies
{
    internal class SilverCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totalPrice)
        {
            return totalPrice >= 1000 ? 0.05 : 0;
        }
    }
}
