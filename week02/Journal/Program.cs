using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1: Write - From Prompt");
        Console.WriteLine("2: Write - Without Prompt");
        Console.WriteLine("3: Display");
        Console.WriteLine("4: Load");
        Console.WriteLine("5: Save");        
        Console.WriteLine("6: Quit");
        Console.WriteLine("7: Save and Quit");
        int Action = int.Parse(Console.ReadLine());

        PromptGenerator Prompt = new PromptGenerator();
        Prompt.GetPrompt();

        Entry entry = new Entry();
        entry._promptText = "";
        if (Action == 1)
        {
            Entry Home = new Entry();
            Home.DisplayPrompt();

        }
        else if (Action == 2)
        {
            Entry Home = new Entry();
            Home.DisplayNoPrompt();
        }
        
    }
}

