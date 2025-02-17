public class MeditativeActivity : Activity
{
    public MeditativeActivity()
    {
        _name = "Meditative Activity";
        _description = "focus on mindfulness and relaxation";
        _duration = 10;
    }

    public override void Run()
    {
        Console.WriteLine("Close your eyes and take deep breaths...");
        for (int i = 0; i < _duration / 2; i++)
        {
            Console.WriteLine("Inhale...");
            ShowCountDown(3);
            Console.WriteLine("Exhale...");
            ShowCountDown(3);
        }
    }
}
