using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        List<int> numbers = new List<int>();

        int newNumber = -1;

        int sum = 0;

        int countNumber = 0;

        int largestNumber = -99999;

        while (newNumber != 0)
        {
            Console.Write("Enter number: ");
            newNumber = int.Parse(Console.ReadLine());
            
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            countNumber += 1;
        }

        Console.WriteLine("The sum is " + sum);

        float average = ((float)sum) / countNumber;
        Console.WriteLine("The average is: " + average);

        for (int i = 0; i < numbers.Count; i++)
        {
            if (largestNumber <= numbers[i])
            {
                largestNumber = numbers[i];
            }
        }

        Console.WriteLine("The largest number is: " + largestNumber);
    }
}