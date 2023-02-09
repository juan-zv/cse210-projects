using System; 
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string paragraph = "This is a sample paragraph that you can use to test your memory.";
        string[] words = paragraph.Split(' ');
        int numberOfWords = words.Length;
        List<int> hiddenWords = new List<int>();
        Random random = new Random();

        while (hiddenWords.Count < numberOfWords)
        {
            int randomIndex = random.Next(0, numberOfWords);
            if (!hiddenWords.Contains(randomIndex))
            {
                hiddenWords.Add(randomIndex);
                words[randomIndex] = "_____";
            }
        }

        Console.WriteLine(string.Join(" ", words));
    }
}
