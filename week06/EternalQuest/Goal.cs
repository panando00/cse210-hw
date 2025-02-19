using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _basePoints;
    protected bool _isComplete;

    public Goal(string name, string description, int basePoints)
    {
        _name = name;
        _description = description;
        _basePoints = basePoints;
        _isComplete = false;
    }

    public abstract int RecordEvent();
    public abstract string GetStatusString();
    
    public string GetName() => _name;
    public bool IsComplete() => _isComplete;
}