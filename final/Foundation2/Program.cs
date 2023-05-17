using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> _orders = new List<Order>();

        Order order1 = new Order("Jasmine Chen", "Main Street", "Springfield", "IL 62704", "United States");
        order1.AddProduct("Apple", 001, 1, 10);
        order1.AddProduct("Orange", 002, 2, 10);

        Order order2 = new Order("Ryan Patel", "Market Street", "San Francisco", "CA 94105", "New Zealand");
        order2.AddProduct("Banana", 003, 3, 10);
        order2.AddProduct("Raspberry", 004, 4, 10);

        _orders.Add(order1);
        _orders.Add(order2);

        foreach (Order order in _orders)
        {
            Console.WriteLine("ShippingLable:" + order.ShippingLable());
            Console.WriteLine("PackingLable:" + order.PackingLable());
            Console.WriteLine("Total Cost: " + order.TototalCost());
            Console.WriteLine();
        }
    }
}