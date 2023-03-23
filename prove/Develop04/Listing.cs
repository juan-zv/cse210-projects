using System;
using System.IO;
using System.Collections.Generic;

public class Listing:Activity
{
    private string[] _promptList = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _listedThings = new List<string>();

    public Listing() :base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."){
    }

    public void PromptQuestion(){
        Random randomNum = new Random();
        int randomIndex = randomNum.Next(0, _promptList.Length);

        TimeSpan duration = TimeSpan.FromSeconds(GetDuration());
        DateTime startTime = DateTime.Now;

        Console.WriteLine("Think about this prompt for a couple of secconds:");
        Console.WriteLine(_promptList[randomIndex]);
        Thread.Sleep(5000);
        Console.WriteLine("");

        Console.WriteLine("Enter all the things you have in mind about this");
        while (DateTime.Now - startTime < duration) {
            string userInput = Console.ReadLine();
            _listedThings.Add(userInput);
        }

        Console.WriteLine("Would you like to save this list into a file? Yes/No");
        string userInput1 = Console.ReadLine();
        if (userInput1 == "Yes" || userInput1 == "yes" || userInput1 == "YES") {
            File.WriteAllLines("list.txt", _listedThings);
        }

    }

}