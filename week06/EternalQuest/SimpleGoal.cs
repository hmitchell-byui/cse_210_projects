public class SimpleGoal : Goal
{
    public bool _isComplete;

    public SimpleGoal(string name, string description, string points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;  // Mark the goal as complete when the event is recorded
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}, {_description}, {_points}, Is Complete: {_isComplete}";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal, {_shortName}, {_description}, {_points}, {_isComplete}";
    }
}
