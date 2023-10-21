using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;
    protected int _type;
    public Goal(string name, string description, int points, bool isCompleted)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isCompleted = isCompleted;
    }
    public abstract void SetIsCompleted();
    public abstract void DisplayGoal(int option); 
    public abstract string GetStringRep();
    public bool GetIsCompleted()
    {
        return _isCompleted;
    }
    public int GetPoints()
    {
        return _points;
    }

}