public class SwimmingActivity : Activity
{
    public SwimmingActivity()
    {
        
    }
    public override void GetSummary()
    {
        Console.WriteLine($"{_date} Running ({_time})- Distance: {_distance}, Speed: {_speed} mph, Pace: {_pace} min per mile");
    }
}