public class Lectures : Event
{
    string _speaker;
    int _capacity;
    public Lectures1(string speaker, int capacity) : base ("How to ride a bike","Mrs. Smith will teach how to properly ride a bike downhill.","November 19, 2015", "3 minutes")
    {
        _speaker = speaker;
        _capacity = capacity;
        _event = "Lecture";
        _address = new Address("E Pecan", "Mesa", "Arizona", "United States");
    }
}
