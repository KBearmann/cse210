using System;

public class Entry
{
    public List<string> _answersFromPrompt = new List<String>();
    public PromptGenerator mainPrompt = new PromptGenerator();
    public FileManagement fileManagement = new FileManagement();
    public int questionIndex = 0;
    
    public Entry() 
    {
        mainPrompt.RandomQuestion();
    }

    public void NewEntry()
    {
        if (questionIndex >= 10 )
        {
            
            Console.WriteLine("There are no more questions for today\nDo you want to write something else? y/n");
            string moreEntries = Console.ReadLine();
            if (moreEntries == "y") //In case that the user wants to add different entries when the prompts ends
            {
                DateTime now = DateTime.Now;
                string date = now.ToShortDateString();
                Console.WriteLine("Please write your Entry");
                string answer = Console.ReadLine();
                _answersFromPrompt.Add("Date: " + date + " - Prompt: Personalized Entry" + "\n" + answer);
            }

        }
        else
        {
            DateTime now = DateTime.Now;
            string date = now.ToShortDateString();  
            Console.WriteLine(mainPrompt._listOfQuestions[questionIndex]); //Asking a question from the randomized list
            string answer = Console.ReadLine();
            _answersFromPrompt.Add("Date: " + date + " - Prompt: " + mainPrompt._listOfQuestions[questionIndex] + "\n" + answer);
            mainPrompt._askedQuestions.Add(mainPrompt._listOfQuestions[questionIndex]);
            questionIndex++;

        } 

    }

}
