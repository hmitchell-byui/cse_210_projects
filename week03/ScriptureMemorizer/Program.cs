using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the book:");
        string book = Console.ReadLine();

        Console.WriteLine("Enter the chapter:");
        int chapter = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the starting verse:");
        int startVerse = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the ending verse (leave blank if same as start verse):");
        string endVerseInput = Console.ReadLine();
        int endVerse = string.IsNullOrEmpty(endVerseInput) ? startVerse : int.Parse(endVerseInput);

        Console.WriteLine("Enter the scripture text:");
        string scriptureText = Console.ReadLine();

        // Clear user input
        Console.Clear();

        // Store reference and scripture
        Reference reference = new Reference(book, chapter, startVerse, endVerse);
        Scripture scripture = new Scripture(scriptureText);

        while (true)
        {
            // Replace an increasing number of words with each iteration
            string modifiedScripture = scripture.ReplaceWordsWithUnderscores();

            // Display modified scripture and reference
            Console.WriteLine("Modified Scripture:");
            Console.WriteLine(modifiedScripture);
            Console.WriteLine($"Reference: {reference}");

            // Check if all words have been replaced
            if (modifiedScripture.Replace(" ", "").Replace("_", "").Length == 0)
            {
                Console.WriteLine("All words have been replaced.");
                break;
            }

            // Ask user if they want to continue or quit
            Console.WriteLine("Type 'quit' to exit or press Enter to continue:");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }

            // Clear the console for the next iteration
            Console.Clear();
        }
    }
}
