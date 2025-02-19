public class ChecklistGoal : Goal
{
    public int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted % 5 == 0)
        {
            int milestoneNumber = _amountCompleted / 5;
            _bonus += (int)(5 * Math.Pow(2, milestoneNumber));
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}, {_description}, {_points}, Completed: {_amountCompleted}/{_target}, Bonus: {_bonus}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal, {_shortName}, {_description}, {_points}, {_amountCompleted}, {_target}, {_bonus}";
    }
}
