using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries; // List to hold the journal entries

    // Constructor to initialize the list of entries
    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Method to add a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Method to display all entries in the journal
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal.");
            return;
        }

        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    // Method to save the journal entries to a file
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.PromptText}|{entry.EntryText}");
            }
        }
        Console.WriteLine("Journal saved to file.");
    }

    // Method to load journal entries from a file
    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        _entries.Clear(); // Clear current entries before loading new ones

        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            var parts = line.Split('|');
            if (parts.Length == 3)
            {
                _entries.Add(new Entry(parts[1], parts[2]) { Date = parts[0] });
            }
        }
        Console.WriteLine("Journal loaded from file.");
    }
}
