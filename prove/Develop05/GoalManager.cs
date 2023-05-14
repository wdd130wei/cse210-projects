using System;
using System.Collections.Generic;
using System.IO;
class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _amountPoint = 0;
    private int _currentValue;
    private bool _isComplete;
    public void CreateGoal()
    {
        List<string> goalMenu = new List<string>
        {
            "The type of Goals are:",
            "1. Simple Goal",
            "2. Eternal Goal",
            "3. Checklist Goal",
        };

        foreach(string goalOption in goalMenu)
        {
            Console.WriteLine(goalOption);
        }

        Console.WriteLine("Which type of goal would you like to create? ");
        int choiceGoal = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the name of your goal? ");
        string nameGoal = Console.ReadLine();

        Console.WriteLine("What is a short description of it?");
        string descriptionGoal = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal?");
        int amountPoint = int.Parse(Console.ReadLine());


        if (choiceGoal == 1)
        {   
            string typeGoal = "SimpleGoal";
            Goal newEntry = new SimpleGoal(typeGoal, nameGoal, descriptionGoal, amountPoint, _isComplete);
            _goals.Add(newEntry);
        }

        else if (choiceGoal == 2)
        {
            string typeGoal = "EternalGoal";
            Goal newEntry = new EternalGoal(typeGoal, nameGoal, descriptionGoal, amountPoint);
            _goals.Add(newEntry);
        }

        else if (choiceGoal == 3)
        {
            string typeGoal = "ChecklistGoal";
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            int targetCount = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            int bonusValue = int.Parse(Console.ReadLine());
            int count = 0;
            Goal newEntry = new ChecklistlGoal(typeGoal, nameGoal, descriptionGoal, amountPoint,bonusValue, count, targetCount);
            _goals.Add(newEntry);
        }
    }
    public void SaveToCSV()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        string currentDirectory = Directory.GetCurrentDirectory();
        string filePath = Path.Combine(currentDirectory, filename);

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(_currentValue);
            foreach (Goal goal in _goals)
            {
                string entryCSV = goal.GetEntryAsCSV();
                writer.WriteLine(entryCSV);
            }
        }

        Console.WriteLine($"Saved to CSV file. File path: {filePath}");
        Console.WriteLine();
    }
    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            string type = _goals[i].GetGoalType();
            string status = _goals[i].StatusString();
            if (type == "SimpleGoal")
            {
                Console.WriteLine($"{i + 1}. {status} {_goals[i].GetName()} ({_goals[i].GetDescription()} )");
            }
            else if (type == "EternalGoal")
            {
                Console.WriteLine($"{i + 1}. {status} {_goals[i].GetName()} ({_goals[i].GetDescription()} )");
            }
            else if (type == "ChecklistGoal")
            {
                Console.WriteLine($"{i + 1}. {status} {_goals[i].GetName()} ({_goals[i].GetDescription()}) -- Currently completed: {_goals[i].GetCount()}/{_goals[i].GetTargetCount()}");
            }
        }
    }
    public void LoadFromCSV()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        string currentDirectory = Directory.GetCurrentDirectory();
        string filePath = Path.Combine(currentDirectory, filename);

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File does not exist.");
            Console.WriteLine();
            return;
        }

        _goals.Clear();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] entryData = line.Split(',');

                if (entryData.Length ==1)
                {
                    _currentValue = int.Parse(entryData[0]);
                }

                else if (entryData.Length ==4)
                {
                    if (entryData[0].StartsWith("SimpleGoal:"))
                    {
                        string typeGoal = "SimpleGoal";
                        string nameGoal = entryData[0].Substring("SimpleGoal:".Length).Trim();
                        string descriptionGoal = entryData[1];
                        int amountPoint = int.Parse(entryData[2]);
                        bool isComplete = bool.Parse(entryData[3]);

                        Goal entry = new SimpleGoal(typeGoal, nameGoal, descriptionGoal, amountPoint, isComplete);
                        _goals.Add(entry);
                    }
                }

                else if (entryData.Length ==3)
                {
                    if (entryData[0].StartsWith("EternalGoal:"))
                    {
                        string typeGoal = "EternalGoal";
                        string nameGoal = entryData[0].Substring("EternalGoal:".Length).Trim();
                        string descriptionGoal = entryData[1];
                        int amountPoint = int.Parse(entryData[2]);
                        Goal entry = new EternalGoal(typeGoal, nameGoal, descriptionGoal, amountPoint);
                        _goals.Add(entry);
                    }
                }

                else if (entryData.Length ==6)
                {
                    if (entryData[0].StartsWith("ChecklistGoal:"))
                    {
                        string typeGoal = "ChecklistGoal";
                        string nameGoal = entryData[0].Substring("ChecklistGoal:".Length).Trim();
                        string descriptionGoal = entryData[1];
                        int amountPoint = int.Parse(entryData[2]);
                        int bonusValue = int.Parse(entryData[3]);
                        int count = int.Parse(entryData[4]);
                        int targetCount = int.Parse(entryData[5]);
                        Goal entry = new ChecklistlGoal(typeGoal, nameGoal, descriptionGoal, amountPoint, bonusValue, count, targetCount);
                        _goals.Add(entry);
                    }
                }
            }
        }
    }

    public void AddPoints()
    {
        Console.WriteLine("The goals are:");
        DisplayGoals();
        Console.Write("which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        Goal selectGoal = _goals[index];
        string targetType = selectGoal.GetGoalType();
        if (targetType == "SimpleGoal"|| targetType == "EternalGoal")
        {
            selectGoal.MarkComplete();
            _amountPoint = selectGoal.GetAmountPoint();
            _currentValue += _amountPoint;
        }

        else if (targetType == "ChecklistGoal")
        {
            selectGoal.MarkComplete();
            int value = selectGoal.GetTotalvalue();
            _currentValue = _currentValue + value;
        }
        Console.WriteLine($"You now have {_currentValue} points");
        Console.WriteLine();
    }

    public int GetValue()
    {
        return _currentValue;
    }

    public string DetermineLevel(int currentValue)
    {
        int[] levelThresholds = {0, 100, 200, 300, 400};
        int level = 1;
        for (int i = 1; i < levelThresholds.Length; i++)
        {
            if (currentValue >= levelThresholds[i])
            {
                level++;
            }
            else
            {
                break;
            }
        }
        return "Level " + level;
    }

}