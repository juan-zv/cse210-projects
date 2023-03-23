using System;
using System.IO;
using System.Collections.Generic;

public class Reflection:Activity
{
    private string[] _reflectionSentences = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private string[] _reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection() :base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."){
    }

    public void ReflectionDisplay(){

        Random randomNum = new Random();
        int randomIndexSentences = randomNum.Next(0, _reflectionSentences.Length);

        TimeSpan duration = TimeSpan.FromSeconds(GetDuration());
        DateTime startTime = DateTime.Now;

        Console.WriteLine(_reflectionSentences[randomIndexSentences]);
        Thread.Sleep(5000);
        Console.WriteLine("");
        
        while (DateTime.Now - startTime < duration) {

            Console.WriteLine(_reflectionQuestions[0]);
            for(int j=0; j<3; j++) {
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
}