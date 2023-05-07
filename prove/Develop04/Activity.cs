public class Activity
{
    protected string _name;
    protected string _description;

    private int i=0;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartMessage(string _name, string _description)
    {   
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public int GetTime()
    {
        Console.Write("How long, in seconds would you like for your session? ");
        int _setTime = int.Parse(Console.ReadLine());
        return _setTime;
    }

    public void EndMessage(int time)
    {
        Console.WriteLine("Well done!");
        Spinner(5);
        Console.WriteLine();

        Console.WriteLine($"You have completed another {time} seconds of {_name}.");
        Spinner(5);
        Console.WriteLine();
    }

    public void Spinner(int time)
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }
}