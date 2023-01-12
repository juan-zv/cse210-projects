using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        int guess_num = 0;

        Console.WriteLine("What is the magic number? ");
        string magic_num = Console.ReadLine();
        
        while (guess_num != int.Parse(magic_num))
        {
            Console.WriteLine("What is your guess?");
            guess_num = int.Parse(Console.ReadLine());

            if (int.Parse(magic_num) > guess_num)
            {
                Console.WriteLine("Higher");
            }

            else if (int.Parse(magic_num) < guess_num)
            {
                Console.WriteLine("Lower");
            }
            else if (int.Parse(magic_num) == guess_num)
            {
                Console.WriteLine("You guessed it!");
            }

        }
    }
}