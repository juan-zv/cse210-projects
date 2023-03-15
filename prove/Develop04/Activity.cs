using System;


public class Activity 
{ 
    private int _sessionDuration; 

    private string _welcomeMessage;
    private string _name;
    private string _description;



    public Activity (string name, string description){

    }

    public int GetDuration (){
        return _sessionDuration;
    }

    public void SetDuration (int time) {
        _sessionDuration = time;
    }



    public void DisplayAnimation (){
        
        Console.WriteLine("Get ready...");

        for(int i=0; i<4; i++){  
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
