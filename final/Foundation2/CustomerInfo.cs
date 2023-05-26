public class Customer
{
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    Address _address;
    string _name;
    public string GetName()
    {
        return _name;
    }
    public bool International()
    {
        return _address.IsInternational();
    }
}
