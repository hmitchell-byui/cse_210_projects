public abstract class Goal
{
    public string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return _description;
    }

    public abstract string GetStringRepresentation();
}
