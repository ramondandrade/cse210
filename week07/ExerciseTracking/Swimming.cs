
class Swimming : Activity
{
    private int _laps;
    private const double LapLengthMeters = 50.0;
    private const double MeterToMile = 0.000621371;

    public Swimming(DateTime date, double lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Calculate distance in miles
        double meters = _laps * LapLengthMeters;
        return meters * MeterToMile;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLengthMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetLengthMinutes() / GetDistance();
    }
}
