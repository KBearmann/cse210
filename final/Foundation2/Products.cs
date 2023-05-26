public class Product1
{
    public Product1(string name, int id, int quantity, int price)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    string _name;
    int _id;
    int _amount;
    int _price;
    int _quantity;
    int _itemCost;

    public int GetProductCost()
    {
        _itemCost = _price * _quantity;
        return _itemCost;
    }

    public void DisplayOrders()
    {
        Console.WriteLine($"Name: {_name} ID: {_id} Quantity: {_quantity} Price: ${_price}");
    }
}
