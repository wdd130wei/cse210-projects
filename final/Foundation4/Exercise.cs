
public abstract class Exercise
{
    protected string _date;
    protected double _distance;
    protected double _length;
    protected double _speed;
    protected double _pace;

    public Exercise(string date, double length, double distance)
    {
        _date = date;
        _length = length;
        _distance = distance;
    }

    public double GetDistance()
    {
        return _distance;
    }
    public double GetSpeed()
    {
        return (_distance / _length) * 60;
    }
    public double GetPace()
    {
        return _length / _distance;
    }
    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_length} min) - Distance {_distance} km, Speed {GetSpeed()} kph, Pace {GetPace()} min per km";
    }
}