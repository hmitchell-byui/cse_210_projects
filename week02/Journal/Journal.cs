using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.DisplayPrompt();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry._date);
                writer.WriteLine(entry._promptText);
                writer.WriteLine(entry._entryText);
                writer.WriteLine("---"); // Separator between entries
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            Entry entry = null;
            while ((line = reader.ReadLine()) != null)
            {
                if (line == "---")
                {
                    _entries.Add(entry);
                    entry = null;
                }
                else
                {
                    if (entry == null)
                    {
                        entry = new Entry();
                        entry._date = line;
                    }
                    else if (string.IsNullOrEmpty(entry._promptText))
                    {
                        entry._promptText = line;
                    }
                    else
                    {
                        entry._entryText = line;
                    }
                }
            }
            if (entry != null) _entries.Add(entry); // Add the last entry if not ended with ---
        }
    }
}
