// Added levels based on how many goals have been completed
// When listing record even, I removed goals that have been completed
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalManager newManager = new GoalManager();
        newManager.Start();
    }
}