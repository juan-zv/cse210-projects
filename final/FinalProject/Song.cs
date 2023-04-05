using System;

public class Song:Album
{
private int _songLength;


public Song(string type, string name, string author, string invitedArtists, int length):base(type, name, author, invitedArtists){
    _songLength = length;
}

public override void DisplayMedia()
{
    // if (GetInvitedArtists() == " "){
    //     Console.WriteLine($"{GetType()}: {GetName()} by: {GetAuthor()} || Duration:{_songLength} min || Added: {GetDate()}");
    // }
    // else{}
    
    Console.WriteLine($"{GetType()}: {GetName()} by: {GetAuthor()} and {GetInvitedArtists()} || Duration:{_songLength} min || Added: {GetDate()}");
}

public override string MediaData()
{
    return $"{GetType()}, {GetName()}, {GetAuthor()}, {GetInvitedArtists()}, {_songLength}";
}


}