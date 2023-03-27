using System;

public class Goal
{   private int _type;
    private string _name;
    private string _description;
    private int _points;

    public Goal() {
    }

    public Goal(string type, string name, string description, string points){
        _type = int.Parse(type);
        _name = name;
        _description = description;
        _points = int.Parse(points);
    }

    public virtual int GetGoalType(){
        return _type;
    }
    public virtual void SetGoalType(int typeOfGoal){
        _type = typeOfGoal;
    }


    public virtual void SetGoal(){

        Console.WriteLine("What is the name of your goal?");
        _name = Console.ReadLine();
        Console.WriteLine("what is a short description of it?");
        _description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        _points = int.Parse(Console.ReadLine());

    }

    public virtual void DisplayGoal() {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }

    public virtual int CheckGoal() {
        return _points;
    }

    public virtual string GetGoalData(){
        string goalData = $"{_type}, {_name}, {_description}, {_points}";
        return goalData;
    }

    public virtual void StringToGoal(string type, string name, string description, string points){
        _type = int.Parse(type);
        _name = name;
        _description = description;
        _points = int.Parse(points);
    }

    public virtual string GetName () {
        return _name;
    }
    public virtual void SetName(string name){
        _name = name;
    }

    public virtual string GetDescription() {
        return _description;
    }
    public virtual void SetDescription(string description){
        _description = description;
    }

    public virtual int GetPoints() {
        return _points;
    }
    public virtual void SetPoints(int points){
        _points = points;
    }
}