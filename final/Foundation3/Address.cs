
public class Address
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;

    public Address(string street, string city, string province, string country)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country;
    }
    public string GetAddress()
    {
        return $"{_street}, {_city}, {_province}, {_country}";
    }
}