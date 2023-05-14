using System;

class Program
{

    static void Main(string[] args)
    {
        int menuUserinput = 0;

        List<Goal> goals = new List<Goal>();
        GoalManager goalManager = new GoalManager();
        int displayCurrentValue = goalManager.GetValue();
        string displayCurrentLevel = goalManager.DetermineLevel(displayCurrentValue);

        List<string> menu = new List<string>
            {
                $"You have {displayCurrentValue} points.",
                "",
                "Menu Options:",
                "1. Create New Goal",
                "2. List Goals",
                "3. Save Goals",
                "4. Load Goals",
                "5. Record Event",
                "6. Quit",
                "Select a choice from the menu: "
            };
        

        while (menuUserinput != 6)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuUserinput = int.Parse(Console.ReadLine());

            if (menuUserinput == 1)
            {
                goalManager.CreateGoal();
            }

            else if (menuUserinput ==2 )
            {
                goalManager.DisplayGoals();
            }

            else if (menuUserinput == 3)
            {
                goalManager.SaveToCSV();
            }
            else if (menuUserinput == 4)
            {
                goalManager.LoadFromCSV();
                displayCurrentValue = goalManager.GetValue();
                displayCurrentLevel = goalManager.DetermineLevel(displayCurrentValue);
                menu[0] = $"You have {displayCurrentValue} points. {displayCurrentLevel}";
            }
            else if (menuUserinput == 5)
            {
                goalManager.AddPoints();
                displayCurrentValue = goalManager.GetValue();
                displayCurrentLevel = goalManager.DetermineLevel(displayCurrentValue);
                menu[0] = $"You have {displayCurrentValue} points. {displayCurrentLevel}";
            }
        }
    }
}