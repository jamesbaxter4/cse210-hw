using System;

class Program
{
    static void Main()
    {

        // Ask for grade
        Console.Write("What is your grade percent?");
        string userGrade = Console.ReadLine();

        int numberGrade = int.Parse(userGrade);

        string grade = "";
        
        // Assign grade letter
        if (numberGrade < 60)
        {
            grade = ("F");
        }
        else if (numberGrade >= 60 && numberGrade <= 69)
        {
            grade = ("D");
        }
        else if (numberGrade >= 70 && numberGrade <= 79)
        {
            grade = ("C");
        }
        else if (numberGrade >= 80 && numberGrade <= 89)
        {
            grade = ("B");
        }
        else if (numberGrade >= 90 && numberGrade <= 100)
        {
            grade = ("A");
        }

        Console.WriteLine ($"Your grade is: {grade}");

        // Assign pass or fail
        if (numberGrade >= 70)
        {
            Console.WriteLine("Congrats you passed!");
        }
        else
        {
            Console.WriteLine("You failed; better luck next time!");
        }

        
    }
}