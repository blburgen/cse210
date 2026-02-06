public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity"; 
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 0;
    }
    public void Run()
    {
        DisplayStartingMessage();
        int temp = _duration;
        while(temp > 0)
        {
            Console.Write("Breath in...");
            ShowCountDown(Math.Min(temp,4));
            temp -= 4;
            Console.WriteLine();
            Console.Write("Breath out...");
            ShowCountDown(Math.Min(temp,4));
            temp -= 4;
            Console.WriteLine();
            Console.WriteLine();
        }
        DisplayEndingMessage();
        
    }
}