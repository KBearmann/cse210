using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");
        Console.Clear();
        List<Activity> activitiesList = new List<Activity>();
        activitiesList.Add(new Running(3, "November 19", 42));
        activitiesList.Add(new Cycling(23, "July 4", 25));
        activitiesList.Add(new Swimming(10, "July 5", 18));
        foreach (Activity a in activitiesList)
        {
            a.Summary();
        }
    }
}
