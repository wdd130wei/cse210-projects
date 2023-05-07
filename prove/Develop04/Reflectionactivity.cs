public class ReflectionActivity : Activity
{
    private Random promptRandom = new Random();
    public ReflectionActivity(string name, string description) : base(name, description)
    {

    }
    public void Reflection()
    {
        StartMessage(_name, _description);

        int _timer = GetTime();
        Console.WriteLine(_timer);

        Console.Clear();

        Console.WriteLine("Get ready...");
        Spinner(5);
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        PromptGenerator();
        Console.WriteLine();

        Console.WriteLine("When you something in mind, press enter to continue.");
        string response = Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        TimeSpinner();

        Console.Clear();

        QuestionGenerator(_timer);

        Console.WriteLine();

        EndMessage(_timer);
    }

    public void PromptGenerator()
    {
        List<string> prompts = new List<string>()
        {
            "---Think of a time when you stood up for someone else.---",
            "---Think of a time when you did something really difficult.---",
            "---Think of a time when you helped someone in need.---",
            "---Think of a time when you did something truly selfless.---"
        };

        int randomIndex = promptRandom.Next(prompts.Count);
        Console.WriteLine(prompts[randomIndex]);
    }

    public void QuestionGenerator(int setTime)
    {
        List<string> questions = new List<string>()
        {
            "> Why was this experience meaningful to you? ",
            "> Have you ever done anything like this before? ",
            "> How did you get started? ",
            "> How did you feel when it was complete?",
            "> What made this time different than other times when you were not as successful? ",
            "> What is your favorite thing about this experience? ",
            "> What could you learn from this experience that applies to other situations? ",
            "> What did you learn about yourself through this experience? ",
            "> How can you keep this experience in mind in the future? "
        };

        List<string> hasBeenShownList = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(setTime);

        while (DateTime.Now < endTime)
        {
            int randomIndex = promptRandom.Next(questions.Count);
            string randomQuestion = questions[randomIndex];

            if (!hasBeenShownList.Contains(randomQuestion))
            {
                Console.Write(randomQuestion);
                hasBeenShownList.Add(randomQuestion);
                Spinner(10);
                Console.WriteLine();
            }
            else if (hasBeenShownList.Count == questions.Count)
            {
                Console.Write(randomQuestion);
                Spinner(10);
                Console.WriteLine();
            }
        }
    }

    public void TimeSpinner()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        while (DateTime.Now <endTime)
        {
            Console.Write("You may begin in...");
            for (int j = 5;  j > 0; j--)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }

}