using System;
using System.Collections.Generic;
using System.IO;

public static class FileManager
{
    public static void SaveGoals(string filePath, string playerName, int playerAge, int score, Levels levels, List<Goal> goals)
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string newEntry = $"Name: {playerName} Age: {playerAge} Points: {score} Level: {levels.Level} XP: {levels.ExperiencePoints}/{levels.XPForNextLevel} Date: {date}\n";
        goals.ForEach(goal => newEntry += goal.GetStringRepresentation() + "\n");
        newEntry += "\n";

        string existingData = File.Exists(filePath) ? File.ReadAllText(filePath) : string.Empty;
        File.WriteAllText(filePath, newEntry + existingData);

        Console.WriteLine("Goals saved successfully!");
    }

    public static (string, int, int, Levels, List<Goal>) LoadGoals(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("No saved goals found.");
            return (null, 0, 0, null, new List<Goal>());
        }

        string[] lines = File.ReadAllLines(filePath);
        if (lines.Length == 0) return (null, 0, 0, null, new List<Goal>());

        string[] headerParts = lines[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string playerName = headerParts[1];
        int playerAge = int.Parse(headerParts[3]);
        int score = int.Parse(headerParts[5]);
        int level = int.Parse(headerParts[7]);
        string[] xpParts = headerParts[9].Split('/');
        int experiencePoints = int.Parse(xpParts[0]);
        int xpForNextLevel = int.Parse(xpParts[1]);

        Levels levels = new Levels();
        levels.SetLevel(level);
        levels.SetExperiencePoints(experiencePoints);
        levels.SetXPForNextLevel(xpForNextLevel);

        List<Goal> goals = new List<Goal>();
        for (int i = 1; i < lines.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(lines[i])) break;

            string[] parts = lines[i].Split(',');
            string type = parts[0].Trim();
            string name = parts[1].Trim();
            string description = parts[2].Trim();
            string points = parts[3].Trim();

            Goal goal = type switch
            {
                "SimpleGoal" => new SimpleGoal(name, description, points) { _isComplete = bool.Parse(parts[4].Trim()) },
                "EternalGoal" => new EternalGoal(name, description, points) { _eventCount = int.Parse(parts[4].Trim()), _bonusPoints = int.Parse(parts[5].Trim()) },
                "ChecklistGoal" => CreateChecklistGoalFromParts(name, description, points, parts),
                _ => throw new InvalidOperationException("Unknown goal type.")
            };

            goals.Add(goal);
        }

        Console.WriteLine("Goals loaded successfully!");
        return (playerName, playerAge, score, levels, goals);
    }

    private static Goal CreateChecklistGoalFromParts(string name, string description, string points, string[] parts)
    {
        int amountCompleted = int.Parse(parts[4].Trim());
        int target = int.Parse(parts[5].Trim());
        int bonus = int.Parse(parts[6].Trim());
        return new ChecklistGoal(name, description, points, target, bonus) { _amountCompleted = amountCompleted };
    }
}
