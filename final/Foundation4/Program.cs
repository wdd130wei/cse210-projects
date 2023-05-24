using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();

        Running exercise1 = new Running("21/05/2023", 30, 5);

        exercises.Add(exercise1);

        foreach (Exercise exercise in exercises)
        {
            Console.WriteLine("Exercise: ");
            Console.WriteLine($"Distance: {exercise.GetDistance()}");
            Console.WriteLine($"Summary: {exercise.GetSummary()}");
        }
    }
}