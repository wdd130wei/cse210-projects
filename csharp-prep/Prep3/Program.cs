using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int guessAnswer = -1;

        while (guessAnswer != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessAnswer = int.Parse(Console.ReadLine());
            
            if (guessAnswer > magicNumber)
            {
            Console.WriteLine("Lower");
            }
        
            else if (guessAnswer < magicNumber)
            {
            Console.WriteLine("Higher");
            }        
        
            else if (guessAnswer == magicNumber)
            {
            Console.WriteLine("You guessed it!");
            }
        }

    }
}