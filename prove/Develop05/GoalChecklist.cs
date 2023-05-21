using System;

class ChecklistGoal : Goal
{

    public ChecklistGoal(string nameOfGoal, string description, int pointsToEarn, int times, int bonus):base(nameOfGoal, description,pointsToEarn)
    {
        SetTimesToAcomplish(times);
        SetBonusPoints(bonus);
        SetTypeOfGoal("ChecklistGoal");
    }
   
   
   public override void ShowGoal()
    {
        if(GetStatusOfGoal()){SetStatusOfGoalPrint("X");}
        else{ SetStatusOfGoalPrint(" ");}
        Console.WriteLine($"[{GetStatusOfGoalPrint()}] {GetNameOfGoal()} ({GetDescription()}) -- Currently complete: {GetTimesAcomplished()}/{GetTimesToAcomplish()}");
    }
    
    
    public override void RecordEvent()
    {
        SetTimesAcomplished();
        
        if(GetTimesAcomplished() == GetTimesToAcomplish())
        {
            SetStatusOfGoal(true);
            SetTotalPoints((GetPointsToEarn()*GetTimesToAcomplish())+GetBonusPoints());
        }
        else
        {
            SetTotalPoints(GetPointsToEarn()*GetTimesAcomplished());
        }
    }
    
    
    public override string GenerateSaveString()
    {
        SetSaveString( $"{GetTypeOfGoal()}:{GetNameOfGoal()}:{GetDescription()}:{GetPointsToEarn()}:{GetStatusOfGoal()}:{GetBonusPoints()}:{GetTimesToAcomplish()}:{GetTimesAcomplished()}");
        return GetSaveString();
    }



    
}
