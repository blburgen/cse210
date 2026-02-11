public abstract class Activity
{
    private DateOnly _date;
    private string _name;
    protected double _time;
    public Activity(double time, string name = "Activity")
    { 
        _name = name;  
        _date = DateOnly.FromDateTime(DateTime.Now);
        _time = time;
    }

    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_name} ({_time} min) - Distance: {Math.Round(GetDistance(),2)} miles, Speed: {Math.Round(GetSpeed(),2)} mph, Pace: {Math.Round(GetPace(),2)} min per mile");
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
}