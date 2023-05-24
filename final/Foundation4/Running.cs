public class Running : Exercise
{

    public Running(string date, int length, int distance)
        : base(date, length, distance)
    {
        _date = date;
        _length = length;
        _distance = distance;
    }

}