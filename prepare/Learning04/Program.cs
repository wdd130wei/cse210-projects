using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        MathAssignment assignment2 = new MathAssignment("Roberto Rodriguez", "Fractions","Section 7.3", "Problems 8-19");
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine();

        WriteAssignment assignment3 = new WriteAssignment("Mary Waters", "European History","The Causes of World War II by Mary Waters");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}