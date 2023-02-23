using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Random rand = new Random();
        List<string> prompts = new List<string>();
        List<string> responses = new List<string>();
        prompts.Add("What was something that made you feel happy?");
        prompts.Add("What was something that made you feel sad? Why?");
        prompts.Add("How did you see the hand of the Lord in your life today?");
        prompts.Add("If you could repeat something from today, what would it be?");
    
        int choice = 0;
        do
        {
        
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice:");
                    
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (choice== 1)
            {
                Entry entry = new Entry();
                
                int index = rand.Next(prompts.Count);
                System.Console.WriteLine(prompts[index]);
                entry.prompt = prompts[index];
                
                string response = Console.ReadLine();
                
                responses.Add(response);
                entry.response = response;
                journal.entries.Add(entry);

                
                foreach(string answer in responses)
                {
                    System.Console.WriteLine("Response: " + answer);
                }


            }
            else if(choice == 2){
                journal.DisplayJournal();

            }
            else if(choice == 3){
                Console.WriteLine("what is the file name?");
                string filename = Console.ReadLine();
                journal.SaveJournal(filename);

            }
            else if(choice == 4){
                Console.WriteLine("what is the file name?");
                string filename = Console.ReadLine();
                journal.LoadJournal(filename);
            }


        } while (choice != 5);
    }    
        
}