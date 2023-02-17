using System;

public class Entry 
{
    public string _entry = "";
    public string date = "";
    public string question = "";
    
    public Random random = new Random();
    public List<string> questions = new List<string>();

    public Entry () {
        
    }



    public void GetEntry()
    {

        questions.Add("How was your day?"); 
        questions.Add("What did you learn from today?");
        questions.Add("What was something bad that happened?");
        questions.Add("What do you expect for tomorrow?");
        
        int index = random.Next(questions.Count);

        question = questions[index];
        DateTime todaysDate = DateTime.Now;
        date = todaysDate.ToShortDateString();

        Console.WriteLine(question);

        _entry = Console.ReadLine();  
    }
}