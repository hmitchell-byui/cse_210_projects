using System;

public class PromptGenerator
{
    public string _prompt;

    public void GetPrompt()
    {
        string[] prompts = {
            "Write about your favorite childhood memory.",
            "Describe your perfect vacation.",
            "What is your biggest achievement?",
            "If you had superpowers, what would they be?",
            "Write a letter to your future self.",
            "What is the most important lesson you've learned?"
        };

        Random random = new Random();
        int index = random.Next(prompts.Length);
        
        _prompt = prompts[index];
        Console.WriteLine("Your writing prompt is:");
        Console.WriteLine(_prompt);
    }
}
