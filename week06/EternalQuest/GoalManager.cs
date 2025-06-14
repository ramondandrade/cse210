using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {

        int choice = 0;

        while (choice != 6)
        {

            
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. Create New Goal");
            Console.WriteLine("3. List Goals");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save/Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();
            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    DisplayPlayerInfo();
                    break;
                case 2:
                    CreateGoal();
                    break;
                case 3:
                    ListGoalDetails();
                    break;
                case 4:
                    RecordEvent();
                    break;
                case 5:
                    Console.WriteLine("1. Save Goals\n2. Load Goals");
                    string option = Console.ReadLine();
                    if (option == "1")
                    {
                        SaveGoals();
                        Console.WriteLine("Goals saved.");
                    }
                    else if (option == "2")
                    {
                        LoadGoals();
                        Console.WriteLine("Goals loaded.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid option.");
                    }
                    break;
                case 6:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose 1-6.");
                    break;
            }
        }

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\n\n--- Create New Goal ---");
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice (1-3): ");
        string input = Console.ReadLine();
        int choice;
        if (!int.TryParse(input, out choice) || choice < 1 || choice > 3)
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
            return;
        }
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        
        Console.Write("Enter points for the goal: ");
        string pointsInput = Console.ReadLine();
        int points;
        if (!int.TryParse(pointsInput, out points) || points < 0)
        {
            Console.WriteLine("Invalid points. Please enter a non-negative integer.");
            return;
        }
        switch (choice)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("Enter target number of completions: ");
                string targetInput = Console.ReadLine();
                int target;
                if (!int.TryParse(targetInput, out target) || target <= 0)
                {
                    Console.WriteLine("Invalid target. Please enter a positive integer.");
                    return;
                }
                Console.Write("Enter bonus points for completing the checklist: ");
                string bonusInput = Console.ReadLine();
                int bonus;
                if (!int.TryParse(bonusInput, out bonus) || bonus < 0)
                {
                    Console.WriteLine("Invalid bonus. Please enter a non-negative integer.");
                    return;
                }
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }
        Console.WriteLine("Goal created successfully!");
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        _score += _goals[index].RecordEvent();
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string[] data = parts[1].Split('|');

            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2])) { });
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                    break;
                case "ChecklistGoal":
                    ChecklistGoal cg = new ChecklistGoal(data[0], data[1], int.Parse(data[2]),
                                                         int.Parse(data[3]), int.Parse(data[4]));
                    typeof(ChecklistGoal).GetField("_amountCompleted", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                                         .SetValue(cg, int.Parse(data[5]));
                    _goals.Add(cg);
                    break;
            }
        }
    }
}
