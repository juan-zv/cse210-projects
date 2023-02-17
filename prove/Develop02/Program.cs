using System;

class Program
{
    static void Main(string[] args)
    {
        List<Entry> Lista = new List<Entry>();


        Entry Entrada = new Entry();

        int option = 5;



        do{ 
        Console.WriteLine("Hello, this is the journal program. Please select one of the following or 0 to quit the program: ");
        Console.WriteLine("0. Quit");
        Console.WriteLine("1. Write an Entry");
        Console.WriteLine("2. Display the entries");
        Console.WriteLine("3. Save entries to a file");
        Console.WriteLine("4. Load entries from a file");
        Console.WriteLine("");


        option = int.Parse(Console.ReadLine());

        if (option == 1) {
            Entrada.GetEntry();

            Lista.Add(Entrada);

            Console.WriteLine("");

            
        }

        else if (option == 2) {
            Console.WriteLine(Lista[0]);
            Console.WriteLine("");

        }

        else if (option == 3) {
            Console.WriteLine("Option 3");
            Console.WriteLine("");
        }


        else if (option == 4) {
            Console.WriteLine("Option 4");
            Console.WriteLine("");

        }

        else {
            Console.WriteLine("Please select a valid option");
            Console.WriteLine("");
        }

        } while (option != 0);

    }
}