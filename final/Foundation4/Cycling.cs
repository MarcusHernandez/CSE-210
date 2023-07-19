class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * _lengthInMinutes / 60.0;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60.0 / _speed;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $"- Distance {GetDistance():F1} km, Speed: {_speed:F1} kph, Pace: {GetPace():F1} min per km";
    }
}
