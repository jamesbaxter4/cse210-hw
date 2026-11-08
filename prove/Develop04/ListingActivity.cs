using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _response;
    private Random _random;

    public ListingActivity()
        : base("Listing", "This acitivty will help you reflect on the good things in your life by having you list as many things as you can on a specific subject.")
    {
        _prompts = new List<string>();
        _response = new List<string>();
        _random = new Random();

        _prompts.Add("Who are some of your personal heros?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("Who are people that you have helped this month?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("What are you grateful for?");
    }

    public override void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();

        Console.Write("You may begin in: ");
        ShowCountdown(5);

        Console.WriteLine();
        Console.WriteLine("Start listing items!");

        GetListFromUser(endTime);

        DisplayItemCount();

        DisplayEndingMessage();

    }

    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];

    }

    private void GetListFromUser(DateTime endTime)
    {
        _response.Clear();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(response))
            {
                _response.Add(response);
            }
        }
    }

    private void DisplayItemCount()
    {
        Console.WriteLine();
        Console.WriteLine("You listed "+ _response.Count+ " items. ");
    }
}