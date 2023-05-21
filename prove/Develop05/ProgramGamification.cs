using System;

class GamificationProgram
{
    private List<Goal> _listOfGoals = new List<Goal>();
    private int _totalPoints;
    private string _nameOfGoalProg;
    private string _descriptionProg;
    private int _pointsToEarnProg;
    private string _pointsToEarnString;
    private string _bonusPointsString;
    private int _bonusPoints;
    
    private string _timesToAcomplishString;
    private int _timesToAcomplish;
    private int _typeOfGoal;
    private string _optionAnswer;
    private int _optionAnswerNumber;
    private string _goalAnswer;
    
    private string _continue;
    private int _counter = 1;
    private int _counterEvent = 1;
    private string _acomplishAnswerString;
    private int _acomplishAnswer;
    private FileManagement _fileManagement = new FileManagement();
    private List<string> _conversionList = new List<string>();
    private List<string>_loadedList = new List<string>();
    private List<string> _divideString = new List<string>();
    SimpleGoal _mySimpleGoal;
    EternalGoal _myEternalGoal;
    ChecklistGoal _myChecklistGoal;
    
    public GamificationProgram()
    {
        do
        {
            Console.Clear();
            Console.WriteLine($"You have {_totalPoints} points.\nMenu Options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit\nSelect a choice from the Menu: ");
            _optionAnswer = Console.ReadLine();
            _optionAnswerNumber = int.Parse(_optionAnswer);
            if(_optionAnswerNumber!= 6)
            {
                switch(_optionAnswerNumber)
                {
                    case 1:
                    CreateNewGoal();
                    break;

                    case 2:
                    if (!_listOfGoals.Any())
                    {
                        Console.WriteLine("You do not have any goal so far, please load a file or create new Goals\nPress Enter to Continue");
                        _continue = Console.ReadLine();
                    }
                    else
                    {
                        _counter=1;
                        foreach (Goal goal in _listOfGoals)
                        {
                            Console.Write($"{_counter}. ");
                            goal.ShowGoal();
                            _counter++;
                        }
                        Console.Write("Press Enter to Continue");
                        _continue = Console.ReadLine();
                    }
                    break;

                    case 3:
                    ConvertGoals();
                    Console.Write("What is the filename for the goal file, include the .txt extension at the end ");
                    _fileManagement.SetFileName(Console.ReadLine());
                    _fileManagement.SaveFile();
                    
                    break;
                    
                    case 4:
                    Console.Write("What is the filename for the goal file, include the .txt extension at the end ");
                    _fileManagement.LoadFile(Console.ReadLine());
                    _loadedList = _fileManagement.GetLoaded();
                    LoadGoals(_loadedList);
                    CalculateTotal();
                    break;

                    case 5:
                    RecordEvents();
                    break;
                }
            }
        }while (_optionAnswerNumber != 6);
    }
    public void CreateNewGoal()
    {
        Console.Write("The types of Goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal\nWhich type of goal would you like to create?: ");
        _goalAnswer = Console.ReadLine();
        _typeOfGoal=int.Parse(_goalAnswer);
        Console.Write("What is the name of your goal?  ");
        _nameOfGoalProg = Console.ReadLine();
        Console.Write("What is a description of the goal?  ");
        _descriptionProg = Console.ReadLine();
        Console.Write("What is the amount of points this goal worth? ");
        _pointsToEarnString = Console.ReadLine();
        _pointsToEarnProg = int.Parse(_pointsToEarnString);
        if(_typeOfGoal == 3)
        {
            Console.Write("How many times does this goal need to be done for a bonus? ");
            _timesToAcomplishString = Console.ReadLine();
            _timesToAcomplish = int.Parse(_timesToAcomplishString);
            Console.Write("What is the bonus for accoplish that many times? ");
            _bonusPointsString = Console.ReadLine();
            _bonusPoints = int.Parse(_bonusPointsString);
        }
        switch(_typeOfGoal)
        {
            case 1:
            _mySimpleGoal = new SimpleGoal(_nameOfGoalProg, _descriptionProg, _pointsToEarnProg);
            _listOfGoals.Add(_mySimpleGoal);
            break;

            case 2:
            _myEternalGoal = new EternalGoal(_nameOfGoalProg, _descriptionProg, _pointsToEarnProg);
            _listOfGoals.Add(_myEternalGoal);
            break;

            case 3:
            _myChecklistGoal = new ChecklistGoal(_nameOfGoalProg, _descriptionProg, _pointsToEarnProg, _timesToAcomplish, _bonusPoints);
            _listOfGoals.Add(_myChecklistGoal);
            break;
        }
    }

    public void RecordEvents()
    {
        _counterEvent = 1;
        Console.WriteLine("The Goals are:");
        foreach(Goal goal in _listOfGoals)
        {
            Console.WriteLine($"{_counterEvent}.- {goal.GetNameOfGoal()}");
            _counterEvent++;
        }
        Console.Write("Which Goal did you Accomplish? ");
        _acomplishAnswerString = Console.ReadLine();
        _acomplishAnswer = int.Parse(_acomplishAnswerString);
        if(_listOfGoals[_acomplishAnswer-1].GetStatusOfGoal())
        {
            Console.WriteLine("You Already Completed this goal\nPress Enter to Continue"); 
            _continue = Console.ReadLine();   
        }
        else
        {
            _listOfGoals[_acomplishAnswer-1].RecordEvent();
            Console.WriteLine($"Congratulations! You have earned {_listOfGoals[_acomplishAnswer-1].GetPointsToEarn()} points!\nPress Enter to Continue");
            if(_listOfGoals[_acomplishAnswer-1].GetTimesAcomplished() == _listOfGoals[_acomplishAnswer-1].GetTimesToAcomplish() && _listOfGoals[_acomplishAnswer-1].GetStatusOfGoal())
            {
                Console.WriteLine($"You also won a bonus of {_listOfGoals[_acomplishAnswer-1].GetBonusPoints()}!");
            }
            _continue = Console.ReadLine();  
        }
        CalculateTotal();
    }

    public void ConvertGoals()
    {
        _fileManagement.ClearList();
        foreach (Goal goal in _listOfGoals)
        {
            _fileManagement.SetGoals(goal.GenerateSaveString());
        }
    }

    public void CalculateTotal()
    {
        _totalPoints = 0;
        foreach (Goal goalcount in _listOfGoals)
        {
            _totalPoints = _totalPoints + goalcount.GetTotalPoints();
        }
    }

    public void LoadGoals(List<string> loadlist)
    {
        foreach(string goal in loadlist)
        {
            _divideString = goal.Split(":").ToList();
            switch(_divideString[0])
            {
                case "EternalGoal":
                _myEternalGoal = new EternalGoal(_divideString[1], _divideString[2], int.Parse(_divideString[3]));
                _myEternalGoal.SetTimesAcomplishedValue(int.Parse(_divideString[4]));
                _myEternalGoal.SetTotalPoints(_myEternalGoal.GetPointsToEarn()*_myEternalGoal.GetTimesAcomplished());
                _listOfGoals.Add(_myEternalGoal);
                break;
                
                case "SimpleGoal":
                _mySimpleGoal = new SimpleGoal(_divideString[1], _divideString[2], int.Parse(_divideString[3]));
                _mySimpleGoal.SetStatusOfGoal(bool.Parse(_divideString[4]));
                if(_mySimpleGoal.GetStatusOfGoal()){_mySimpleGoal.SetTotalPoints(_mySimpleGoal.GetPointsToEarn());}
                _listOfGoals.Add(_mySimpleGoal);
                break;
                
                case "ChecklistGoal":
                _myChecklistGoal = new ChecklistGoal(_divideString[1], _divideString[2], int.Parse(_divideString[3]), int.Parse(_divideString[6]), int.Parse(_divideString[5]));
                _myChecklistGoal.SetTimesAcomplishedValue(int.Parse(_divideString[7]));
                _myChecklistGoal.SetStatusOfGoal(bool.Parse(_divideString[4]));
                if(_myChecklistGoal.GetStatusOfGoal()){_myChecklistGoal.SetTotalPoints((_myChecklistGoal.GetBonusPoints()+(_myChecklistGoal.GetPointsToEarn()*_myChecklistGoal.GetTimesAcomplished())));}
                else{_myChecklistGoal.SetTotalPoints(_myChecklistGoal.GetPointsToEarn()*_myChecklistGoal.GetTimesAcomplished());}
                _listOfGoals.Add(_myChecklistGoal);
                break;
            }
        }

    }
}
