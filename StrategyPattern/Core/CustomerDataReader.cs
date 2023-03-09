using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Core
{
    internal class CustomerDataReader
    {
        public IEnumerable<Customer> GetCustomers()
        {
            return new[] {
            new Customer(){
                Id= 1,
                Name="Mohamed Nagieb",
                IsEligibleForDiscount=true
            },
            new Customer(){
                Id= 2,
                Name="Wael Said"
            }
            };
        }
    }
}
