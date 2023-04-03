using System;

public class Song:Album
{
private int _songLength;


public Song(string type, string name, string author, string invitedArtists, int length):base(type, name, author, invitedArtists){
    _songLength = length;
}

}