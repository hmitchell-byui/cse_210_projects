public class Reference
{
    private string _bookName;
    private int _chapterNum;
    private int _startVerse;
    private int _endVerse;

    public string BookName
    {
        get { return _bookName; }
        set { _bookName = value; }
    }

    public int ChapterNum
    {
        get { return _chapterNum; }
        set { _chapterNum = value; }
    }

    public int StartVerse
    {
        get { return _startVerse; }
        set { _startVerse = value; }
    }

    public int EndVerse
    {
        get { return _endVerse; }
        set { _endVerse = value; }
    }

    public Reference(string bookName, int chapterNum, int startVerse, int endVerse = -1)
    {
        _bookName = bookName;
        _chapterNum = chapterNum;
        _startVerse = startVerse;
        if (endVerse > startVerse)
        {
            _endVerse = endVerse;
        }
else
{
    _endVerse = startVerse;
}
    }

    public override string ToString()
    {
        if (_startVerse == _endVerse)
        {
            return $"{BookName} {ChapterNum}:{StartVerse}";
        }
        else
        {
            return $"{BookName} {ChapterNum}:{StartVerse}-{EndVerse}";
        }
    }
}
