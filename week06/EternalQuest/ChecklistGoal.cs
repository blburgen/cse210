public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public override void RecordEvent()
    {
        _amountCompleted ++;
        if (_target - _amountCompleted == 0)
        {
            int temp = int.Parse(_points) + _bonus;
            Console.WriteLine($"Congratulations! You have earned {temp} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }
    }
    public override bool IsComplete()
    {
        return _target - _amountCompleted <= 0;
    }
    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal$${_shortName}$${_description}$${_points}$${_target}$${_bonus}$${_amountCompleted}";
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    public override int GetPoints()
    {
        if (_target - _amountCompleted == 0)
        {
            return int.Parse(_points) + _bonus;
        }
        else
        {
            return int.Parse(_points);
        }

    }
}