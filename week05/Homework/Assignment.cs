public class Assignment()
{
    protected string _studentName = "None";
    protected string _topic = "None";
    
    public string GetName()
    {
        return _studentName;
    }
    public void SetName(string name)
    {
        _studentName = name;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"{_studentName} : {_topic}";
    }
    public void GetSummary(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
}