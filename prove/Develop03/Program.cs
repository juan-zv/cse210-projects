using System; 
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("1 Nephi", 3, 7);
        ref1.displayReference();
        Scripture scripture1 = new Scripture("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no bcommandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them.");
        scripture1.hideScripture();


    }
}
