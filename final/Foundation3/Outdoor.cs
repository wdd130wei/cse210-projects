public class OutdoorGatherings : Event
{
    private string _weather;
    public OutdoorGatherings(string title, string description, string date, string time, string address, string weather)
        : base (title, description,  date, time, address)
    {
        _weather = weather;
    }

    public override string FullDetails()
    {
        return $"{GetType().Name}, {_title}, {_description}, {_date}, {_time}, {_address}, {_weather}";
    }
}