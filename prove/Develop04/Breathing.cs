using System;

public class Breathing:Activity
{
    private string _name;
    private string _description;

    public Breathing(){

    }




    public int BreatheInOut() {
        Console.Write("Breathe in...");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b");


        Console.WriteLine("Now breathe out...");
        Console.Write("6");
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.WriteLine("");
        return 10;
    }


}

