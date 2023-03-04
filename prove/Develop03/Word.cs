using System; 
using System.Collections.Generic;

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word){
        _word = word;
        _isHidden = false;
    }

    public bool getWord(){
        return _isHidden;
    }

    public string getWordString(){
        return _word;
    }

    public string hideWord() {
        if (_isHidden == false){
            _word = "______";
            _isHidden = true;
        }
        
        return _word;
    }

}