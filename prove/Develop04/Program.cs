using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();

            Console.WriteLine("Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out choice))
            {
                Activity activity = null;

                switch (choice)
                {
                    case 1:
                    activity = new BreathingActivity();
                    break;

                    case 2:
                    activity = new ReflectingActivity();
                    break;

                    case 3:
                    activity = new ListingActivity();
                    break;

                    case 4:
                    Console.WriteLine("Thank you for using the Mindfulness Program.");
                    break;

                    default:
                    Console.WriteLine("Invalid choice. Please select 1-4.");
                    break;
                }

                if (activity != null)
                {
                    activity.Run();
                }

                if (choice != 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to return to the menu.");
                    Console.WriteLine();
                }
            }

            else
            {
                Console.WriteLine("Please enter a valid number.");
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
                choice = 0;
            }
        }
    }
}