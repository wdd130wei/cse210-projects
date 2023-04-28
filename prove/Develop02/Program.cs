using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int menuUserinput = 0;

        List<string> menu = new List<string>
            {
                "Please select one of the following choices:",
                "1. Write",
                "2. Display",
                "3. Load",
                "4. Save",
                "5. Quit",
                "6. Delete my journal",
                "What would you like to do?"
            };

        while (menuUserinput != 5)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuUserinput = int.Parse(Console.ReadLine());

            if (menuUserinput == 1)
            {
                journal.CreateJournalEntry();
            }
            else if (menuUserinput == 2)
            {
                journal.DisplayJournalEntries();
            }
            else if (menuUserinput == 3)
            {
                journal.LoadFromCSV();
            }
            else if (menuUserinput == 4)
            {
                journal.SaveToCSV();
            }

            else if (menuUserinput == 5)
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }

            else if (menuUserinput == 6)
            {
                journal.DeleteCSV();
            }
        }


    }
}