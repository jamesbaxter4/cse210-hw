using System;

class Program
{
    static void Main()
    {
        // Ask first name
        Console.WriteLine("What is your first name?");

        string first_name = Console.ReadLine();

        // Ask last name
        Console.WriteLine("What is your last name?");

        string last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}");

    }
}