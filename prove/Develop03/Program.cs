using System; 
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string _userInput = ""; 
        
        Reference ref1 = new Reference("1 Nephi", 3, 7);

        Scripture scripture1 = new Scripture("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no bcommandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them.");

        Console.WriteLine("Hello this is a program that will help you memorize scriptures.");

        Console.WriteLine("If you want to change the verse you want to memorize type 'change':");

        _userInput = Console.ReadLine();

        if (_userInput == "change") {
            Console.WriteLine("What is the name of the book?");
            string _book = Console.ReadLine();

            Console.WriteLine("What is the chapter?");
            int _chapter = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the verse?");
            int _verse = int.Parse(Console.ReadLine());

            Reference inputRef = new Reference(_book, _chapter, _verse);

            Console.WriteLine("Type down the scripture:");
            string _userScripture = Console.ReadLine();

            Scripture inputScripture = new Scripture(_userScripture);

            Console.WriteLine("Press any key to hide words and press 'X' to exit the program.");

            while (_userInput != "x"){
                
                inputRef.displayReference();

                inputScripture.displayScripture();

                _userInput = Console.ReadLine();

                inputScripture.hideWords();
            }
        }

        else{
            Console.WriteLine("Press any key to hide words and press 'X' to exit the program.");

            while (_userInput != "x"){

                ref1.displayReference();

                scripture1.displayScripture();

                _userInput = Console.ReadLine();

                scripture1.hideWords();
            }
        }
    }
}
