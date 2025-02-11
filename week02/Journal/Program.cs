using System;

public class Program
{
    private static Journal _journal = new Journal();

    public static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Journal Program");
            Console.WriteLine("1. Add New Entry");
            Console.WriteLine("2. Display All Entries");
            Console.WriteLine("3. Save Entries to File");
            Console.WriteLine("4. Load Entries from File");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AddNewEntry();
                    break;
                case "2":
                    _journal.DisplayAll();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "3":
                    SaveEntries();
                    break;
                case "4":
                    LoadEntries();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static string GetCurrentDate()
    {
        return DateTime.Now.ToString("MM/dd/yyyy");
    }

    private static void AddNewEntry()
    {
        Console.Clear();
        string date = GetCurrentDate();
        Console.WriteLine($"Date: {date}");

        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator.GetPrompt();
        string promptText = promptGenerator._prompt;

        Console.WriteLine("Write your entry: ");
        string entryText = Console.ReadLine();

        Entry newEntry = new Entry
        {
            _date = date,
            _promptText = promptText,
            _entryText = entryText
        };

        _journal.AddEntry(newEntry);
    }

    private static void SaveEntries()
    {
        Console.Clear();
        Console.Write("Enter the filename to save entries: ");
        string file = Console.ReadLine();
        _journal.SaveToFile(file);
        Console.WriteLine("Entries saved successfully.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    private static void LoadEntries()
    {
        Console.Clear();
        Console.Write("Enter the filename to load entries: ");
        string file = Console.ReadLine();
        _journal.LoadFromFile(file);
        Console.WriteLine("Entries loaded successfully.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
 