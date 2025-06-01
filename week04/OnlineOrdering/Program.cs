using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Console.WriteLine();

        Console.WriteLine("First Order:");

        Order order1 = new Order();
        Product product1 = new Product("Bag", 1, 5, 2);
        Address address1 = new Address("12, Lancelot street", "Lake Side", "Lagos", "Nigeria");
        Customer customer1 = new Customer("Jack Adam", address1);
        Console.WriteLine(order1.DisplayPackingLabel("Bag", 1));
        Console.WriteLine(customer1.DisplayCustomer());

        //second product
        Product product2 = new Product("Shoe", 2, 15, 1);
        Address address2 = new Address("11, Lakeview street", "Mountain side", "Abuja", "Nigeria");
        Customer customer2 = new Customer("Molly Pete", address2);
        Console.WriteLine(order1.DisplayPackingLabel("Shoe", 2));
        Console.WriteLine(customer2.DisplayCustomer());
        int productPrice1 = product1.CalculateTotalCostOfProduct();
        int productPrice2 = product2.CalculateTotalCostOfProduct();
        int order1ProductPrice = productPrice1 + productPrice2;
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost(order1ProductPrice)}");
        
        //Second Order
        Console.WriteLine();
        Console.WriteLine("Second Order:");
        Order order2 = new Order();

        Product product3 = new Product("Hat", 3, 2, 4);
        Address address3 = new Address("4, Riverside", "Green Park", "LA", "USA");
        Customer customer3 = new Customer("Anita James", address3);
        Console.WriteLine(order2.DisplayPackingLabel("Hat", 3));
        Console.WriteLine(customer3.DisplayCustomer());

        Product product4 = new Product("Jacket", 4, 2, 4);
        Address address4 = new Address("7, North Bank", "Markurdi", "Benue", "Nigeria");
        Customer customer4 = new Customer("Mary Ann", address4);
        Console.WriteLine(order2.DisplayPackingLabel("Jacket", 4));
        Console.WriteLine(customer4.DisplayCustomer());
        int productPrice3 = product3.CalculateTotalCostOfProduct();
        int productPrice4 = product4.CalculateTotalCostOfProduct();
        int order2ProductPrice = productPrice3 + productPrice4;
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost(order2ProductPrice)}");

    }
}