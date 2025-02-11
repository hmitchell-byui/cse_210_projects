public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void DisplayNoPrompt()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_entryText}");
        Console.ReadLine();
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}
