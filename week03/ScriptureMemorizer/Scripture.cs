public class Scripture
{
    private string _reference;
    private  List<Word> _words = new List<Word>();

    public Scripture()
    {
        _reference = "";
        foreach (Word word in _words)
        {word.Display();}
    }
    public Scripture(Reference reference, string text, List<Word> texts)
    {
        _reference = reference;
        _words = texts;
    }
    public int _numberToHide;
    public void HideRandomWords()
    {
        _numberToHide = 0;
    }
    public void HideRandomWords(int numberToHide)
    {
        _numberToHide = numberToHide;
    }
    public string GetDisplayText()
    {
        string text = $"{_reference}";
        return text;
    }
    public bool IsCompletelyHidden()
    {
        return true;
    }

}
