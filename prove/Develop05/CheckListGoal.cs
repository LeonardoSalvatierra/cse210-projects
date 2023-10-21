using System;

public class CheckListGoal : Goal
{
    private int _bonusPoints;
    private int _timesToAccomplish;
    private int _timesAccomplished;
    public CheckListGoal(string name, string description, int points, int bonusPoints, int timesToAccomplish, int timesAccomplished, bool isCompleted) : base (name, description, points, isCompleted)
    {
        _type = 3;
        _timesAccomplished = timesAccomplished;
        _bonusPoints = bonusPoints;
        _timesToAccomplish = timesToAccomplish;
    }
    public override void SetIsCompleted()
    {
        _timesAccomplished += 1;
        if (_timesToAccomplish == _timesAccomplished)
        {
            _isCompleted = true;
            _points += _bonusPoints;
        }
        Console.WriteLine($"Congratulations! You have earned {_points} points");
    }
    public override void DisplayGoal(int option)
    {
        if(option == 0)
        {
            if(GetIsCompleted())
            {
                Console.Write("[X]");
            }
            else
            {
                Console.Write("[ ]");
            }
            Console.WriteLine($" {_shortName} ({_description}) -- Times accomplished: {_timesAccomplished}/{_timesToAccomplish}");
        }
        else
        {
            Console.WriteLine($"{_shortName}");         
        }
    }
    public override string GetStringRep()
    {
        return $"{_type}|{_shortName}|{_description}|{_points}|{_bonusPoints}|{_timesToAccomplish}|{_timesAccomplished}|{_isCompleted}";
    }
}