using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Choose a scripture to practice:");
        Console.WriteLine("1. John 3:16");
        Console.WriteLine("2. Proverbs 3:5-6");
        Console.WriteLine("3. Philippians 4:13");
        Console.WriteLine("4. Choose a random scripture");
        Console.Write("Enter 1-4: ");

        string choice = Console.ReadLine();
        Scripture scripture = ChooseScripture(choice);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press enter to hide more words or type QUIT to exit: ");

            string input = Console.ReadLine();

            if (input != null && input == "quit")
            {
                return;
            }

            if (input == "")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Great work! You have hidden every word.");
        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
    }

    static Scripture ChooseScripture(string choice)
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));

        scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));

        scriptures.Add(new Scripture(
            new Reference("Philippians", 4, 13),
            "I can do all things through Christ which strengtheneth me."));

        if (choice == "1")
        {
            return scriptures[0];
        }

        if (choice == "2")
        {
            return scriptures[1];
        }

        if (choice == "3")
        {
            return scriptures[2];
        }

        Random random = new Random();
        return scriptures[random.Next(scriptures.Count)];
    }
}