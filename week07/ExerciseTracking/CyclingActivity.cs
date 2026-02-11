public class CyclingActivity : Activity
{
    private double _cyclespeed;
    public CyclingActivity(double time, double speed) : base(time, "Cycling")
    {
        _cyclespeed = speed;
    }
    public override double GetDistance()
    {
        return _cyclespeed * _time / 60;
    }
    public override double GetSpeed()
    {
        return _cyclespeed;
    }
    public override double GetPace()
    {
        return 60 / _cyclespeed;   
    }
}