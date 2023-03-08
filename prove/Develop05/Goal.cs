using System;

public class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string descrptn, int points) {
        _name = name;
        _description = descrptn;
        _points = points;
    }

    public virtual string getName () {
        return _name;
    }

    public virtual string getDescription() {
        return _description;
    }

    public virtual int getPoints() {
        return _points;
    }

    public virtual void displayGoal() {
        Console.WriteLine($"{_name} ({_description})");
    }




}