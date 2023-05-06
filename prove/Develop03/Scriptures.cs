using System;
using System.Windows;

class Scripture
{

    private List<string> _words = new List<string>();
    private Word _word = new Word();
    private string _content = "";
    private string _answer = "";
    private Random _rand = new Random();
    private int _index = 0;
    private int _counter = 0; 
    private int _changes = 0; 
    private string _answerHide = "";
    private int _answerHideNumber = 0;
    private string[] words = new string[] {};

    private List<int> _trackIndex = new List<int>();
    
  

    public Scripture(Reference reference, string scripture)
    {
        _content = scripture;
        Console.WriteLine("How many words do you want to hide every press of enter from 1-3");
        _answerHide = Console.ReadLine();
        _answerHideNumber = int.Parse(_answerHide);
        do
        {

            
            ShowScripture(reference);                                                             // Print Scripture
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");      // Ask user for input   
            _answer = Console.ReadLine();                                                // Receive the answer
            if(_changes == _words.Count && _words.Count > 0){_answer="quit";}            // check if the changes in list are completed
            HideWords();                                                                 

        } while (_answer != "quit");                                                     
    }

   
   
   private void HideWords()                                                             
    {
        _words.Clear();                                                                  
        words = _content.Split(" ");                                                    
        foreach (string word in words){_words.Add(word);}                               
        _counter = 0;                                                                    
        while(_counter < _answerHideNumber && _changes < _words.Count)                                  
        {
            _index = _rand.Next(_words.Count);                         
            if(_words[_index].Contains("_"))                                           
            {
                _index = _rand.Next(_words.Count);
            }
            else
            {
                _word = new Word(_words[_index]);                                       
                _words[_index] = _word.GetWord();                                       
                _counter++;                                                             
                _changes++;                                                             
            }
        }
        _content = String.Join(" ", _words);                                            
    }

    
    private void ShowScripture(Reference reference)                                                        
    { 
       
       
       Console.Clear();                                                              
        Console.Write(reference.GetReference());                                                                
        Console.WriteLine(" " + _content);                                                   
    }



}
