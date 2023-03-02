using System; 
using System.Collections.Generic;

public class Word
{
    private string _word;

    public Word(string word){
        _word = word;
    }

    public string getWord(){
        return _word;
    }

    public string hideWord() {
        _word = "______";
        return _word;
    }

}