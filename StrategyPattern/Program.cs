// See https://aka.ms/new-console-template for more information
using SalesSystem;
using SalesSystem.Core;
using StrategyPattern.Core;
using StrategyPattern.Core.DiscountStrategies;

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
    var invoiceManager = new InvoiceManager();

    ICustomerDiscountStrategy customerDiscountStrategy = new CustomerDiscountStrategyFactory().CreateCustomerDiscountStragey(customer.Category);
    invoiceManager.SetDiscountStrategy(customerDiscountStrategy);
    var invoice = invoiceManager.CreateInvoice(customer, quantity, unitPrice);
    Console.WriteLine($"Invoice created for customer `{customer.Name}` with net price: {invoice.NetPrice}");
    Console.WriteLine("Press any key to create another invoice");
    Console.ReadKey();
    Console.WriteLine("-------------------------------------");
}