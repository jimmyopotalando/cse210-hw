using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;

    // Constructor to initialize the list of prompts
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What was the best part of your day?",
            "What did you learn today?",
            "What was the most challenging part of your day?",
            "What are you grateful for today?",
            "What did you accomplish today?"
        };
    }

    // Method to get a random prompt from the list
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
