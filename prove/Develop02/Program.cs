using System;
using System.ComponentModel.Design;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Journal newJournal = new Journal();
        int choice = 0;

        Console.WriteLine("Welcome to the Journal!");

        while (choice != 5)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Displasy the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Select a choice: ");

            string input = Console.ReadLine();
                if (int.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            newJournal.AddEntry();
                            break;
                        case 2:
                            newJournal.DisplayAll();
                            break;
                        case 3:
                            newJournal.SaveToFile();
                            break;
                        case 4:
                            Console.Write("What is the filename? ");
                            string loadFile = Console.ReadLine();
                            newJournal.LoadFromFile(loadFile);
                            break;
                        case 5:
                            Console.WriteLine("Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select between 1 and 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
        }

    }
}