public class EternalGoal : Goal
{
    public int _eventCount;
    public int _bonusPoints;
    public int BonusPoints => _bonusPoints;

    public EternalGoal(string name, string description, string points)
        : base(name, description, points)
    {
        _eventCount = 0;
        _bonusPoints = 0;
    }

    public override void RecordEvent()
    {
        _eventCount++;
        if (_eventCount % 5 == 0)
        {
            _bonusPoints += int.Parse(_points); // Award bonus points every 5 events
        }
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never truly complete
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}, {_description}, {_points}, Events Recorded: {_eventCount}, Bonus Points: {_bonusPoints}";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal, {_shortName}, {_description}, {_points}, {_eventCount}, {_bonusPoints}";
    }
}
