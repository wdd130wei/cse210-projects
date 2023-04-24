using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();

        int number = PromptUserNumber();

        int newNumber = SquareNumber(number);

        DisplayResult(name, newNumber);
    }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;
        }

        static int SquareNumber(int favoriteNumber)
        {
            int squareNumber = favoriteNumber * favoriteNumber;
            return squareNumber;
        }

        static void DisplayResult(string userName, int squareNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
        }
    
}