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
        Console.Clear();
        DisplayStartingMessage();
        _duration = 0;
        while (_duration == 0)
        {
            Console.WriteLine();
            Console.Write("How long, in seconds, would you like for your session? ");
            try
            {
                _duration = int.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                
                Console.WriteLine("Please enter a number");
            }
        }
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
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