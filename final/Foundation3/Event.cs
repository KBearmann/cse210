public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _event;
    public Event(string title, string description, string date, string time)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
    }
    public void Standard()
    {
        //Standard details - Lists the title, description, date, time, and address.
        Console.WriteLine($"{_title} {_description} {_date} {_time} {_address.CompleteAddress()}");
    }

    public void Full()
    {
        
        Console.WriteLine($"{_title} {_description} {_date} {_time} {_address.CompleteAddress()}");
    }

    public void ShortDesc()
    {
        
        Console.WriteLine($"{_event} {_title} {_date}");
    }
}
