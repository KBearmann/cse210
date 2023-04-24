using System;

class Program
{
    static void Main(string[] args)
    {
        int[] validNumbers = { 1, 2, 3, 4, 5 };
        int action = 0;
        Console.Write("\n**** Welcome to the Journal App ****\n");
        // Create new journal reference/list
        Journal journal = new Journal();
        JournalPrompt jp = new JournalPrompt();

        while (action != 5)
        {
            // Ask for user input (1-5)
            //Call Choices
            action = Choices();

            switch (action)
            {
                case 1:
                    // Write Journal Entry
                    string entryId = GetEntryId();
                    string dateInfo = GetDateTime();
                    string prompt = jp.GetPrompt();

                    JournalEntry entry = new JournalEntry();
                    entry._entryNumber = entryId;
                    entry._dateTime = dateInfo;
                    entry._journalPrompt = prompt;

                    Console.Write($"{prompt}\n");
                    Console.Write(">>> ");
                    string userEntry = Console.ReadLine();
                    entry._journalEntry = userEntry;

                    journal._journal.Add(entry);

                    // Console.WriteLine("Success Choice 1!");
                    break;
                case 2:
                    // Display Journal Entries
                    journal.Display();
                    // Console.WriteLine("Success Choice 2!");
                    break;
                case 3:
                    // Load text file
                    journal.LoadJournalFile();
                    // Console.WriteLine("Success Choice 3!");
                    break;
                case 4:
                    // Save to text file
                    journal.CreateJournalFile();
                    // Console.WriteLine("Success Choice 4!");
                    break;
                case 5:
                    // Quite
                    Console.WriteLine("\nThank you for using the Journal App!\n");
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }

    static int Choices()
    // Method to display choices to user
    {
        string choices = @"
Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Quit
What would you like to do? ";

        Console.Write(choices);
        string userInput = Console.ReadLine();
        int action = 0;
        // This block catches any non integer values that are entered
        try
        {
            action = int.Parse(userInput);
        }
        catch (FormatException)
        {
            action = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return action;
    }

    static string GetDateTime()
    // Method to get the date and time for journal record
    {
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToString("F");
        // Console.WriteLine(now.ToString("F"));
        // Displays Saturday, March 01, 2008 7:00:00 AM
        return currentDateTime;
    }
    static void AddJournalEntry()
    // Method to add entry to text file
    {
        string MyJournalFile = "MyJournal.txt";
        File.AppendAllText(MyJournalFile, "");
    }

    static string GetEntryId()
    {
        Guid entryuuid = Guid.NewGuid();
        string entryuuidAsString = entryuuid.ToString();

        return entryuuidAsString;
    }


}
    }
}
