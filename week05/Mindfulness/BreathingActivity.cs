public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "focus on breathing in and out";
        _duration = 10; // Default duration
    }

    public override void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(3);

        for (int i = 0; i < _duration / 2; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }

        DisplayEndingMessage();
    }
}