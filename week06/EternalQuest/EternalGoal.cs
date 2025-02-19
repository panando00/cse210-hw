public class EternalGoal : Goal
{
    private int _timesCompleted;

    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _timesCompleted = 0;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        return _basePoints;
    }

    public override string GetStatusString()
    {
        return $"[ ] {_name} (Completed {_timesCompleted} times)";
    }
}