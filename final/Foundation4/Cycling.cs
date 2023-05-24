public class Cycling : Exercise
{
    public Cycling(DateTime date, int length, int distance)
        : base(date, length)
    {
        _date = date;
        _length = length;
        _distance = distance;
    }

}