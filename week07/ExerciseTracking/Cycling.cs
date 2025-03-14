public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (_length / 60);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60/_speed;
    }
    public override string GetSummary()
    {
        return $"{_date} Cycling ({_length} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}