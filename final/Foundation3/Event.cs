
public abstract class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    public Event(string title, string description, string date,
                string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string StandardDetails()
    {
        return $"{_title}, {_description}, {_date}, {_time}, {_address}";
    }

    public virtual string FullDetails()
    {
        return $"{GetType().Name}, {_title}, {_description}, {_date}, {_time}, {_address}";
    }

    public string ShortDetails()
    {
        return $"{GetType().Name}, {_title}, {_description}";
    }

}