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
        base.RecordEvent();
    }
    public override bool IsComplete()
    {
        return base.IsComplete();
    }
    public override string GetDetailsString()
    {
        return base.GetDetailsString();
    }
    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
}