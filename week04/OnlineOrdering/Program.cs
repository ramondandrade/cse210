using System;

class Program
{
    static void Main(string[] args)
    {

        var address = new Address("Main St", "123", "Springfield", "IL", "USA");
        var customer = new Customer("John Doe", address);
        var products = new List<Product>
        {
            new Product("P001", "Laptop", 999.99, 1),
            new Product("P002", "Mouse", 25.99, 2)
        };
        var order = new Order(products, customer, DateTime.Now);

        Console.WriteLine(order.DisplayFullOrder());
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine("\n\n-----------------\n\n");

        var address2 = new Address("Plaza de la flor", "4", "Leganés", "Madrid", "SPAIN");
        var customer2 = new Customer("John Doe", address2);
        var products2 = new List<Product>
        {
            new Product("P001", "Laptop", 999.99, 1),
            new Product("P002", "Mouse", 25.99, 3),
            new Product("P003", "Macbook Pro", 1999.99, 1),
        };
        var order2 = new Order(products2, customer2, DateTime.Now);

        Console.WriteLine(order2.DisplayFullOrder());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        

        
    }
}