using System;

class EternalGoal : Goal
{
    public EternalGoal(string nameOfGoal, string description, int pointsToEarn):base(nameOfGoal, description,pointsToEarn){SetTypeOfGoal("EternalGoal");}
    
    public override void ShowGoal()
    {
        if(GetStatusOfGoal()){SetStatusOfGoalPrint("X");}
        else{ SetStatusOfGoalPrint(" ");}
        Console.WriteLine($"[{GetStatusOfGoalPrint()}] {GetNameOfGoal()} ({GetDescription()}) -- Times done: {GetTimesAcomplished()}");
    }
    
    
    public override void RecordEvent()
    {
        SetTimesAcomplishedValue(GetTimesAcomplished() + 1);
        SetTotalPoints(GetPointsToEarn()*GetTimesAcomplished());
    }
    
    
    public override string GenerateSaveString()
    {
        SetSaveString( $"{GetTypeOfGoal()}:{GetNameOfGoal()}:{GetDescription()}:{GetPointsToEarn()}:{GetTimesAcomplished()}");
        return GetSaveString();
    }

    
}
