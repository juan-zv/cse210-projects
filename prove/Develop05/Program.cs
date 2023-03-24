using System;

class Program
{

    static void Main(string[] args)
    {
        int userChoice = 0;
        do {

            List<Goal> goals = new List<Goal>(); 

            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.WriteLine("Select a choice from the menu:");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1){
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("\t1. Simple Goal");
                Console.WriteLine("\t2. Eternal Goal");
                Console.WriteLine("\t3. Checklist Goal");
                Console.WriteLine("What type of goal would you like to create?");
                int typeOfGoal = int.Parse(Console.ReadLine());

                if (typeOfGoal == 1){
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.SetType(typeOfGoal);
                    simpleGoal.SetGoal();

                    //I AM CHECKING IT WORKS HERE
                    simpleGoal.DisplayGoal();
                    
                    goals.Add(simpleGoal);
                }
                else if (typeOfGoal == 2){
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.SetType(typeOfGoal);
                    eternalGoal.SetGoal();
                    goals.Add(eternalGoal);
                }
                else if (typeOfGoal == 3){
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    checklistGoal.SetType(typeOfGoal);
                    checklistGoal.SetGoal();
                    goals.Add(checklistGoal);
                }
            }

            if (userChoice == 2){
                //BRUH IT DOESN'T WORK HERE
                foreach (Goal item in goals)
                {
                    item.DisplayGoal(); 
                }

            }

            if (userChoice == 3){
                
            }
        } while (userChoice != 6); 
    }
}