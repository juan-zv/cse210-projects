using System;

public class Album:Media
{
private int _numberOfSongs;
private string _genre;
private string _invitedArtists;
private int _length;

public Album(string type, string name, string author, string artists):base(type, name, author){
        _invitedArtists = artists;
}

public virtual string GetInvitedArtists(){
    return _invitedArtists;
}


}