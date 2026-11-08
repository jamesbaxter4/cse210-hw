using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public abstract void Run();

    protected void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine("Welcome to the " + _name + ".");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in second would you like for your session?");
        

        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.Write("Please enter a positive number of seconds: ");

        }

        Console.WriteLine();
        Console.WriteLine("Get ready..");
        ShowSpinner(3);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Good job!");
        ShowSpinner(2);

        Console.WriteLine();
        Console.WriteLine("You have completed the " + _name + " for " + _duration + " seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = {"|","/","-","\\"};

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            index++;

            if (index >= spinner.Length)
            {
                index = 0;
            }
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
    }

    protected int GetDuration()
    {
        return _duration;
    }
}