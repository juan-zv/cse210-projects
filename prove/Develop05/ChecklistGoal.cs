using System;

public class ChecklistGoal:Goal
{
    private int _bonusPoints;
    private int _counter;
    private int _totalCount;
    public ChecklistGoal(){
        
    }
    public ChecklistGoal(string type, string name, string description, string points, string counter, string totalCount, string bonusPoints):base(type, name, description, points){
        _counter = int.Parse(counter);
        _totalCount = int.Parse(totalCount);
        _bonusPoints = int.Parse(bonusPoints);
   }
    public override void SetGoal(){

        Console.WriteLine("What is the name of your goal?");
        SetName(Console.ReadLine());
        Console.WriteLine("what is a short description of it?");
        SetDescription(Console.ReadLine());
        Console.WriteLine("What is the amount of points associated with this goal?");
        SetPoints(int.Parse(Console.ReadLine()));
        Console.WriteLine("How many time does this goal need to be accomplished for a bonus?");
        _totalCount = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus for accomplishin that many times?");
        _bonusPoints = int.Parse(Console.ReadLine());

    }

    public override void DisplayGoal()
    {   
        
        if (_counter != _totalCount){
            Console.WriteLine($"[ ] {GetName()} ({GetDescription()}) ------- Currently completed: {_counter}/{_totalCount}");
        }
        else if (_counter == _totalCount){
            Console.WriteLine($"[X] {GetName()} ({GetDescription()}) ------- Completed!");
        }
    }

    public override string GetGoalData(){
        string goalData = $"{GetGoalType()}, {GetName()}, {GetDescription()}, {GetPoints()}, {_counter}, {_totalCount}, {_bonusPoints}";
        return goalData;
    }

    public override int CheckGoal()
    {
        if (_counter < _totalCount){
            _counter ++;
            return base.CheckGoal();
        }
        else if (_counter == _totalCount){
            Console.WriteLine("Goal already completed");
            return 0;
        }
        else {
            return 0;
        }
        
    }

}