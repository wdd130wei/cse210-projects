using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();

        Running exercise1 = new Running(DateTime.Now, 30, 5);

        Cycling exercise2 = new Cycling (DateTime.Now, 30, 10);

        Swimming exercise3 = new Swimming(DateTime.Now, 30, 20);

        exercises.Add(exercise1);
        exercises.Add(exercise2);
        exercises.Add(exercise3);

        foreach (Exercise exercise in exercises)
        {
            Console.WriteLine($"Summary: {exercise.GetSummary()}");
            Console.WriteLine();
        }
    }
}