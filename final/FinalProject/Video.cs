public class Video:Media
{
private string _location;
private string _cameraModel;
private string _fileFormat;
private int _length;

public Video(string type, string name, string author, string location, string camera, string file, int length):base(type, name, author){
    _location = location;
    _cameraModel = camera;
    _fileFormat = file;
    _length = length;
}

public override void DisplayMedia()
{
  Console.WriteLine($"{GetType()}: {GetName()} by: {GetAuthor()} || Camera model:{_cameraModel} || Location:{_location} || File format: {_fileFormat} || Video Length: {_length} min || Added: {GetDate()}");
}

public override string MediaData()
{
    return $"{GetType()}, {GetName()}, {GetAuthor()}, {_location}, {_cameraModel}, {_fileFormat}, {_length}";
}



}