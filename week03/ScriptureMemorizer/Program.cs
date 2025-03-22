using System;

class Program
{
    static void Main()
    {
        // Example usage
        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture = new Scripture(reference, scriptureText);

        // Main loop
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide some words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3); // Hide 3 random words per step
        }

        // Final display when all words are hidden
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("All words are now hidden!");
    }
}
