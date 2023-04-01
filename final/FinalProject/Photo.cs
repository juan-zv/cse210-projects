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





}