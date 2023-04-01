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





}