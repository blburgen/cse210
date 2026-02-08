public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _score = 0;
    }
    public void Start()
    {
       string userOption = "0";
        while(userOption != "6")
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu(1-6): ");
            userOption = Console.ReadLine();
        } 
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }
    public void ListGoalNames()
    {
        
    }
    public void ListGoalDetails()
    {
        
    }
    public void CreateGoal()
    {
        
    }
    public void RecordEvent()
    {
        
    }
    public void SaveGoals()
    {
        
    }
    public void LoadGoals()
    {
        
    }
}