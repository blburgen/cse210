public class Activity
{
    protected int _duration;
    protected string _name;
    protected string _description;
    public Activity()
    {
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        _duration = 1;
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done.");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = seconds; i >0; i-=2)
        {
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for(int i = seconds; i>0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                for(int j = i/10 + 1; j > 0; j--)
                {
                    Console.Write("\b");
                }
                for(int j = i/10 + 1; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for(int j = i/10 + 1; j > 0; j--)
                {
                    Console.Write("\b");
                }
            }
    }
}