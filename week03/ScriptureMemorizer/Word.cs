public class Word
{
    private string _text;
    private bool _isHidden;

    public Word()
    {
        _text = "";
    }
    public Word(string text)
    {
        _text = text;
    }
    public void Hide()
    {
        _text = "_____";
    }
    public void Show()
    {
        _text = _text;
    }
    public bool IsHidden()
    {
        
    }
    public void Display()
    {
        
    }
}