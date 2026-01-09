using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        
        string userInput = Console.ReadLine();
        int userPercent = int.Parse(userInput);
        string grade;
        
        if (userPercent >= 90)
        {
            grade = "A";
        }
        else if (userPercent >= 80)
        {
            grade = "B";
        }
        else if (userPercent >= 70)
        {
            grade = "C";
        }
        else if (userPercent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        if (userPercent < 94 && userPercent >= 60 )
        {
            if (userPercent % 10 < 3)
            {
                grade += "-";
            }
            else if (userPercent % 10 >= 7)
            {
                grade += "+";
            }
        }

        Console.WriteLine($"Your grade letter is {grade}.");

        if (userPercent >= 70)
        {
            Console.WriteLine("Congradulations you passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry you failed the course, better luck next time.");
        }
    }
}