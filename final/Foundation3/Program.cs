using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        int choice = 0;
        int numberChoice = 0;
        int numberChoice2 = 0;
        int numberChoice3 = 0;
        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("What kind of description do you want to see?");
            Console.WriteLine("1: Standard Details");
            Console.WriteLine("2: Full Details");
            Console.WriteLine("3: Short description");
            Console.Write("> ");
            choice = Convert.ToInt16(Console.ReadLine());
            if (choice == 1)
            {
                while (numberChoice != 4)
                {
                    Console.Clear();
                    Console.WriteLine("What type of event would you like to see?");
                    Console.WriteLine("1: Lecture");
                    Console.WriteLine("2: Reception");
                    Console.WriteLine("3: Outdoor");
                    Console.Write("> ");
                    numberChoice = Convert.ToInt16(Console.ReadLine());
                    if (numberChoice == 1)
                    {
                        Lectures1 l = new Lectures1("Mrs. Smith", 31);
                        l.Standard();
                        Console.ReadLine();
                    }
                    else if (numberChoice == 2)
                    {
                        Receptions r = new Receptions();
                        r.Standard();
                        Console.ReadLine();
                    }
                    else if (numberChoice == 3)
                    {
                        Outdoor o = new Outdoor("Sunny and warm");
                        o.Standard();
                        Console.ReadLine();
                    }
                }
            }
            else if (choice == 2)
            {
                Console.Clear();
                Console.WriteLine("What type of event would you like to see?");
                Console.WriteLine("1: Lecture");
                Console.WriteLine("2: Reception");
                Console.WriteLine("3: Outdoor");
                Console.Write("> ");
                numberChoice2 = Convert.ToInt16(Console.ReadLine());
                    if (numberChoice2 == 1)
                    {
                        Lectures1 l = new Lectures1("Mrs. Smith", 31);
                        l.Full();
                        Console.WriteLine("Speaker: Mrs. Smith Capacity: 31");
                        Console.ReadLine();

                    }
                    else if (numberChoice2 == 2)
                    {
                        Receptions r = new Receptions();
                        r.Full();
                        Console.WriteLine("Email: egggirl23@gmail.com");
                        Console.ReadLine();
                    }
                    else if (numberChoice2 == 3)
                    {
                        Outdoor o = new Outdoor("Sunny and warm");
                        o.Full();
                        Console.WriteLine("Weather: Sunny and warm");
                        Console.ReadLine();
                    }
            }
            else if (choice == 3)
            {
                Console.Clear();
                Console.WriteLine("What type of event would you like to see?");
                Console.WriteLine("1: Lecture");
                Console.WriteLine("2: Reception");
                Console.WriteLine("3: Outdoor");
                Console.Write("> ");
                numberChoice3 = Convert.ToInt16(Console.ReadLine());
                    if (numberChoice3 == 1)
                    {
                        Lectures1 l = new Lectures1("Mrs. Smith", 31);
                        l.ShortDesc();
                        Console.ReadLine();

                    }
                    else if (numberChoice3 == 2)
                    {
                        Receptions r = new Receptions();
                        r.ShortDesc();
                        Console.ReadLine();
                    }
                    else if (numberChoice3 == 3)
                    {
                        Outdoor o = new Outdoor("Sunny and warm");
                        o.ShortDesc();
                        Console.ReadLine();
                    }
            }
        }
    }
}
