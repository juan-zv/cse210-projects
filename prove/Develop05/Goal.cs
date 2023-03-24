using System;

public class Goal
{   private int _type;
    private string _name;
    private string _description;
    private int _points;
    private bool _checked;

    public Goal() {
    }

    public virtual void SetType(int typeOfGoal){
        _type = typeOfGoal;
    }

    public virtual int GetGoalType(){
        return _type;
    }

    public virtual void SetGoal(){

        _checked = false;
        Console.WriteLine("What is the name of your goal?");
        _name = Console.ReadLine();
        Console.WriteLine("what is a short description of it?");
        _description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        _points = int.Parse(Console.ReadLine());

    }

    public virtual void DisplayGoal() {
        if (_checked == false){
            Console.WriteLine($"[ ] {_name} ({_description})");
        }
        else if (_checked == true){
            Console.WriteLine($"[X] {_name} ({_description})");
        }
    }

    public virtual void CheckGoal() {
        if (_checked == false) {
            _checked = true;
        }
    }




    public virtual string GetName () {
        return _name;
    }

    public virtual string GetDescription() {
        return _description;
    }

    public virtual int GetPoints() {
        return _points;
    }
}