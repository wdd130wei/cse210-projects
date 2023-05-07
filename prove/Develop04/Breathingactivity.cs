public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
    }

    public void Breathing()
    {
        StartMessage(_name, _description);

        int _timer = GetTime();
        Console.WriteLine(_timer);

        Console.Clear();

        Console.WriteLine("Get ready...");
        Spinner(5);
        Console.WriteLine();

        NumberSpinner(_timer);

        EndMessage(_timer);
    }

    public void NumberSpinner(int setTime)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(setTime);

        while (DateTime.Now <endTime)
        {
            Console.Write("Breath in...");
            for (int j = 4;  j > 0; j--)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.Write("Now Breath out...");
            for (int j = 6;  j > 0; j--)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}