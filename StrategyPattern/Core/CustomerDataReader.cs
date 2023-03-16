using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesSystem.Core;

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
                    Category = CustomerCategory.Gold,
                },
                new Customer(){
                    Id= 2,
                    Name="Wael Said",
                    Category = CustomerCategory.Silver,
                },
                new Customer(){
                    Id= 3,
                    Name="Lorn Voldmort",
                    Category = CustomerCategory.None,
                }
            };
        }
    }
}
