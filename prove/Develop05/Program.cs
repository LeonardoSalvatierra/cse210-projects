using System;

class Program
{
    static void Main(string[] args)
    {
        bool play = true;
        Console.WriteLine("What's your name?: ");
        GoalManager goalManager = new GoalManager(Console.ReadLine());

        do
        {
        Console.WriteLine($"Points: {goalManager.GetTotalPoints()}");
        string MENU = "\nMenu Options:\n   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit\nSelect any option: ";
        Console.WriteLine(MENU);
        int userOption = int.Parse(Console.ReadLine());
        switch (userOption)
        {
        case 1:
            goalManager.CreateGoal();
            break;
        case 2:
            goalManager.DisplayPlayerInfo();
            break;
        case 3:
            goalManager.SaveGoals();
            break;
        case 4:
            goalManager.LoadGoals();
            break;
        case 5:
            goalManager.RecordEvent();
            break;
        case 6:
            play = false;
            break;
        default:
            Console.WriteLine("That's not an option.");
            break;
        }
       } while (play);
        
    }
}