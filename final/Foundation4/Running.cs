public class Running : Exercise
{

    public Running(DateTime date, int length, int distance)
        : base(date, length)
    {
        _date = date;
        _length = length;
        _distance = distance;
    }

}