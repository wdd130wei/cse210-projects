using System.Collections.Generic;
using System.IO;
class Journal
{
    List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void DisplayJournalEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
            Console.WriteLine();
        }
    }
    public void CreateJournalEntry()
    {
        PromptGenerator generator = new PromptGenerator();
        string randomPrompt = generator.GetRandomPrompt();

        Console.WriteLine(randomPrompt);
        string response = Console.ReadLine();

        string date = DateTime.Now.ToString("dd-MM-yyyy");

        Entry newEntry = new Entry(date, randomPrompt, response);
        entries.Add(newEntry);
    }

    public void SaveToCSV()
    {
    string currentDirectory = Directory.GetCurrentDirectory();
    string filePath = Path.Combine(currentDirectory, "Journal.csv");

    using (StreamWriter writer = new StreamWriter(filePath))
    {
        foreach (Entry entry in entries)
        {
            string entryCSV = entry.GetEntryAsCSV();
            writer.WriteLine(entryCSV);
        }
    }

    Console.WriteLine($"Saved to CSV file. File path: {filePath}");
    Console.WriteLine();
    }

    public void LoadFromCSV()
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string filePath = Path.Combine(currentDirectory, "Journal.csv");

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File does not exist.");
            Console.WriteLine();
            return;
        }

        entries.Clear();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] entryData = line.Split('|');
                if (entryData.Length == 3)
                {
                    string date = entryData[0];
                    string prompt = entryData[1];
                    string response = entryData[2];
                    Entry entry = new Entry(date, prompt, response);
                    entries.Add(entry);
                }
            }
        }

        Console.WriteLine($"Loaded from CSV file. File path: {filePath}");
        Console.WriteLine();
    }

}