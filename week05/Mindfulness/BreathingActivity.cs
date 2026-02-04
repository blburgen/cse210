public class BreathingActivity : Activity
{
    public BreathingActivity() : 
        base ("Breathing Activity", 
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
    }
}