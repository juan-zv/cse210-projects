using System; 
using System.Collections.Generic;

public class Scripture
{
    private string[] _scripture;
    private List<Word> listOfWords = new List<Word>();


    public Scripture(string setScripture) {
        _scripture = setScripture.Split(" ");
        foreach(string word in _scripture){

            Word newWord = new Word(word);

            listOfWords.Add(newWord);
        }
    } 

    public void hideWords(){
        for (int i = 0; i < 5; i++)
        {
            Random randomNum = new Random();
            int index = randomNum.Next(0, _scripture.Length);

            if (listOfWords[index].getWord() == false){
                listOfWords[index].hideWord();
            }
            else{

            }
        }
    }


    public string[] getScripture(){
        return _scripture;
    }

    public void displayScripture(){
        foreach(Word word in listOfWords){
            Console.Write($"{word.getWordString()} ");
        }
        Console.WriteLine("");
    }
}