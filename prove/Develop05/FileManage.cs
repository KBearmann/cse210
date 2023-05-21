using System;
using System.IO;


public class FileManagement
{
    private string _fileName;
    
    private List<string> _goals = new List<string>();
    private List<string> _loadList = new List<string>();
    private string line;
    
    public FileManagement()
    {

    }
    public void SetGoals(string goal)
    {
        _goals.Add(goal);
    }
    public void SetFileName(string name)
    {
        _fileName = name;
    }
    public void ClearList()
    {
        _goals.Clear();
    }
    public List<string> GetLoaded()
    {
        return _loadList;
    }

    public void SaveFile()
    {
        using (StreamWriter outputFile  = new StreamWriter(@_fileName))
        {
            foreach (var index in _goals)
            {
                outputFile.WriteLine(index);                            
            }
        }   
    }

    public void LoadFile(string fileName)
    {
        _fileName = fileName;
        using (StreamReader inputFile = new StreamReader(@_fileName))
        {
            while ((line = inputFile.ReadLine()) != null)
            {             
                _loadList.Add(line);                          
            }
        }
    }
}

