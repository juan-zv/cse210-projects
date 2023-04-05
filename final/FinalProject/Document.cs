using System;

public class Document:Media
{
private string _keywords;
private string _fileFormat;
private string _language;
public Document(string type, string name, string author, string keywords, string fileFormat, string language):base(type, name, author){
    _keywords = keywords;
    _fileFormat = fileFormat;
    _language = language;
}
public override void DisplayMedia()
{
    
    if (_keywords != " "){
        Console.WriteLine($"{GetType()}: {GetName()} by: {GetAuthor()} || Language:{_language} || Keywords:{_keywords} || Added: {GetDate()}");
    }
    else{
        Console.WriteLine($"{GetType()}: {GetName()} by: {GetAuthor()} || Language:{_language} || Added: {GetDate()}");
    }
}

public override string MediaData()
{
    return $"{GetType()}, {GetName()}, {GetAuthor()}, {_keywords}, {_fileFormat}, {_language}";
}

}