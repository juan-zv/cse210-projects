using System;
public class Media
{
private string _name;
private string _type;
private string _author;
private string _date;
public Media (string type, string name, string author){
    _type = type;
    _name = name;
    _author = author;
    DateTime currentDate = DateTime.Now;
    _date = currentDate.ToString(); //date given as dd/mm/yyyy hh:mm:ss
    Console.WriteLine(_date);
}
public virtual void DisplayMedia(){
    Console.WriteLine($"{_type}: {_name} - {_author}. Added: {_date}");
}







}