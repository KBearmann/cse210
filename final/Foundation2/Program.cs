using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Console.Clear();
        Address address1 = new Address("1953 S Peach Ln", "Rexburg", "Idaho", "USA");
        Customer customer1 = new Customer("Rob Mclain", address1);
        address1.CompleteAddress();
        Order order = new Order(customer1, address1);
        order.AddOrder("figure small", 4011389, 4, 12);
        order.AddOrder("paint,model", 4011391, 2, 7);
        order.OrderList();
        order.ShippingLabel();
        order.PackingLabel();
        order.OverallCost();
        order.ToatlCost();

        Address address2 = new Address("1953 E Main Rd", "Mesa", "Arizona", "USA");
        Customer customer2 = new Customer("Mark Galindo", address2);
        address1.CompleteAddress();
        Order order2 = new Order(customer2, address2);
        order2.AddOrder("Thread,red", 982761, 3, 6);
        order2.AddOrder("Thread,blue", 218992, 3, 5);
        order2.AddOrder("Thread, teal", 214341, 2, 5);
        order2.OrderList();
        order2.ShippingLabel();
        order2.PackingLabel();
        order2.OverallCost();
        order2.ToatlCost();
    }
}
