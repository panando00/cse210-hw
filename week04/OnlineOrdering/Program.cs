using System;

class Program
{
    static void Main(string[] args)
    {
        //addresses
        Address usaAddress = new Address("45 Doctor St", "Seattle", "WA", "USA");
        Address internationalAddress = new Address("26 Apple Rd", "Toronto", "ON", "Canada");

        //customers
        Customer usCustomer = new Customer("Prosper Zvidzai", usaAddress);
        Customer internationalCustomer = new Customer("Panashe Zvidzai", internationalAddress);

        //products
        Product laptop = new Product("Laptop", "TECH001", 999.99m, 1);
        Product mouse = new Product("Mouse", "TECH002", 24.99m, 2);
        Product keyboard = new Product("Keyboard", "TECH003", 59.99m, 1);

        //first order
        Order order1 = new Order(usCustomer);
        order1.AddProduct(laptop);
        order1.AddProduct(mouse);

        //second order (International)
        Order order2 = new Order(internationalCustomer);
        order2.AddProduct(keyboard);
        order2.AddProduct(mouse);

        //displaying first order details
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}\n");

        //displaying second order details
        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}