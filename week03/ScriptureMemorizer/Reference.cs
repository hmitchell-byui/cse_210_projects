using System.Security.Cryptography.X509Certificates;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference()
    {
        _book = "Book";
        _chapter = 1;
        _verse = 1;
        _endVerse = 1;
        string reference = $"{_book} {_chapter}: {_verse}";
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
        string reference = $"{_book} {_chapter}: {_verse}";
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
        string reference = $"{_book} {_chapter}: {_verse}-{endVerse}";
    }
    public string GetReference()
    {
        if (_endVerse == _verse)
        {
            string referenceText = $"{_book} {_chapter}: {_verse}";
            return referenceText;
        }
        else 
        {
            string referenceText = $"{_book} {_chapter}: {_verse}-{_endVerse}";
            return referenceText;
        }
        
    }
}
