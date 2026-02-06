public class ReflectingActivity : Activity
{
    private List<string> _questions;
    private List<string> _prompts;
    private List<int> _questionsUsed = [];

    public ReflectingActivity()
    {
        _name = "Reflecting Activity"; 
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.  This will help you recongnize the power you have and how you can use it in other aspect of your life.";
        _duration = 0;
        _prompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ];
        _questions = [
            "Why was this experience meaningful to you?",
            "How did you get started?",
            "Have you ever done anything like this before?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        int end = _duration;
        while(end > 0)
        {
            DisplayQuestions();
            end -= 5;
        };
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int temp = random.Next(0,_prompts.Count);
        return _prompts[temp];
    }

    public string GetRandomQuestion()
    {
        bool newQuestion = false;
        Random random = new Random();
        int temp = -1;
        while(newQuestion == false)
        {
            temp = random.Next(0,_questions.Count);
            if (_questionsUsed.Contains(temp))
            {
                continue;
            }
            else
            {
                _questionsUsed.Add(temp);
                newQuestion = true;
            }
            if(_questionsUsed.Count == _questions.Count)
            {
                _questionsUsed = [];
            }
        }
        return _questions[temp];;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"  ---  {GetRandomPrompt()}  ---  ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.Clear();
    }
    public void DisplayQuestions()
    {
        Console.Write(GetRandomQuestion());
        ShowSpinner(5);
        Console.WriteLine();
    }
}