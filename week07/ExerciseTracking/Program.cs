using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity newActivity = new RunningActivity();
        newActivity.GetStartDate();
        newActivity.GetSummary();
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
    }
}