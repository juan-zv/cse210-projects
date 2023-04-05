using System;

public class Photo:Media
{
private string _location;
private string _cameraModel;
private string _fileFormat;
public Photo(string type, string name, string author, string location, string camera, string file):base(type, name, author){
    _location = location;
    _cameraModel = camera;
    _fileFormat = file;
}
public override void DisplayMedia()
{
    Console.WriteLine($"{GetType()}: {GetName()} by: {GetAuthor()} || Camera model:{_cameraModel} || Location:{_location} || File format: {_fileFormat} || Added: {GetDate()}");
}

public override string MediaData()
{
    return $"{GetType()}, {GetName()}, {GetAuthor()}, {_location}, {_cameraModel}, {_fileFormat}";
}


}