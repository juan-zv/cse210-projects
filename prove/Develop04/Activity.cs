using System;
using System.IO;
using System.Collections.Generic;


public class Activity 
{ 
    private int _sessionDuration; 
    private string _welcomeMessage;
    private string _name;
    private string _description;
    private string _endingMessage;



    public Activity (string name, string description){
        _name = name;
        _description = description;
        _welcomeMessage = $"Welcome to the {_name} Activity!";
    }

    public void SetDuration() {
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int sessionDuration = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        _sessionDuration = sessionDuration;
    }

    public int GetDuration(){
        return _sessionDuration;
    }

    public void WelcomeMessage(){
        Console.WriteLine("");
        Console.WriteLine(_welcomeMessage);
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
    }

    public void DisplayEndingMessage(){
        Console.WriteLine("");
        Console.WriteLine($"You have completed {_sessionDuration} seconds of {_name} Activity");
        Console.WriteLine("");

    }

    public void DisplayAnimation (){
        
        Console.WriteLine("Get ready...");
        Console.WriteLine("");
        for(int i=0; i<3; i++){  
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b");
            
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b");
            
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b");
            
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b");
        }


    }
}
