using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create some products
        Product product1 = new Product("Laptop", "12345", 800, 2);
        Product product2 = new Product("Mouse", "67890", 30, 3);

        // Create a customer
        Address customerAddress = new Address("123 Main St", "Anytown", "NY", "USA");
        Customer customer = new Customer("John Doe", customerAddress);

        // Create an order with the products and the customer
        Order order1 = new Order(customer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Create another order
        Address customerAddress2 = new Address("456 Elm St", "Otherville", "CA", "USA");
        Customer customer2 = new Customer("Jane Smith", customerAddress2);
        Order order2 = new Order(customer2);

        // Add products to the second order
        Product product3 = new Product("Smartphone", "98765", 600, 1);
        order2.AddProduct(product1);
        order2.AddProduct(product3);

        // Display results for the first order
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Order 1 Total Price: $" + order1.GetTotalPrice());

        // Display results for the second order
        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Order 2 Total Price: $" + order2.GetTotalPrice());
    }
}