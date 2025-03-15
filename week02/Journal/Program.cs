using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Generate a random prompt and get the user's response
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");

                    Console.Write("Your entry: ");
                    string entryText = Console.ReadLine();

                    // Create a new journal entry and add it to the journal
                    Entry newEntry = new Entry(prompt, entryText);
                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added successfully.\n");
                    break;

                case "2":
                    // Display all journal entries
                    journal.DisplayAll();
                    break;

                case "3":
                    // Save journal to file
                    Console.Write("Enter filename to save journal: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    // Load journal from file
                    Console.Write("Enter filename to load journal: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.\n");
                    break;
            }
        }
    }
}
