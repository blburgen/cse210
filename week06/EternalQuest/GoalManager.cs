using System.Diagnostics;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = [];
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
            if(userOption == "1")
            {
                CreateGoal();
            } 
            else if(userOption == "2")
            {
                ListGoalDetails();
            }
            else if(userOption == "3")
            {
                SaveGoals();
            }
            else if(userOption == "4")
            {
                LoadGoals();
            }
            else if(userOption == "5")
            {
                ListGoalNames();
                RecordEvent();
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
        int goalNumber = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal item in _goals)
        {
            Console.Write($"{goalNumber}. ");
            Console.WriteLine(item.GetName());
            goalNumber ++;
        }
    }
    public void ListGoalDetails()
    {
        Console.Clear();
        int goalNumber = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal item in _goals)
        {
            Console.Write($"{goalNumber}. ");
            Console.WriteLine(item.GetDetailsString());
            goalNumber ++;
        }
        Console.Write("Press Enter to Continue");
        Console.ReadLine();
    }
    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create(1-3)? ");
        string goalType = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();
        if(goalType == "1")
        {
            
            SimpleGoal goalOne = new SimpleGoal(name, description, points);
            _goals.Add(goalOne);
        }
        else if (goalType == "2")
        {
            EternalGoal goalOne = new EternalGoal(name, description, points);
            _goals.Add(goalOne);
        }
        else if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal goalOne = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(goalOne);
        }
        Console.Write("Goal Created - Press Enter to Continue");
        Console.ReadLine();
    }
    public void RecordEvent()
    {
        Console.Write("Which goal did you accomplish(number)? ");
        int eventDone = int.Parse(Console.ReadLine());
        _goals[eventDone-1].RecordEvent();
        _score += _goals[eventDone-1].GetPoints();
        Console.WriteLine($"You now have {_score} points.");
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();
    }
    public void SaveGoals()
    {
        Console.Write($"What is the filename for the goal file(saved as an .txt)?");
        string fileName = $"{Console.ReadLine()}.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal item in _goals)
            {
                if(item.GetType() == typeof(SimpleGoal))
                {
                    outputFile.WriteLine(item.GetStringRepresentation());
                }
                else if(item.GetType() == typeof(EternalGoal))
                {
                    outputFile.WriteLine(item.GetStringRepresentation());
                }
                else if(item.GetType() == typeof(ChecklistGoal))
                {
                    outputFile.WriteLine(item.GetStringRepresentation());
                }
            }
        }
    }
    public void LoadGoals()
    {
        _goals = [];
        Console.Write($"What is the filename you would like to load(must me a .txt file)?");
        string fileName = $"{Console.ReadLine()}.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("$$");
            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal goalOne = new SimpleGoal(parts[1], parts[2], parts[3]);
                if(parts[4] == "true")
                {
                    goalOne.SetIsComplete(true);
                }
                _goals.Add(goalOne);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal goalOne = new EternalGoal(parts[1], parts[2], parts[3]);
                _goals.Add(goalOne);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal goalOne = new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]));
                goalOne.SetAmountCompleted(int.Parse(parts[6]));
                _goals.Add(goalOne);
            }
            else
            {
                _score = int.Parse(parts[0]);
            }

        }
        Console.WriteLine("File loaded press enter to continue");
        Console.ReadLine();
        
    }
}