
public abstract class Exercise
{
    protected DateTime _date { get; set; }
    protected double _distance;
    protected double _length;

    public Exercise(DateTime date, double length)
    {
        _date = date;
        _length = length;
    }

    public virtual double GetDistance()
    {
        return _distance;
    }

    public virtual double GetLength()
    {
        return _length;
    }
    public virtual double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60;
    }
    public virtual double GetPace()
    {
        return GetLength() / GetDistance();
    }
    public virtual string GetSummary()
    {
        string formattedDate = _date.ToString("dd MMM yyyy");
        return $"{formattedDate} {GetType().Name} ({GetLength()} min) - Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace {GetPace()} min per km";
    }
}