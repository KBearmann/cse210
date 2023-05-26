public class Address
{
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    string _street;
    string _city;
    string _state;
    string _country = "USA";
    bool international;
    public void SetInternational()
    {
        if (_country != "USA")
        {
            international = true;
        }
        else
        {
            international = false;
        }
    }

    public bool IsInternational()
    {
        SetInternational();
        return international;
    }
    public string CompleteAddress()
    {
        string showAddress;
        showAddress = $"{_street} {_city} {_state} {_country}";
        return showAddress;
    }
}
