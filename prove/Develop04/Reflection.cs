using System;

class ReflectionActivity : Activity
{
    private List <string> _questions = new List<string>();
    private List <string> _prompts= new List<string>();
    private List <string> _trackOfQuestions = new List<string>();
    private Random _randomPrompt = new Random();
    private Random _randomQuestion = new Random();
    private int _tempIndex;
    private DateTime _startTime;
    private DateTime _futureTime;
    private DateTime _currentTime;
    public ReflectionActivity()
    {
        SetPrompts();
        SetQuestions();
        SetExplanation("This activity will help you to reflect on times in you life when you have shown strnght and resilienci. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }


    public void ReflectActivity()
    {
        SetActivity("Reflection");
        SetActivitySeconds(GetTime());
        SetActivityTime();
        Console.WriteLine("Considere the following prompt:");
        Console.WriteLine($"---{_prompts[_randomPrompt.Next(0,3)]}---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
        BeginningCountdown();
        _startTime = DateTime.Now;
        _futureTime = _startTime.AddSeconds(GetTime());
        _trackOfQuestions.Clear();
        while (_currentTime <= _futureTime)
        {
            Reflect();
            _currentTime = DateTime.Now;
        }
        SetFinish($"You have completed {GetTime()} seconds of the Reflecting Activity");
        FinishActivity();
    }

    public void Reflect()
    {
        _tempIndex = _randomQuestion.Next(0,8);
        if(!_trackOfQuestions.Contains(_questions[_tempIndex]))
        {
            Console.Write($"\n>{_questions[_tempIndex]}");
            WaitTime();
            _trackOfQuestions.Add(_questions[_tempIndex]);
        }
    }

    public void SetPrompts()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
    }
    public void SetQuestions()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times?");
        _questions.Add("What was your favorite thing?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void WaitTime()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("/");
            Console.Write("\b \b");
        }   
    }

}
