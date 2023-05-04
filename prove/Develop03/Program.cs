using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string scriptureText = " Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";

        Scripture scripture = new Scripture(reference, scriptureText);

        Console.WriteLine("How many words you want to hide");
        int numberOfWords = int.Parse(Console.ReadLine());

        while (true)
        {
            Console.Clear();
            Console.Write(reference.ToString());
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine();
            Console.WriteLine("Press enter to hide words or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            scripture.HideWords(numberOfWords);
        }
    }
}