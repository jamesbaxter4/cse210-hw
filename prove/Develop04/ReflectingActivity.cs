using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random;

    public ReflectingActivity()
        : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
        _prompts = new List<string>();
        _questions = new List<string>();
        _random = new Random();

        _prompts.Add("Think of a time you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time you stood up for someone else.");
        _prompts.Add("Think of a time you were proud of something you accomplished.");

        
        _questions.Add("Why was this experiance meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you feel after the experience?");
        _questions.Add("What is your favorite part of the experience?");
        _questions.Add("What can you learn from that experience that applies to other situations?");
        _questions.Add("What did you learn about  yourself?");
        _questions.Add("How can you keep this experinece in mind in the future?");

    }

    public override void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        DisplayPrompt();

        while (DateTime.Now < endTime)
        {
            DisplayQuestions();

            int remainingSeconds = (int)(endTime - DateTime.Now).TotalSeconds;

            if (remainingSeconds > 0)
            {
                ShowSpinner(Math.Min(5, remainingSeconds));

            }
        }
        DisplayEndingMessage();
    }
    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
       int index = _random.Next(_questions.Count);
        return _questions[index];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue");
        Console.WriteLine();
    }

    private void DisplayQuestions()
    {
        Console.WriteLine();
        Console.WriteLine(GetRandomQuestion());
    }
}