public class Running : Activity
{
    private double _distance;

    public Running(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override double GetPace()
    {
        return _length/_distance;
    }
    public override string GetSummary()
    {
        return $"{_date} Running ({_length} min) - Distance: {_distance} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}