using System;
using System.Collections.Generic;
using System.Linq;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private string _playerName;
    private int _playerAge;
    private Levels _levels;
    private string _filePath = "Goal.txt";

    public int Score => _score;
    public string PlayerName => _playerName;
    public int Level => _levels.Level;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _levels = new Levels();
    }

    public void Start()
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        Console.WriteLine("Let's start by setting up your player info.");

        Console.Write("Enter your name: ");
        _playerName = Console.ReadLine();

        Console.Write("Enter your age: ");
        _playerAge = int.Parse(Console.ReadLine());

        Console.WriteLine("Would you like to create your first goal now? (yes/no)");
        string response = Console.ReadLine().ToLower();

        if (response == "yes")
        {
            DisplayGoalDescriptions();
            Console.WriteLine("");
            CreateGoal();
        }
        else
        {
            Console.WriteLine("You can create goals later using the menu options.");
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Name: {_playerName}");
        Console.WriteLine($"Player Age: {_playerAge}");
        Console.WriteLine($"Total Score: {_score}");
        Console.WriteLine($"Level: {_levels.Level}");
        Console.WriteLine($"Experience Points: {_levels.ExperiencePoints}/{_levels.XPForNextLevel}");
        Console.WriteLine($"Active Goals: {_goals.Count}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Current Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]._shortName}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        _goals.ForEach(goal => Console.WriteLine(goal.GetDetailsString()));
    }

    public void DisplayGoalDescriptions()
    {
        Console.WriteLine("Goal Descriptions:");
        Console.WriteLine("1. Simple Goal: A goal with a clear objective that can be completed once. Upon completion, the goal is marked as complete, and you earn the specified points. Example: \"Read a book.\"");
        Console.WriteLine("2. Eternal Goal: A goal that can be pursued indefinitely without a specific endpoint. These goals encourage continuous effort and improvement. They don't have a completion status but contribute to your ongoing progress. Example: \"Exercise daily.\"");
        Console.WriteLine("3. Checklist Goal: A goal that requires multiple steps or tasks to be completed. It has a target amount, and you earn bonus points for reaching milestones along the way. Example: \"Complete 5 home improvement projects.\"");
    }

    public void CreateGoal()
    {
        try
        {
            Console.WriteLine("Enter goal type:");
            Console.WriteLine("1. Simple");
            Console.WriteLine("2. Eternal");
            Console.WriteLine("3. Checklist");

            int type = int.Parse(Console.ReadLine());

            Console.Write("Enter the goal name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the goal description: ");
            string description = Console.ReadLine();

            Console.Write("Enter the goal points: ");
            string points = Console.ReadLine();

            Goal newGoal = type switch
            {
                1 => new SimpleGoal(name, description, points),
                2 => new EternalGoal(name, description, points),
                3 => CreateChecklistGoal(name, description, points),
                _ => throw new InvalidOperationException("Invalid goal type.")
            };

            _goals.Add(newGoal);
            _levels.AddExperience(10); // Award 10 XP for each goal added
            Console.WriteLine("Goal created successfully! You gained 10 experience points.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating goal: {ex.Message}");
        }
    }

    private Goal CreateChecklistGoal(string name, string description, string points)
    {
        Console.Write("Enter the target amount: ");
        int target = int.Parse(Console.ReadLine());

        Console.Write("Enter the bonus points: ");
        int bonus = int.Parse(Console.ReadLine());

        return new ChecklistGoal(name, description, points, target, bonus);
    }

    public void RecordEvent()
    {
        try
        {
            Console.Write("Enter the goal name for the event: ");
            string name = Console.ReadLine();

            Goal goal = _goals.FirstOrDefault(g => g._shortName.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (goal != null)
            {
                goal.RecordEvent();
                Console.WriteLine($"Event recorded for goal: {goal._shortName}");

                if (goal.IsComplete())
                {
                    int pointsEarned = (int)(int.Parse(goal.Point) * _levels.PointMultiplier);
                    _score += pointsEarned;
                    _levels.AddExperience(pointsEarned); // Award XP based on the point multiplier
                    Console.WriteLine($"Goal completed! You earned {pointsEarned} points and XP. Total score: {_score}");
                }
                else if (goal is EternalGoal eternalGoal)
                {
                    int pointsEarned = (int)(eternalGoal.BonusPoints * _levels.PointMultiplier);
                    _score += pointsEarned;
                    _levels.AddExperience(pointsEarned); // Award XP based on the point multiplier
                    Console.WriteLine($"Event recorded! You earned bonus points and XP. Total score: {_score}");
                }
            }
            else
            {
                Console.WriteLine("Goal not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error recording event: {ex.Message}");
        }
    }

    public void SaveGoals()
    {
        FileManager.SaveGoals(_filePath, _playerName, _playerAge, _score, _levels, _goals);
    }

    public void LoadGoals()
    {
        (string playerName, int playerAge, int score, Levels levels, List<Goal> goals) = FileManager.LoadGoals(_filePath);
        _playerName = playerName;
        _playerAge = playerAge;
        _score = score;
        _levels = levels;
        _goals = goals ?? new List<Goal>();
    }
}
