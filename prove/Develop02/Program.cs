using System;

class Program
{
    static void Main(string[] args)
    {
        List<Entry> Lista = new List<Entry>();


        Entry Entrada = new Entry();

        Entrada.GetEntry();    

        Lista.Add(Entrada);

        Console.WriteLine(Lista[0]);


        Console.WriteLine("Hello, this is the journal program. Please select one of the following or 0 to quit the program: ");
        Console.WriteLine("1. Write an Entry");
        Console.WriteLine("2. Display the entries");
        Console.WriteLine("3. Save entries to a file");
        Console.WriteLine("4. Load entries from a file");

        int option = int.Parse(Console.ReadLine());

        if (option == 1) {
            
        }

    }
}