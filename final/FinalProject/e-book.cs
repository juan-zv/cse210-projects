using System;
public class Ebook:Media
{
    private int _ISBN;
    private string _genre;
    private string _summary;


    public Ebook(string type, string name, string author, int ISBN, string genre, string summary):base(type, name, author) {
        _ISBN = ISBN;
        _genre = genre;
        _summary = summary;
    }



}