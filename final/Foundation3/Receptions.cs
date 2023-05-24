
public class Receptions : Event
{
    private string _email;
    public Receptions(string title, string description, string date, string time, string address, string email)
        : base (title, description,  date, time, address)
    {
        _email = email;
    }

    public override string FullDetails()
    {
        return $"{GetType().Name}, {_title}, {_description}, {_date}, {_time}, {_address}, {_email}";
    }
}