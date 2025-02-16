public class WritingAssignment() : Assignment()
{
    private string _title = "";
    public string GetWritingInformation()
    {
        return _title;
    }
    public void SetWritingInformation(string title)
    {
        _title = title + " by {_name}";
    }
}