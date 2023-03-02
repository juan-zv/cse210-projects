using System; 
using System.Collections.Generic;

public class Reference {
    private string _book;
    private int _chapter;
    private int _verse;

    public Reference (string setBook, int setChapter, int setVerse){
        _book = setBook;
        _chapter = setChapter;
        _verse = setVerse;
    }

    public void displayReference(){
        Console.WriteLine($"{_book} {_chapter}: {_verse}");
    }
}