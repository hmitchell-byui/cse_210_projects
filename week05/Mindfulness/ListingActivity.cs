public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List things that make you happy.",
        "List your favorite memories.",
        "List things you are grateful for."
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "list things based on a given prompt";
        _duration = 10; // Default duration
    }

    public override void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(3);

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("You have 10 seconds to list as many as you can:");

        List<string> userResponses = GetListFromUser();
        Console.WriteLine($"You listed {userResponses.Count} items.");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        return _prompts[rnd.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                responses.Add(input);
        }
        return responses;
    }
}
