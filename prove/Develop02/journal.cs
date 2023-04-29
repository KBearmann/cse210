using System;
using System.IO;


public class FileManagement
{
    public string _fileName = "Scriptures.txt";
    public List<string> _listManagement = new List<string>();
    public List<string> _promptTrack = new List<string>();
    public FileManagement()
    {

    }

    public void SaveFile()
    {
        using (StreamWriter outputFile  = new StreamWriter(@_fileName))
        {
            foreach (var index in _listManagement)
            {
                outputFile.WriteLine(index); // Save the File in the given File Namess
            }
        }   
    }

    public void LoadFile()
    {
        List<string> tempList = new List<string>();
        using (StreamReader inputFile = new StreamReader(@_fileName))
        {
            string line;
            while ((line = inputFile.ReadLine()) != null)
            {             
                tempList.Add(line); //Adding to a temporary list all the lines of the file
            }
        }
        for (int counter=0; counter < tempList.Count; counter = counter + 2) // fixing the index number of the list by adding the next index due the line jump
        {
            string newEntry = tempList[counter] + "\n" + tempList[counter+1];
            _listManagement.Add(newEntry);
            int firstIndex = newEntry.IndexOf("Prompt: ") + 8;
            int lastIndex = newEntry.IndexOf("?")+ 1;
            if (lastIndex > 0)
            {
                string question = newEntry.Substring(firstIndex, lastIndex - firstIndex); //Creating a list with all the questions that have been done so far.
                _promptTrack.Add(question);
            }
        }
    }
}
