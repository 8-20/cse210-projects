using System;
using System.Collections.Generic;

public class PromptGenerator
{
     // A static Random instance is efficient and ensures better randomness
    // when the method is called repeatedly in a short time.
    private static readonly Random Rng = new Random();
    private List<string> prompts;

    public PromptGenerator()
    {
        // Initialize the list with some items.
        prompts = new List<string>
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
    /// <summary>
    /// Selects and returns a random item from the list.
    /// </summary>
    /// <returns>A randomly selected string.</returns>
    public string GetRandomPrompt()
    {
        if (prompts == null || prompts.Count == 0)
        {
            return "List is empty.";
        }
        // Generate a random index between 0 (inclusive) and the list count (exclusive).
        int index = Rng.Next(0, prompts.Count);

        // Return the item at the randomly generated index.
        return prompts[index];

    }
}