using System;
using System.Collections.Generic;


public class PromptGenerator
{
    private static readonly Random Rng = new Random();
    private List<string> _prompts;

    public PromptGenerator()
    {
        // Initialize the list with some items.
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What was the most beautiful thing I saw today?",
            "What was the most important thing I learned today?",
            "Was I able to help anyone today?",
            "Did I use my time wisely today? If not, how did I waste my time?",
            "Did I go to bed and wake up at the times I promised to?"

        };
    }

    public string GetRandomPrompt()
    {
        if (_prompts == null || _prompts.Count == 0)
        {
            return "List is empty.";
        }
        // Generate a random index between 0 and the list count.
        int index = Rng.Next(0, _prompts.Count);

        // Return the item at the randomly generated index.
        return _prompts[index];

    }
}