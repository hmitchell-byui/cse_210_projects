using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        string userName = "";
        int userAge = 0;
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest");
            Console.WriteLine("1. Setup New User");
            Console.WriteLine("2. Display User Info");
            Console.WriteLine("3. List Current Goal Names");
            Console.WriteLine("4. List Current Goal Details");
            Console.WriteLine("5. Create New Goal");
            Console.WriteLine("6. Record Event");
            Console.WriteLine("7. Save");
            Console.WriteLine("8. Load");
            Console.WriteLine("9. Exit");
            Console.WriteLine("Enter your choice:");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter your name:");
                    userName = Console.ReadLine();
                    Console.WriteLine("Enter your age:");
                    userAge = int.Parse(Console.ReadLine());
                    Console.WriteLine("User setup complete!");
                    break;
                case 2:
                    Console.WriteLine($"User Name: {userName}");
                    Console.WriteLine($"User Age: {userAge}");
                    break;
                case 3:
                    goalManager.ListGoalNames();
                    break;
                case 4:
                    goalManager.ListGoalDetails();
                    break;
                case 5:
                    goalManager.CreateGoal();
                    break;
                case 6:
                    goalManager.RecordEvent();
                    break;
                case 7:
                    goalManager.SaveGoals();
                    break;
                case 8:
                    goalManager.LoadGoals();
                    break;
                case 9:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
