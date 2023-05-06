using System;

class ScriptureManagement
{
    private string _fileName = "Scriptures.txt";
    private List<string> _listReferences = new List<string>();
    private List<string> _listScriptures = new List<string>();
    private List<string> _tempList = new List<string>();
    private string line;
    private string _answer="";
    private int _answerNumber = 0;
    private int _counter = 1;
    private string _tempScripture = "";
    private string _selectedReference = "";
    private string _selectedScripture = "";
    
    public ScriptureManagement()
    {
        LoadFile();
        ShowReference();
    }
    public void LoadFile()
    {
        
        using (StreamReader inputFile = new StreamReader(@_fileName))
        {
            
            while ((line = inputFile.ReadLine()) != null)
            {
                string[] _temp = line.Split(';', 2);     
                foreach (var text in _temp)
                {_tempList.Add(text);}
            }
        }
        for (int counter=0; counter < _tempList.Count; counter = counter + 2)           
        {
            _listReferences.Add(_tempList[counter]);
            _tempScripture = _tempList[counter + 1];
            _tempScripture = _tempScripture.Remove(0,1);
            
            _listScriptures.Add(_tempScripture);


        }
    }
    public void ShowReference()
    {
        Console.Clear();   
        Console.WriteLine("Please chose one of the next Scriptures");
        foreach (var refer in _listReferences)
        {

            Console.WriteLine(_counter + ".-" + refer);
            _counter++;
        }
        _answer = Console.ReadLine();
        _answerNumber = int.Parse(_answer);
        for ( int i = 0; i <_listReferences.Count; i++)
        {
            if (_answerNumber ==  i+1)
            {
                _selectedReference = _listReferences[i];
                _selectedScripture = _listScriptures[i];
            }
        }
    }

    public string GetSelecterReference(){ return _selectedReference;}
    public string GetSelecterScripture(){ return _selectedScripture;}

}
