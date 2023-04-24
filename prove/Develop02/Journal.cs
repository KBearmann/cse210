using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Journal
{
    // variables
    public List<JournalEntry> _journal = new List<JournalEntry>();
    // private string fileName = "MyJournal.txt";
    private string _userFileName;


    // method
    public Journal()
    {
    }

    // A method that displays each journal entry
    public void Display()
    {
        Console.WriteLine("\n************** Journal Entries **************");
        foreach (JournalEntry journalEntry in _journal)
        {
            journalEntry.Display();
        }
        Console.WriteLine("\n******************** End ********************");
    }

    public void CreateJournalFile()
    // Method to check if txt file is created if not create one
    {
        Console.Write("What your file name? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (!File.Exists(_userFileName))
        {
            File.CreateText(_userFileName);
            Console.Write($"\n*** {_userFileName} has been created! ***\n");
            Console.Write("***  Your journal entries have been saved. ***\n");
            SaveJournalFile(_userFileName);
            CreateJSON(userInput);
        }
        else
        {
            Console.Write($"\n*** {_userFileName} already exits. ***\n");
            Console.Write("***  Your journal entries have been added. ***\n");
            AppendJournalFile(_userFileName);
        }
    }
    public void SaveJournalFile(string _userFileName)
    // Method to save journal to txt file 
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName))
        {
            foreach (JournalEntry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._entryNumber}; {journalEntry._dateTime}; {journalEntry._journalPrompt}; {journalEntry._journalEntry}");
            }
        }
    }

    public void AppendJournalFile(string _userFileName)
    // Method to save a new entry to journal txt file 
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName, append: true))
        {
            foreach (JournalEntry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._entryNumber}; {journalEntry._dateTime}; {journalEntry._journalPrompt}; {journalEntry._journalEntry}");
            }
        }
    }

    public void LoadJournalFile()
    // Method to check if txt file is created and load it into the list.  
    // This should replace any current info in the list
    {
        Console.Write("What your file name? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (File.Exists(_userFileName))
        {
            List<string> readText = File.ReadAllLines(_userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                JournalEntry entry = new JournalEntry();

                entry._entryNumber = entries[0];
                entry._dateTime = entries[1];
                entry._journalPrompt = entries[2];
                entry._journalEntry = entries[3];

                _journal.Add(entry);
            }
        }
    }


    public void CreateJSON(string userInput)
    // Method to create a JSON file 
    {
        string fileName = userInput + ".json";
        List<JsonItem> _data = new List<JsonItem>();

        foreach (JournalEntry journalEntry in _journal)
        {
            _data.Add(new JsonItem()
            {
                ID = journalEntry._entryNumber,
                Date = journalEntry._dateTime,
                Prompt = journalEntry._journalPrompt,
                Entry = journalEntry._journalEntry
            });
        }

        string json = JsonSerializer.Serialize(_data);
        File.WriteAllText(fileName, json);
    }

}
