public class Order
{
    public Order(Customer name, Address address)
    {
        _name = name;
        _address = address;
    }
    Customer _name;
    Address _address;

    public List<Product1> orderList = new List<Product1>();
    string _itemName;
    int _totalOrderCost = 0;
    int _itemCost;
    string _packingID;
    string _shippingName;
    string _shippingAddress;
    public void OrderList()
    {
        foreach (Product1 order in orderList)
        {
            order.DisplayOrders();
        }
    }
    public void AddOrder(string name, int id, int quantity, int price)
    {
        orderList.Add(new Product1(name, id, quantity, price));
    }
    public void ShippingLabel()
    {
        //PERSON INFO; name and address of person
        Console.WriteLine($"{_name.GetName()} { _address.CompleteAddress()}");
    }
    public void PackingLabel()
    {
        
        
        Console.WriteLine($"{_itemName} {_packingID}");
    }

    Product1 product = new Product1("ball", 45621, 3, 4);
    public int OverallCost()
    {
        foreach(Product1 product in orderList)
        {
            _totalOrderCost +=  product.GetProductCost();
        }

        
        
        if (_address.IsInternational())
        {
            _totalOrderCost += 35;
        }
        else
        {
            _totalOrderCost += 5;
        }
        return _totalOrderCost;
    }

    public void ToatlCost()
    {
        Console.WriteLine($"Total: {_totalOrderCost}");
    }
}
