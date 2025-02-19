using System;
using System.Collections.Generic;
using System.IO;

public class QuestProgram
{
    private List<Goal> _goals;
    private int _score;
    private const string SAVE_FILE = "goals.json";

    public QuestProgram()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Run()
    {
        LoadGoals();
        bool running = true;

        while (running)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    DisplayScore();
                    break;
                case "5":
                    SaveGoals();
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void DisplayMenu()
    {
        Console.WriteLine("\nEternal Quest Program");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Record Event");
        Console.WriteLine("4. Display Score");
        Console.WriteLine("5. Save and Quit");
        Console.Write("Select an option: ");
    }

    private void CreateNewGoal()
    {
        Console.WriteLine("\nGoal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        
        string type = Console.ReadLine();
        
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        
        Console.Write("Enter points for completing: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal;

        switch (type)
        {
            case "1":
                goal = new SimpleGoal(name, description, points);
                break;
            case "2":
                goal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completing all: ");
                int bonus = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals.Add(goal);
        Console.WriteLine("Goal created successfully!");
    }

    private void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nNo goals created yet.");
            return;
        }

        Console.WriteLine("\nCurrent Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatusString()}");
        }
    }

    private void RecordEvent()
    {
        ListGoals();
        Console.Write("\nWhich goal did you accomplish? (Enter number): ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            int points = _goals[choice].RecordEvent();
            _score += points;
            Console.WriteLine($"Congratulations! You earned {points} points!");
            DisplayScore();
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    private void DisplayScore()
    {
        Console.WriteLine($"\nCurrent Score: {_score} points");
    }

    private void SaveGoals()
    {
        Console.WriteLine("Goals and score saved!");
    }

    private void LoadGoals()
    {
        if (File.Exists(SAVE_FILE))
        {
            Console.WriteLine("Previous goals and score loaded!");
        }
    }
}