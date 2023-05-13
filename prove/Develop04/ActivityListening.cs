using System;

class ListingActivity : Activity
{
    private List <string> _prompts = new List<string>();
    private List <string> _answers= new List<string>();
    private List <string> _totalAnswers= new List<string>();
    
    private Random _randomPrompt = new Random();
    private DateTime _startTime;
    private DateTime _futureTime;
    private DateTime _currentTime;
    private string _tempAnswer;

    public ListingActivity()
    {
        SetExplanation("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        SetPrompts();
    }

    public void ListActivity()
    {
        SetActivity("Listing");
        SetActivitySeconds(GetTime());
        SetActivityTime();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"---{_prompts[_randomPrompt.Next(0,4)]}---");
        BeginningCountdown();
        _startTime = DateTime.Now;
        _futureTime = _startTime.AddSeconds(GetTime());
        _answers.Clear();
        while(_currentTime <= _futureTime)
        {
            List();
            _currentTime = DateTime.Now;
        }
        SetFinish($"You have completed {GetTime()} seconds of the Reflecting Activity");
        Console.WriteLine($"You listed {_answers.Count()} items!");
        FinishActivity();

    }

    public void List()
    {
        Console.Write(">");
        _tempAnswer = Console.ReadLine();
        _answers.Add(_tempAnswer);   
        _totalAnswers.Add(_tempAnswer); 
    }
    public void SetPrompts()
    {
        _prompts.Add("Who do you appreciate?");
        _prompts.Add("What are personal weakness of yours?");
        _prompts.Add("Who have you helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your strenghts?");
    }

}
