using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {    
    }

    public override void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            int remainingSeconds = (int)(endTime - DateTime.Now).TotalSeconds;

            if (remainingSeconds <= 0)
            {
                break;
            }

            BreatheIn();
            ShowCountdown(Math.Min(5, remainingSeconds));

            remainingSeconds = (int)(endTime - DateTime.Now).TotalSeconds;

            if (remainingSeconds <= 0)
            {
                break;
            }

            BreatheOut();
            ShowCountdown(Math.Min(5, remainingSeconds));
        }
        DisplayEndingMessage();
    }
    
    private void BreatheIn()
    {
        Console.WriteLine();
        Console.WriteLine("Breathe in...");

    }

    private void BreatheOut()
    {
        Console.WriteLine();
        Console.WriteLine("Breathe out...");
    }
}