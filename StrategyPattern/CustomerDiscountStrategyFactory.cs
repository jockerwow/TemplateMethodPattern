using SalesSystem.Core;
using StrategyPattern.Core.DiscountStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem
{
    internal class CustomerDiscountStrategyFactory
    {
        public ICustomerDiscountStrategy CreateCustomerDiscountStragey(CustomerCategory category)
        {
            if (category == CustomerCategory.Silver)
                return new SilverCustomerDiscountStrategy();
            else if (category == CustomerCategory.Gold)
                return new GoldCustomerDiscountStrategy();
            else
                return new NewCustomerDiscountStrategy();
        }
    }
}
