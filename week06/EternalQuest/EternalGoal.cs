public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
        Console.WriteLine("An eternal goal is never truly completed.\nKeep going!");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}, {_description}, {_points}, Incomplete";
    }
}
