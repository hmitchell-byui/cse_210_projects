public class PhysicalExerciseActivity : Activity
{
    private List<string> _exercises = new List<string>
    {
        "Stretch your arms overhead",
        "Touch your toes",
        "Rotate your shoulders",
        "March in place",
        "Take a deep breath and relax"
    };

    public PhysicalExerciseActivity()
    {
        _name = "Physical Exercise Activity";
        _description = "engage in light physical movement";
        _duration = 10;
    }

    public override void Run()
    {
        Random rnd = new Random();
        for (int i = 0; i < _duration / 5; i++)
        {
            string exercise = _exercises[rnd.Next(_exercises.Count)];
            Console.WriteLine(exercise);
            ShowCountDown(5);
        }
    }
}
