using System;

class BreathingActivity : Activity
{
    private DateTime _startTime;
    private DateTime _futureTime;
    private DateTime _currentTime;
    public BreathingActivity()
    {
        SetExplanation("This Activity will help you relax by by teaching you how to breath. Clear your mind and focus on your breathing.");

    }

   
   
   public void BreathActivity()
    {
        SetActivity("Breathing");
        SetActivitySeconds(GetTime());
        SetActivityTime();
        _startTime = DateTime.Now;
        _futureTime = _startTime.AddSeconds(GetTime());

        while (_currentTime <= _futureTime)
        {
            BreathIn();
            BreathOut();
            Console.Write("\n");
            _currentTime = DateTime.Now;
        }
        SetFinish($"You have completed {GetTime()} seconds of the Breathing Activity");
        FinishActivity();
    }

   
   
   private void BreathIn()
    {
            Console.Write("Breath In ... ");
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
    }
  
  
  private void BreathOut()
    {
            Console.Write("Now Breath Out ... ");
            Console.Write("6");
            Thread.Sleep(1000);
            Console.Write("\b \b");
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
    }




}
