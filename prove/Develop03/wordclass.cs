using System;

class Word
{
    private string _word = "";

    public Word ()
    {
    
    }

    
    public Word (string word)                                        
    {
        HideLetters(word);
   
   }

    public string HideLetters(string word)
    {
        _word = word.Replace(word, new string('_',word.Length));   
        return _word;
   
   }
    public string GetWord ()                                       
    {
        return _word;
    }
}
