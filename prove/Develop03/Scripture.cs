using System; 
using System.Collections.Generic;

public class Scripture
{
    private string[] _scripture;


    public Scripture(string setScripture) {
        _scripture = setScripture.Split(" ");
    } 


    public string[] getScripture(){
        return _scripture;
    }

    public void displayScripture(){
        foreach(string word in _scripture){
            Console.WriteLine(word);
        }
    }

    public string[] hideScripture(){
        Random random = new Random();
        int index = random.Next(0, _scripture.Length);
        Word rndWord = new Word(_scripture[index]);
// thinking that it would be better to hide items inside the lsit but how tho??
//through words class or through scriptures class        
        return ;
    }
}