using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    private static int menuOption;

    static void Main(string[] args)
    {
        do {

            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start listing activity");
            Console.WriteLine("\t3. Start reflecting activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu:");
            menuOption = int.Parse(Console.ReadLine());

            if(menuOption == 1) {
                Breathing breathing = new Breathing();
                breathing.WelcomeMessage();
                breathing.SetDuration();
                breathing.DisplayAnimation();
                breathing.BreatheInOut();
                breathing.DisplayEndingMessage();
            }
            else if(menuOption == 2) {
                Listing listing = new Listing();
                listing.WelcomeMessage();
                listing.SetDuration();
                listing.DisplayAnimation();
                listing.PromptQuestion();
                listing.DisplayEndingMessage();
            }
            else if(menuOption == 3) {
                Reflection reflection = new Reflection();
                reflection.WelcomeMessage();
                reflection.SetDuration();
                reflection.DisplayAnimation();
                reflection.ReflectionDisplay();
                reflection.DisplayEndingMessage();
            }
        } while (menuOption != 4);


    }
}