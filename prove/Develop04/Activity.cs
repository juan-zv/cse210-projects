using System;


public class Activity 
{ 
    private int _sessionDuration; 

    public Activity (){

    }

    public int getDuration (){
        return _sessionDuration;
    }

    public void displayAnimation (){
        
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
