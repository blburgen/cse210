public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity"; 
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 0;
        _count = 0;
        _prompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
    }
    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        _count = GetListFromUser().Count;
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
        Console.Clear();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int temp = random.Next(0,_prompts.Count);
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"  --- {_prompts[temp]} ---  ");
    }

    public List<string> GetListFromUser()
    {
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        List<string> temp = new List<string>();
        DateTime startItme = DateTime.Now;
        DateTime endTime = startItme.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            temp.Add(Console.ReadLine());
        }
        return temp;
    }
}