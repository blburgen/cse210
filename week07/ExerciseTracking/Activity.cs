public abstract class Activity
{
    protected DateOnly _date;
    protected double _time;
    protected double _distance;
    protected double _speed;
    protected double _pace;
    public Activity()
    {
        _date = DateOnly.FromDateTime(DateTime.Now);
        _time = 1;
        _distance = 1;
        _speed = _distance / _time  * 60;
        _pace = _time / _distance;
    }
    public DateOnly GetStartDate()
    {
        Console.WriteLine(_date);
        return _date; 
    }
    public abstract void GetSummary();
}