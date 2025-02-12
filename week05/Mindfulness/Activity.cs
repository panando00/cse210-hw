using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected static Random _random = new Random();
    private static Dictionary<string, int> _activityLog = new Dictionary<string, int>();

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void RunActivity()
    {
        DisplayStartingMessage();
        PerformActivity();
        DisplayEndingMessage();
        LogActivity();
    }

    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        List<string> spinnerChars = new List<string> { "|", "/", "-", "\\" };
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerChars[i]);
            Thread.Sleep(100);
            Console.Write("\b \b");
            i = (i + 1) % spinnerChars.Count;
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    private void LogActivity()
    {
        if (!_activityLog.ContainsKey(_name))
            _activityLog[_name] = 0;
        _activityLog[_name]++;
        
        using (StreamWriter writer = File.AppendText("activity_log.txt"))
        {
            writer.WriteLine($"{DateTime.Now},{_name},{_duration}");
        }
    }

    public static void DisplayStats()
    {
        Console.WriteLine("\nActivity Statistics for this session:");
        foreach (var activity in _activityLog)
        {
            Console.WriteLine($"{activity.Key}: {activity.Value} times");
        }
        Console.WriteLine();
    }

    protected abstract void PerformActivity();
}