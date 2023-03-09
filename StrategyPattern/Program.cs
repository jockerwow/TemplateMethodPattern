// See https://aka.ms/new-console-template for more information
using StrategyPattern.Core;

var dataReader = new CustomerDataReader();
var customers = dataReader.GetCustomers();
while (true)
{
    Console.WriteLine("Customer List: [1] Mohamed Nagieb [2] Wael Said");
    Console.Write($"Enter Customer ID: ");
    var customerId = int.Parse( Console.ReadLine() );
    Console.Write("Enter Item Quantity: ");
    var quantity = double.Parse( Console.ReadLine() );
    Console.Write("Enter Unit Price: ");
    var unitPrice = double.Parse( Console.ReadLine() );

    var customer = customers.First(x => x.Id == customerId);
    var invoice = new Invoice
    {
        Customer = customer,
        Lines = new[]
          {
            new InvoiceLine { Quantity = quantity, UnitPrice = unitPrice }
        },
        DiscountPercentage = customer.IsEligibleForDiscount ? 0.02 : 0
        /* Challenge: New Business Requirement:
         * The discount needs to be based on Customer category:
         * New "no discount applies", 
         * Silver "5% discount for 10K+ invoices", 
         * Gold "5% discount for 10K+ invoices", 
         */
    };
    Console.WriteLine($"Invoice created for customer `{customer.Name}` with net price: {invoice.NetPrice}");
    Console.WriteLine("Press any key to create another invoice");
    Console.ReadKey();
    Console.WriteLine("-------------------------------------");
}