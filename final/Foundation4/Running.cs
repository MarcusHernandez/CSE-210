class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _lengthInMinutes * 60.0;
    }

    public override double GetPace()
    {
        return _lengthInMinutes / _distance;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $"- Distance {_distance:F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
