public class Outdoor : Event
{
    string _weather;
    public Outdoor(string weather) : base ("Shelter Building","Learn how to build a survival structure!","June 30, 2024", "90 minutes")
    {
        _weather = weather;
        _event = "Outdoor Event";
        _address = new Address("Dogfood Road ", "Flagstaff", "Arizona", "United States");
    }
}
