using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entry = new List<Entry>();
    static void AddEntry(int newEntry, string Entry)
    {
        
    }

    public void DisplayAll()
    {
        Console.WriteLine("All Entries");
        foreach (Entry entry in _entry)
        {entry.DisplayPrompt();}
    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("File Saved!");
        //Save to file!
    }
    public void LoadFromFile(string file)
    {
        Console.WriteLine("Loading File...");
        // Load from file!
    }
    
}