using System;

class Program
{

    static void Main(string[] args)
    {
        int userChoice = 0;

        List<Goal> goals = new List<Goal>();

        int _totalPoints = 0;
        
        do {

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.WriteLine("Select a choice from the menu:");
            userChoice = int.Parse(Console.ReadLine());
            Console.WriteLine("");


            if (userChoice == 1){
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("\t1. Simple Goal");
                Console.WriteLine("\t2. Eternal Goal");
                Console.WriteLine("\t3. Checklist Goal");
                Console.WriteLine("What type of goal would you like to create?");
                int typeOfGoal = int.Parse(Console.ReadLine());

                if (typeOfGoal == 1){
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.SetGoalType(typeOfGoal);
                    simpleGoal.SetGoal();                    
                    goals.Add(simpleGoal);
                }
                else if (typeOfGoal == 2){
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.SetGoalType(typeOfGoal);
                    eternalGoal.SetGoal();
                    goals.Add(eternalGoal);
                }
                else if (typeOfGoal == 3){
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    checklistGoal.SetGoalType(typeOfGoal);
                    checklistGoal.SetGoal();
                    goals.Add(checklistGoal);
                }
            }

            else if (userChoice == 2){
                int i = 1;
                foreach (Goal item in goals){
                    Console.Write($"{i}. "); item.DisplayGoal();
                    i++;
                }

                Console.WriteLine("Do you want to edit a goal?(YES/NO)");
                string edit = Console.ReadLine();

                if (edit == "yes" || edit == "Yes" || edit == "YES"){
                    Console.WriteLine("Enter the number of the goal you want to edit:");
                    int goalIndex = int.Parse(Console.ReadLine());
                    // Console.WriteLine("What do you want to edit from the goal?");
                    // Console.WriteLine("\t1. Type of goal");
                    // Console.WriteLine("\t2. Name of goal");
                    // Console.WriteLine("\t3. Description of goal");
                    // Console.WriteLine("\t2. Amount of points of the goal");
                    // string editGoal = Console.ReadLine();
                    goals.RemoveAt(goalIndex - 1);
                    Console.WriteLine("Rewrite the goal:");
                    Console.WriteLine("");
                    Console.WriteLine("What type of goal would you like to create?");
                    Console.WriteLine("\t1. Simple Goal");
                    Console.WriteLine("\t2. Eternal Goal");
                    Console.WriteLine("\t3. Checklist Goal");
                    int typeOfGoal = int.Parse(Console.ReadLine());

                    if (typeOfGoal == 1){
                        SimpleGoal simpleGoal = new SimpleGoal();
                        simpleGoal.SetGoalType(typeOfGoal);
                        simpleGoal.SetGoal();                    
                        goals.Insert(goalIndex - 1, simpleGoal);
                    }
                    else if (typeOfGoal == 2){
                        EternalGoal eternalGoal = new EternalGoal();
                        eternalGoal.SetGoalType(typeOfGoal);
                        eternalGoal.SetGoal();
                        goals.Insert(goalIndex - 1, eternalGoal);
                    }
                    else if (typeOfGoal == 3){
                        ChecklistGoal checklistGoal = new ChecklistGoal();
                        checklistGoal.SetGoalType(typeOfGoal);
                        checklistGoal.SetGoal();
                        goals.Insert(goalIndex - 1, checklistGoal);
                    }
                    }

            }

            else if (userChoice == 3){

                List<string> GoalsToFile = new List<string>();

                GoalsToFile.Add($"{_totalPoints}");

                foreach(Goal item in goals){
                    GoalsToFile.Add(item.GetGoalData());
                }

                Console.WriteLine("What is the name of the file you want to save as?");
                string fileName = Console.ReadLine();
                File.WriteAllLines(fileName, GoalsToFile);

            }

            else if (userChoice == 4){
                
                Console.WriteLine("What is the name of the file you want to load?");
                string loadFileName = Console.ReadLine();

                string[] GoalsFromFile = File.ReadAllLines(loadFileName);

                int points = int.Parse(GoalsFromFile[0]);

                _totalPoints = points;

                foreach (string item in GoalsFromFile.Skip(1)){

                    string[] goalElements = item.Split(", ");
                    
                    if (goalElements[0] == "1"){
                        SimpleGoal simpGoal = new SimpleGoal(goalElements[0], goalElements[1], goalElements[2], goalElements[3], goalElements[4]);
                        
                        goals.Add(simpGoal);
                    }
                    else if (goalElements[0] == "2"){
                        EternalGoal eternGoal = new EternalGoal(goalElements[0], goalElements[1], goalElements[2], goalElements[3]);

                        goals.Add(eternGoal);
                    }
                    else if (goalElements[0] == "3"){
                        ChecklistGoal chklstGoal = new ChecklistGoal(goalElements[0], goalElements[1], goalElements[2], goalElements[3], goalElements[4], goalElements[5], goalElements[6]);

                        goals.Add(chklstGoal);
                    }
                }
            }

            else if (userChoice == 5){

                Console.WriteLine("The goals are:");

                int i = 1;
                foreach (Goal item in goals){
                    Console.WriteLine($"{i}. {item.GetName()} ({item.GetDescription()})");
                    i++; 
                }

                Console.WriteLine("Which goal did you accomplish?");
                int goalToCheck = int.Parse(Console.ReadLine());

                int points = goals[goalToCheck-1].CheckGoal();
                _totalPoints = _totalPoints + points;

                if(points != 0){
                    Console.WriteLine($"Congratulations! You have earned {goals[goalToCheck-1].GetPoints()}");
                }    
                Console.WriteLine("");
                Console.WriteLine($"You have now {_totalPoints} points.");

            }

        } while (userChoice != 6); 
    }
}