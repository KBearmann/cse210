using System;

public abstract class Goal
{
    
    
    private string _nameOfGoal;
    private string _description;
    private int _pointsToEarn;
    private bool _statusOfGoal;
    private string _statusOfGoalPrint;
    private string _typeOfGoal;
    private int _timesToAcomplish;
    private int _timesAcomplished;
    private int _bonusPoints;
    private string _saveString;
    private int _totalPointsGoal;
    
    
    
    public Goal(){}
    public Goal(string nameOfGoal, string description, int pointsToEarn)
    {
        SetNameOfGoal(nameOfGoal);
        SetDescription(description);
        SetPointsToEarn(pointsToEarn);
    }
    
    
    public void SetNameOfGoal(string name){_nameOfGoal = name;}
    public string GetNameOfGoal(){return _nameOfGoal;}
    public void SetDescription(string description){_description = description;}
    public string GetDescription(){return _description;}
    public void SetPointsToEarn(int points){_pointsToEarn = points;}
    public int GetPointsToEarn(){return _pointsToEarn;}
    public void SetStatusOfGoal(bool status){_statusOfGoal = status;}
    public bool GetStatusOfGoal(){return _statusOfGoal;}
    public void SetStatusOfGoalPrint(string status){_statusOfGoalPrint = status;}
    public string GetStatusOfGoalPrint(){return _statusOfGoalPrint;}
    public void SetSaveString(string newString){_saveString= newString;}
    public string GetSaveString(){return _saveString;}
    public void SetTypeOfGoal(string type){_typeOfGoal = type;}
    public string GetTypeOfGoal(){return _typeOfGoal;}
    public void SetTimesToAcomplish(int timesTo){_timesToAcomplish = timesTo;}
    public int GetTimesToAcomplish(){return _timesToAcomplish;}
    public void SetTimesAcomplished(){_timesAcomplished ++;}
    public void SetTimesAcomplishedValue(int times){_timesAcomplished = times;}
    public int GetTimesAcomplished(){return _timesAcomplished;}
    public void SetBonusPoints(int bonus){_bonusPoints = bonus;}
    public int GetBonusPoints(){return _bonusPoints;}
    public void SetTotalPoints(int points){_totalPointsGoal = points;}
    public int GetTotalPoints(){return _totalPointsGoal;}
    public abstract void ShowGoal();
    public abstract void RecordEvent();
    public abstract string GenerateSaveString();
}
