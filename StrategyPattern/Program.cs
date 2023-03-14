// See https://aka.ms/new-console-template for more information
using SalesSystem;
using SalesSystem.Core;
using StrategyPattern.Core;
using StrategyPattern.Core.DiscountStrategies;

var dataReader = new CustomerDataReader();
var customers = dataReader.GetCustomers();
while (true)
{
    Console.WriteLine("Customer List: ");
    foreach (var customer in customers)
        Console.WriteLine($"\t{customer.Id}. {customer.Name} ({customer.Category})");
    Console.WriteLine();

    Console.Write($"Enter Customer ID: ");
    var customerId = int.Parse( Console.ReadLine() );
    Console.Write("Enter Item Quantity: ");
    var quantity = double.Parse( Console.ReadLine() );
    Console.Write("Enter Unit Price: ");
    var unitPrice = double.Parse( Console.ReadLine() );

    var selectedCustomer = customers.First(x => x.Id == customerId);
    var invoiceManager = new InvoiceManager();

    ICustomerDiscountStrategy customerDiscountStrategy = new CustomerDiscountStrategyFactory().CreateCustomerDiscountStragey(selectedCustomer.Category);
    invoiceManager.SetDiscountStrategy(customerDiscountStrategy);
    var invoice = invoiceManager.CreateInvoice(selectedCustomer, quantity, unitPrice);
    Console.WriteLine($"Invoice created for customer `{selectedCustomer.Name}` with net price: {invoice.NetPrice}");
    Console.WriteLine("Press any key to create another invoice");
    Console.ReadKey();
    Console.WriteLine("-------------------------------------");
}