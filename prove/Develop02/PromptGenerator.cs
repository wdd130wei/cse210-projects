
class PromptGenerator
{
    List<string> prompts;

    public PromptGenerator()
    {
        prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    public string GetRandomPrompt()
    {
        string randomPrompt = GetRandomPrompt(prompts);
        Console.WriteLine(randomPrompt);
        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        return prompts[randomIndex];
    }
}
