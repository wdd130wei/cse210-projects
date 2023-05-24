
public class Lectures : Event
{
    private string _speaker;
    private string _capacity;
    public Lectures(string title, string description, string date, string time, string address, string speaker, string capacity)
        : base (title, description,  date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        return $"{GetType().Name}, {_title}, {_description}, {_date}, {_time}, {_address}, {_speaker}, {_capacity}";
    }
}