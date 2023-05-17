
public class Customer
{
    private string _customerName;
    public List<Address> _addresses;

    private Address _address;
    public Customer(string customerName, string street, string city, string province, string country)
    {
        _customerName = customerName;
        _address = new Address(street, city, province, country);
    }

    public void CreateAddress(string street, string city, string province, string country) 
    {
        
    }

    public string GetCustomerName()
    {
        return _customerName;
    }
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
}