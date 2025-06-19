
using System.Collections.Generic;
using System.Globalization;

abstract class Activity
{
    private DateTime _date;
    private double _lengthMinutes;

    public Activity(DateTime date, double lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public DateTime Date => _date;
    
    public double GetLengthMinutes()
    {
        return _lengthMinutes;
    }

    public abstract double GetDistance(); // miles or km
    public abstract double GetSpeed();    // mph or kph
    public abstract double GetPace();     // min per mile or min per km

    public virtual string GetSummary()
    {
        string dateStr = _date.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
        string activityType = this.GetType().Name;
        string lengthStr = $"{_lengthMinutes} min";
        string distanceStr = GetDistance().ToString("0.0");
        string speedStr = GetSpeed().ToString("0.0");
        string paceStr = GetPace().ToString("0.00");

        string unitDistance = "miles";
        string unitSpeed = "mph";
        string unitPace = "min per mile";

        // You can change units here if you want kilometers instead.

        return $"{dateStr} {activityType} ({lengthStr}): Distance {distanceStr} {unitDistance}, Speed {speedStr} {unitSpeed}, Pace: {paceStr} {unitPace}";
    }
}