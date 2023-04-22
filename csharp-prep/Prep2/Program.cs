using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your score: ");
        int score = int.Parse(Console.ReadLine());

        string passMessage = "You passed the exam.";

        string failedMessage = "Study harder next time.";

        if (score >= 70)
        {
            

            if (score >= 90 && score <= 100)
            {
                Console.WriteLine($" {passMessage} Your grade is A.");
            }
            
            else if (score >= 80 && score < 90)
            {
                Console.WriteLine($"{passMessage} Your grade is B.");
            }
            
            else if (score >= 70 && score <80)
            {
                Console.WriteLine($"{passMessage} Your grade is C.");
            }
        }

        else
        {
;

            if (score >= 60 && score < 70)
            {
                Console.WriteLine($" {failedMessage} Your grade is D.");
            }

            else if (score >= 0 && score < 60)
            {
                Console.WriteLine($" {failedMessage} Your grade is F.");
            }
        }

    }
}