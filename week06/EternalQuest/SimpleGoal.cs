public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _basePoints;
        }
        return 0;
    }

    public override string GetStatusString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_name}";
    }
}