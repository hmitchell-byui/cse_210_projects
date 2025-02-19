using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start(); // Initialize player info and create the first goal

        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine($"Player: {goalManager.PlayerName}, Level: {goalManager.Level}, Points: {goalManager.Score}");
            Console.WriteLine("Eternal Quest");
            Console.WriteLine($"Total Points: {goalManager.Score}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Display Player Info");
            Console.WriteLine("7. Display Goal Descriptions");
            Console.WriteLine("8. Exit");
            Console.WriteLine("Enter your choice:");

            string input = Console.ReadLine();
            int choice;

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 8.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                continue;
            }

            switch (choice)
            {
                case 1:
                    goalManager.CreateGoal();
                    break;
                case 2:
                    goalManager.ListGoalDetails();
                    break;
                case 3:
                    goalManager.SaveGoals();
                    break;
                case 4:
                    goalManager.LoadGoals();
                    break;
                case 5:
                    goalManager.RecordEvent();
                    break;
                case 6:
                    goalManager.DisplayPlayerInfo();
                    break;
                case 7:
                    goalManager.DisplayGoalDescriptions();
                    break;
                case 8:
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
