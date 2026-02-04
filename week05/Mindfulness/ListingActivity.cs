public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int seconds, int count, List<string> prompts) : base(name, description, seconds)
    {
        _count = count;
        _prompts = prompts;
    }
    public void Run()
    {
        
    }

    public void GetRandomPrompt()
    {
        
    }

    public List<string> GetListFromUser()
    {
        return [""];
    }
}