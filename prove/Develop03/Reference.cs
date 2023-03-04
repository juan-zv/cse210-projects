using System; 
using System.Collections.Generic;

public class Reference {
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;

    public Reference (string setBook, int setChapter, int setVerse){
        _book = setBook;
        _chapter = setChapter;
        _verse = setVerse;
        _endVerse = null;
    }

public Reference (string setBook, int setChapter, int setVerse, int setEndVerse){
        _book = setBook;
        _chapter = setChapter;
        _verse = setVerse;
        _endVerse = setEndVerse;
    }

    public void displayReference(){
        Console.Write($"{_book} {_chapter}: {_verse}");
        if(_endVerse != null){
            Console.Write($"- {_endVerse}");
        }
        Console.WriteLine("");
    }
}