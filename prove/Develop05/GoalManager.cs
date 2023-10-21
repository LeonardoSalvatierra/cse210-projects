using System;

public class GoalManager
{
    private string _userName;
    public List<Goal> _goals;
    private int _score;
    public GoalManager(string name)
    {
        _userName = name;
        _goals = new List<Goal>();
    }
    public void CreateGoal()
    {
        Console.Write("\nthe types of goals are: \n     1. Simple Goal\n        2. Eternal Goal\n       3. Checklist Goal\nWhich type of goal would you like to create?: ");
        int goalChoice = int.Parse(Console.ReadLine());
        switch(goalChoice)
        {
            case 1:
                Console.Write("What is the name of your goal?: ");
                string nameGoal = Console.ReadLine();
                Console.Write("What is a short description of it?: ");
                string descriptionGoal = Console.ReadLine(); 
                Console.Write("Whas is the amount of point associated with this goal?: ");
                int pointsGoal = int.Parse(Console.ReadLine());
                SimpleGoals simpleGoal = new SimpleGoals(nameGoal, descriptionGoal, pointsGoal, false);
                _goals.Add(simpleGoal);
                break;
            case 2:
                Console.Write("Name of the goal: ");
                nameGoal = Console.ReadLine();
                Console.Write("Short description: ");
                descriptionGoal = Console.ReadLine();
                Console.Write("Points when accomplished: ");
                pointsGoal = int.Parse(Console.ReadLine());
                EternalGoal eternalGoal = new EternalGoal(nameGoal, descriptionGoal, 0, pointsGoal);
                _goals.Add(eternalGoal);
                break;
            case 3: //CHECKLIST GOAL
                Console.Write("Name of the goal: ");
                nameGoal = Console.ReadLine();
                Console.Write("Short description: ");
                descriptionGoal = Console.ReadLine();
                Console.Write("Points when accomplished: ");
                pointsGoal = int.Parse(Console.ReadLine());
                Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
                int timesToBonus = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times?: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                CheckListGoal checklistGoal = new CheckListGoal(nameGoal, descriptionGoal, pointsGoal, bonusPoints, timesToBonus, 0, false);
                _goals.Add(checklistGoal);
                break;
        }
    }
    public void DisplayPlayerInfo()
    {
        int i = 1;
        foreach(Goal goal in _goals)
        {
            Console.Write(i + ". ");
            goal.DisplayGoal(0);
            i++;
        }
        Console.WriteLine();
    }
    public int GetTotalPoints()
    {
        return _score;
    }
    public void RecordEvent()
    {
        int i = 1;
        List<Goal> aux =  new List<Goal>();
        foreach(Goal goal in _goals)
        {
            if(!goal.GetIsCompleted())
            {
                aux.Add(goal);
                Console.Write(i + ". ");
                goal.DisplayGoal(1);
                i++;
            }
        }
        if(i > 1)
        {
            Console.WriteLine("Which goal did you accomplish?: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            aux[index].SetIsCompleted();   
            _score += aux[index].GetPoints();  
        }
        else
        {
            Console.WriteLine("Goal list is empty\n");
        }
    }
    public void SaveGoals()
    {
        Console.Clear();
        Console.Write("Introduce filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"00|{_userName}|{_score}");
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRep());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Clear();
        Console.Write("Introduce filename: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _goals.Clear();
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (int.Parse(parts[0]) == 00) //GET USERNAME AND POINTS
            {
                _userName = parts[1];
                if (int.Parse(parts[2]) == 0) //if user doesn't have points when saved
                {
                    _score = 0;
                }
                continue;
            }
            
            if (int.Parse(parts[0]) == 1) //IF GOAL IS SIMPLE
            {
                bool isCompleted;
                if(parts[4].ToLower().Equals("true"))
                {
                    isCompleted = true;
                }
                else
                {
                    isCompleted = false;
                }
                SimpleGoals loadedGoal = new SimpleGoals(parts[1],parts[2],int.Parse(parts[3]),isCompleted);
                _goals.Add(loadedGoal);
            }
            else if (int.Parse(parts[0]) == 2) //IF GOAL IS ETERNAL
            {
                EternalGoal loadedGoal = new EternalGoal(parts[1],parts[2],int.Parse(parts[3]),int.Parse(parts[4]));
                _goals.Add(loadedGoal);
            }
            else if (int.Parse(parts[0]) == 3) //IF GOAL IS CHECKLIST
            {
                bool complete;
                if (parts[7].ToLower().Equals("true"))
                {
                    complete = true;
                }
                else
                {
                    complete = false;
                }
                CheckListGoal loadedGoal = new CheckListGoal(parts[1],parts[2],int.Parse(parts[3]),int.Parse(parts[4]),int.Parse(parts[5]),int.Parse(parts[6]),complete);
                _goals.Add(loadedGoal);
            }
        }
        Console.WriteLine($"Welcome again {_userName}!");
    }

}