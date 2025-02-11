using System;

class Program
{
    static void Main()
    {
        Selection selection = new Selection();
        Console.WriteLine("Do you want to input your own scripture or select from the database? (input/select)");
        string choice = Console.ReadLine().ToLower();

        Reference reference;
        Scripture scripture;
        

        if (choice == "select")
        {   
            Console.Clear();
            var scripturesByCategory = selection.GetScriptureData();
            Console.WriteLine("Select a category from the following options:");

            int categoryIndex = 1;
            foreach (var category in scripturesByCategory.Keys)
            {
                Console.WriteLine($"{categoryIndex}. {category}");
                categoryIndex++;
            }
            Console.WriteLine("Enter the number of your choice:");
            int selectedCategoryNumber = int.Parse(Console.ReadLine()) - 1;

            if (selectedCategoryNumber >= 0 && selectedCategoryNumber < scripturesByCategory.Count)
            {
                Console.Clear();
                var selectedCategory = new List<string>(scripturesByCategory.Keys)[selectedCategoryNumber];
                var scriptures = scripturesByCategory[selectedCategory];
                Console.WriteLine($"Select a scripture from the category {selectedCategory}:");

                for (int i = 0; i < scriptures.Count; i++)
                {
                    var (refObj, text) = scriptures[i];
                    Console.WriteLine($"{i + 1}. {refObj} - {text}");
                }

                Console.WriteLine("Enter the number of your choice:");
                int selectedScriptureNumber = int.Parse(Console.ReadLine()) - 1;

                if (selectedScriptureNumber >= 0 && selectedScriptureNumber < scriptures.Count)
                {
                    Console.Clear();
                    reference = scriptures[selectedScriptureNumber].reference;
                    scripture = new Scripture(scriptures[selectedScriptureNumber].scripture);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Exiting.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Exiting.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Enter the book:");
            string bookName = Console.ReadLine();

            Console.WriteLine("Enter the chapter:");
            int chapterNum = int.Parse(Console.ReadLine());

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
            reference = new Reference(bookName, chapterNum, startVerse, endVerse);
            scripture = new Scripture(scriptureText);
        }

        while (true)
        {
            // Replace an increasing number of words with each iteration
            string modifiedScripture = scripture.ReplaceWords();

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
