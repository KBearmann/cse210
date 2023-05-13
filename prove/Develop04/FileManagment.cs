using System;
using System.IO;


public class FileManagement
{
    private string _fileName;
    private List<string> _summarys = new List<string>();
    private List<string> _promptTrack = new List<string>();
    public FileManagement()
    {

    }
    public void SetSummarys(string summary)
    {
        _summarys.Add(summary);
    }
    public void SetFileName(string name)
    {
        _fileName = name;
    }

    public void SaveFile()
    {
        using (StreamWriter outputFile  = new StreamWriter(@_fileName))
        {
            foreach (var index in _summarys)
            {
                outputFile.WriteLine(index);                            
            }
        }   
    }

    
}

