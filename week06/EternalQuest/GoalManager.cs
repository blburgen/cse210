public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = [];
        _score = 0;
        Goal goal1 = new SimpleGoal("bob", "testing goal", "50");
        _goals.Add(goal1);
        goal1 = new SimpleGoal("cat", "testing goal", "100");
        _goals.Add(goal1);
        goal1 = new SimpleGoal("lala", "testing goal", "150");
        _goals.Add(goal1);
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
            if(userOption == "1")
            {
                
            } 
            else if(userOption == "2")
            {
                ListGoalNames();
                Console.Write("Press Enter to Continue");
                Console.ReadLine();
            }
            else if(userOption == "3")
            {
                
            }
            else if(userOption == "4")
            {
                
            }
            else if(userOption == "5")
            {
                
            }
            else if(userOption == "6")
            {
                continue;
            }
            else
            {
                Console.WriteLine("Not a valid option press enter to continue");
                Console.ReadLine();
            }
        } 
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }
    public void ListGoalNames()
    {
        foreach (Goal item in _goals)
        {
            Console.WriteLine(item.GetName());
        }
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