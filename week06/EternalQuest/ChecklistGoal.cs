public class ChecklistGoal : Goal
{
    private int _target;
    private int _current;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _target = target;
        _current = 0;
        _bonusPoints = bonus;
    }

    public override int RecordEvent()
    {
        _current++;
        int points = _basePoints;
        
        if (_current == _target)
        {
            _isComplete = true;
            points += _bonusPoints;
        }
        
        return points;
    }

    public override string GetStatusString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_name} (Completed {_current}/{_target} times)";
    }
}