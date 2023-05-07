public class ListeningActivity : Activity
{
    private Random promptRandom = new Random();
    private int k = 0;
    public ListeningActivity(string name, string description) : base(name, description)
    {
    }
    public void Listening()
    {
        StartMessage(_name, _description);

        int _timer = GetTime();
        Console.WriteLine(_timer);

        Console.Clear();

        Console.WriteLine("Get ready...");
        Spinner(5);
        Console.WriteLine();

        Console.WriteLine("List as many responses you can to the following prompt:");
        PromptGenerator();

        TimeSpinner();

        Console.WriteLine();

        AnswerList(_timer);

        Console.WriteLine();

        EndMessage(_timer);
    }

    public void PromptGenerator()
    {
        List<string> prompts = new List<string>()
        {
            "---Who are people that you appreciate?---",
            "---What are personal strengths of yours?---",
            "---Who are people that you have helped this week?---",
            "---When have you felt the Holy Ghost this month?---",
            "---Who are some of your personal heroes?---"
        };

        int randomIndex = promptRandom.Next(prompts.Count);
        Console.WriteLine(prompts[randomIndex]);
    }

    public void AnswerList(int setTime)
    {
        List<string> answerList = new List<string>()
        {
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(setTime);

        while (DateTime.Now <endTime)
        {
            string newAnswer = Console.ReadLine();
            answerList.Add(newAnswer);
            k++;
        }
        Console.WriteLine($"You listed {k} items");
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