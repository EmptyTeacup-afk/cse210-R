using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("John Doe", new Address("123 Main St", "Anytown", "CA", "USA"));
        Customer customer2 = new Customer("Jane Smith", new Address("456 Oak St", "London", "England", "UK"));

        Product product1 = new Product("Laptop", "P001", 1000, 1);
        Product product2 = new Product("Mouse", "P002", 20, 2);
        Product product3 = new Product("Keyboard", "P003", 50, 1);

        Order order1 = new Order(customer1, new List<Product> { product1, product2 });
        Order order2 = new Order(customer2, new List<Product> { product1, product2, product3 });

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price:", order1.GetTotalPrice());

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price:", order2.GetTotalPrice());
        
    }
}