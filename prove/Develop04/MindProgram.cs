using System;

class MindfulnessProgram
{
    private string _answer;
    private int _numberAnswer;
    private BreathingActivity _breathActivity = new BreathingActivity();
    private ReflectionActivity _reflectionActivity = new ReflectionActivity();
    private ListingActivity _listingActivity = new ListingActivity();
    private FileManagement _fileManagement = new FileManagement();


    public MindfulnessProgram ()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n 1. Start breathing activity\n 2. Start reflecting activity\n 3. Start listing activity\n 4. Activity Summary\n 5. Export Summary\n 6. Quit");
            _answer = Console.ReadLine();
            _numberAnswer=int.Parse(_answer);
            if(_numberAnswer != 6)
            {
            
                switch(_numberAnswer)
                {
                    case 1:
                    _breathActivity.BreathActivity();
                    break;

                    case 2:
                    _reflectionActivity.ReflectActivity();
                    break;

                    case 3:
                    _listingActivity.ListActivity();
                    break;

                    case 4:
                    _breathActivity.ActivitySummary();
                    _reflectionActivity.ActivitySummary();
                    _listingActivity.ActivitySummary();
                    Thread.Sleep(5000);
                    break;

                    case 5:
                    Console.WriteLine("Choose a file name");
                    _fileManagement.SetFileName(Console.ReadLine()+".txt");
                    _fileManagement.SetSummarys(_breathActivity.GetSummary());
                    _fileManagement.SetSummarys(_reflectionActivity.GetSummary());
                    _fileManagement.SetSummarys(_listingActivity.GetSummary());
                    _fileManagement.SaveFile();
                    break;

                }
            }
        }while(_numberAnswer != 6);
    }



}
