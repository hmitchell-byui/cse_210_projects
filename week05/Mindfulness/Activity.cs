public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }

    public string GetName()
    {
        return _name;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}.");
        Console.WriteLine($"Let's {_description} for {_duration} seconds.");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGreat job! You have completed the activity.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinner[i % 4]);
            System.Threading.Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine();
    }

    public virtual void Run()
    {
        Console.WriteLine("Running the activity...");
    }
}
