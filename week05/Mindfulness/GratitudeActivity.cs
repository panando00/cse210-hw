using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _prompts;
    private List<string> _unusedPrompts;

    public GratitudeActivity()
        : base("Gratitude Activity",
               "This activity will help you develop an attitude of gratitude by focusing on specific aspects of your life you're thankful for.")
    {
        _prompts = new List<string>
        {
            "What is something small that brought you joy today?",
            "What is a challenge that you're grateful for because it helped you grow?",
            "What is something in nature that fills you with wonder?",
            "What is a memory that always makes you smile?",
            "What is a skill or ability you're thankful to have?"
        };

        ResetPromptPool();
    }

    private void ResetPromptPool()
    {
        _unusedPrompts = new List<string>(_prompts);
    }

    private string GetRandomPrompt()
    {
        if (_unusedPrompts.Count == 0)
            ResetPromptPool();
            
        int index = _random.Next(_unusedPrompts.Count);
        string prompt = _unusedPrompts[index];
        _unusedPrompts.RemoveAt(index);
        return prompt;
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("For this activity, take time to deeply consider each prompt about gratitude.");
        Console.WriteLine("Write your thoughts for each prompt, and then press enter when ready for the next one.");
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"--- {GetRandomPrompt()} ---");
            Console.Write("> ");
            Console.ReadLine();
            ShowSpinner(3);
            Console.WriteLine();
        }
    }
}