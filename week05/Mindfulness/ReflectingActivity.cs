public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think about a time you overcame a challenge.",
        "Think about a time you helped someone.",
        "Think about a moment that changed your life."
    };

    private List<string> _questions = new List<string>
    {
        "What did you learn from this experience?",
        "How did you feel during this moment?",
        "What would you do differently if it happened again?"
    };

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "reflect on past experiences";
        _duration = 10;
    }

    public override void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(3);

        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(3);

        Console.WriteLine("Think about the following questions:");
        foreach (var question in _questions)
        {
            Console.WriteLine(question);
            ShowSpinner(3);
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        return _prompts[rnd.Next(_prompts.Count)];
    }
}
