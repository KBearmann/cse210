public class Receptions : Event
{
    public Receptions() : base ("Richard and Jane's Reception","Come support Richard and Jane's reception!","May,23 2010", "60 minutes")
    {
        _event = "Reception";
        _address = new Address("1359 E Love dr", "Mesa", "Arizona", "United States");
    }
    bool _register;
    public void Register()
    {
        if (_register == true)
        {
            Console.WriteLine("You are registered for the event. Welcome! Come in");
        }
        else
        {
            Console.WriteLine("I'm sorry this event requires you to register beforehand.");
        }
    }
}
