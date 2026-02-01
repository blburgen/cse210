using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Bob", "123N 1440E", "Idaho falls", "Idaho", "USA");
        Customer customer2 = new Customer("Tom", "back ally", "Nowhere", "Bagio", "Phillipines");
        List<Product> productList1 = new List<Product>();
        Product temp = new Product("ball", "1234", 5.99, 2);
        productList1.Add(temp);
        temp = new Product("cat", "1cat", 10.99, 5);
        productList1.Add(temp);
        List<Product> productList2 = new List<Product>();
        temp = new Product("stopper", "43", 11.99, 2);
        productList2.Add(temp);
        temp = new Product("cat", "1cat", 10.99, 1);
        productList2.Add(temp);
        Order order1 = new Order(customer1, productList1);
        Order order2 = new Order(customer2, productList2);



        Console.WriteLine(order1.GetPackingLable());
        Console.WriteLine();
        Console.WriteLine($"Total Price: {order1.GetTotalCost()}");
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLable());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: {order2.GetTotalCost()}");
        Console.WriteLine();
    }
}