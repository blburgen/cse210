public class RunningActivity : Activity
{
    public RunningActivity()
    {
        
    }
    public override void GetSummary()
    {
        Console.WriteLine($"{_date} Running ({_time} min)- Distance: {_distance} miles, Speed: {_speed} mph, Pace: {_pace} min per mile");
    }
}