using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal._shortName);
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Enter the goal type (1 for Simple, 2 for Eternal, 3 for Checklist):");
        int type = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the goal name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the goal description:");
        string description = Console.ReadLine();

        Console.WriteLine("Enter the goal points:");
        string points = Console.ReadLine();

        Goal newGoal;
        switch (type)
        {
            case 1:
                newGoal = new SimpleGoal(name, description, points);
                break;
            case 2:
                newGoal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.WriteLine("Enter the target amount:");
                int target = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the bonus points:");
                int bonus = int.Parse(Console.ReadLine());

                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals.Add(newGoal);
    }

    public void RecordEvent()
    {
        Console.WriteLine("Enter the goal name for the event:");
        string name = Console.ReadLine();

        foreach (var goal in _goals)
        {
            if (goal._shortName == name)
            {
                goal.RecordEvent();
                Console.WriteLine("Event recorded for goal: " + goal._shortName);
                return;
            }
        }

        Console.WriteLine("Goal not found.");
    }

    public void SaveGoals()
    {
        // Implementation for saving goals
    }

    public void LoadGoals()
    {
        // Implementation for loading goals
    }
}
