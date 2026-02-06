public class ReflectingActivity : Activity
{
    private List<string> _questions;
    private List<string> _prompts;

    public ReflectingActivity()
    {
        _name = "Reflecting Activity"; 
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.  This will help you recongnize the power you have and how you can use it in other aspect of your life.";
        _duration = 0;
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public string GetRandomQuestion()
    {
        return "";
    }
    public void DisplayPrompt()
    {
        
    }
    public void DisplayQuestions()
    {
        
    }
}