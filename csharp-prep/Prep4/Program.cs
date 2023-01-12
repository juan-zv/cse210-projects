using System;

class Program
{
    static void Main(string[] args)
    {
        int num_list = -1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");


        do{
            Console.WriteLine("Enter number: ");
            num_list = int.Parse(Console.ReadLine());
            numbers.Add(num_list);
        } while (num_list != 0);

        Console.WriteLine(numbers);
    }
}