public class Activity
{
    private int _duration;
    private string _name;
    private string _description;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
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
        
    }

    public void ShowSpinner(int seconds)
    {
        
    }

    public void ShowCountDown(int seconds)
    {
        
    }
}