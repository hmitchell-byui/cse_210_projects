using System;

class Program
{
    static void Main(string[] args)
    {
        // Get use input for reference and scripture
        Console.WriteLine("What book of scripture? ");
        string chapterReference = Console.ReadLine();
        Console.WriteLine("What chapter?");
        int chapter = int.Parse(Console.ReadLine());

        // Conditions for multiple verses
        Console.WriteLine("How many verses?");
        int verseCount = int.Parse(Console.ReadLine());
        if (verseCount > 1)
        {
            Console.WriteLine("Starting verse:");
            int startVerse = int.Parse(Console.ReadLine());
            Console.WriteLine("Ending verse: ");
            int endVerse = int.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("What verse?");
            int verse = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("Please type out the scripture or copy and paste it here.");
        string scripture = Console.ReadLine();


    }
}