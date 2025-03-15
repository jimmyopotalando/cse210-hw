using System;

public class Entry
{
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }

    // Constructor to initialize an entry
    public Entry(string promptText, string entryText)
    {
        Date = DateTime.Now.ToShortDateString(); // Store the current date as string
        PromptText = promptText;
        EntryText = entryText;
    }

    // Method to display the entry details
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Entry: {EntryText}");
        Console.WriteLine();
    }
}
