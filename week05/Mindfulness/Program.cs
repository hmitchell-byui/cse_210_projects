using System;
using System.Collections.Generic;

class Program
{
    private static int totalActivitiesCompleted = 0;
    private static int totalTimeSpent = 0;
    private static List<string> completedActivities = new List<string>();

    static void Main(string[] args)
    {
        Console.WriteLine("Hello! Welcome to the Mindfulness Project.");
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Activity List");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Meditative Activity");
            Console.WriteLine("5. Physical Exercise Activity");
            Console.WriteLine("6. View Summary");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    RunActivity(new BreathingActivity());
                    break;
                case "2":
                    RunActivity(new ListingActivity());
                    break;
                case "3":
                    RunActivity(new ReflectingActivity());
                    break;
                case "4":
                    RunActivity(new MeditativeActivity());
                    break;
                case "5":
                    RunActivity(new PhysicalExerciseActivity());
                    break;
                case "6":
                    DisplaySummary();
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }
    }

    static void RunActivity(Activity activity)
    {
        Console.Clear();
        Console.Write("Enter duration (in seconds): ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            activity.Duration = duration;
        }
        else
        {
            Console.WriteLine("Invalid input. Using default duration.");
        }

        activity.DisplayStartingMessage();
        activity.ShowCountDown(3);

        activity.Run();

        activity.DisplayEndingMessage();

        // Track progress
        totalActivitiesCompleted++;
        totalTimeSpent += activity.Duration;
        completedActivities.Add(activity.GetName());
    }

    static void DisplaySummary()
    {
        Console.Clear();
        Console.WriteLine("==== Activity Summary ====");
        Console.WriteLine($"Total Activities Completed: {totalActivitiesCompleted}");
        Console.WriteLine($"Total Time Spent: {totalTimeSpent} seconds");

        Console.WriteLine("\nCompleted Activities:");
        if (completedActivities.Count > 0)
        {
            foreach (var activity in completedActivities)
            {
                Console.WriteLine($"- {activity}");
            }
        }
        else
        {
            Console.WriteLine("No activities completed yet.");
        }
    }
}
