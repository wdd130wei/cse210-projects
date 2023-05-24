public class Swimming : Exercise
{
    private int _laps;
    public Swimming (DateTime date, int length, int laps)
        : base(date, length)
    {
        _date = date;
        _length = length;
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

}