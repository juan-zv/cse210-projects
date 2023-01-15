using System;

class Program
{

    static void DIsplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static int SquareNumbers(int num)
    {
        int square = num * num;
        return square;
    }

    static void Main(string[] args)
    {
        string name = PromptUserName();
        int number = SquareNumbers(PromptUserNumber());
        Console.WriteLine($"{name}, the square of your number is {number}");
    }

}