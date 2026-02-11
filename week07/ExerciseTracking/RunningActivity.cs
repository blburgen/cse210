public class RunningActivity : Activity
{
    private double _distance;
    public RunningActivity(double time, double distance) : base(time,"Running")
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / _time * 60;
    }
    public override double GetPace()
    {
        return _time / _distance;   
    }
}