using System;

class Activity
{
    private int _time;
    private string _explanation;
    private string _finishMessage;
    private string _secondsQuestion = "How many seconds, would you like your session to be? ";
    private int _activitySeconds;
    private int _activityTimes;
    private string _chosedTime;
    private int _chosedTimeNumber;
    private string _activityName;
    private string _summaryComplete;

    public Activity(){}


    public Activity (int time)
    {
        _time = time;
    }

    public void StartActivity()
    {

    }

    public void SetExplanation(string explanation)
    {
        _explanation = explanation;
    }

    public string GetExplanation()
    {
        return _explanation;

    }

    public void SetFinish(string finish)
    {
        _finishMessage = finish;
    }

    public string GetFinish()
    {
        return _finishMessage;

    }
    public void SetTime(int time)
    {
        _time = time;
    }

    public int GetTime()
    {
        return _time;
    }

    public void SetActivityTime()
    {
        _activityTimes++;
    }

    public int GetActivityTime()
    {
        return _activityTimes;
    }

    public void SetActivitySeconds(int seconds)
    {
        _activitySeconds = _activitySeconds + seconds;
    }

    public int GetActivitySeconds()
    {
        return _activitySeconds;
    }

    public void SetActivityName(string name)
    {
        _activityName = name;
    }

    public string GetActivityName()
    {
        return _activityName;
    }

    public string GetSummary()
    {
        return _summaryComplete;
    }

    public int GetSeconds()
    {
        Console.Write(_secondsQuestion);
        _chosedTime = Console.ReadLine();
        _chosedTimeNumber = int.Parse(_chosedTime);
        return _chosedTimeNumber;
    }
    public void Ready()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        for(int i = 0; i<4;i++)
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

    public void ActivitySummary()
    {
        Console.WriteLine($"{GetActivityName()} Summary");
        Console.WriteLine($"Total time in Seconds: {GetActivitySeconds()}.");
        Console.WriteLine($"Total times performing activity: {GetActivityTime()}.");
        _summaryComplete = GetActivityName() + " Summary\nTotal time in Seconds: " + GetActivitySeconds() + "\nTotal times performing activity: " + GetActivityTime();
        
    }
    
    public void FinishActivity()
    {
        Console.WriteLine("Well Done!\n");
        for(int i = 0; i<4;i++)
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
        Console.WriteLine($"{GetFinish()}");
        for(int i = 0; i<4;i++)
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
    public void SetActivity(string activityname)
    {
        SetActivityName(activityname);
        Console.Clear();
        Console.WriteLine($"Welcome to the {GetActivityName()} Activity\n");
        Console.WriteLine($"{GetExplanation()}\n");
        SetTime(GetSeconds());
        Ready();

    }

    public void BeginningCountdown()
    {
        Console.Write("You may begin in: ");
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.WriteLine("\b \b");
        Console.Clear();
    }




}
