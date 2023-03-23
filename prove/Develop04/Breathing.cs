using System;
using System.IO;
using System.Collections.Generic;

public class Breathing:Activity
{

    public Breathing() :base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."){
    }

    public void BreatheInOut() {
        TimeSpan duration = TimeSpan.FromSeconds(GetDuration());
        DateTime startTime = DateTime.Now;

        while (DateTime.Now - startTime < duration) {

            Console.Write("Breathe in...");
            Console.WriteLine("");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i - 1);
                Thread.Sleep(1000);
                Console.Write("\b\b");
            }

            Console.Write("\nNow breathe out...");
            Console.WriteLine("");
            for (int i = 7; i > 0; i--)
            {
                Console.Write(i - 1);
                Thread.Sleep(1000);
                Console.Write("\b\b");
            }

            Console.WriteLine("");
        }
    }

}

