using System;

public class Document:Media
{
    private string[] _keywords;
    private string _fileFormat;
    private string _language;

    public Document(string type, string name, string author, string keywords, string fileFormat, string language):base(type, name, author){
        _keywords = keywords.Split(", ");
        _fileFormat = fileFormat;
        _language = language;
    }


}