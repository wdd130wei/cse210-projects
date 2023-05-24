using System;
public class Order
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;

    private int _shippingFee;
    string _productName;
    int _productID;
    int _productTotalPrice;

    private Customer _customer;
    private string _customerName;


    private List<Product> _products;

    public Order(string customerName, string street, string city, string province, string country)
    {
        _customerName = customerName;
        _street = street;
        _city = city;
        _province = province;
        _country = country;
        _products = new List<Product>();
        _customer = new Customer(customerName, street, city, province, country);
    }


    public string ShippingLable()
    {
        string shippingLable;
        Customer newCustomer = new Customer(_customerName, _street, _city, _province, _country);
        string customerName = newCustomer.GetCustomerName();

        Address newAddress = new Address(_street, _city, _province, _country);
        string customerAddress = newAddress.GetAddress();

        shippingLable = $"{customerName}: {customerAddress}";
        return shippingLable;
    }

    public string PackingLable()
    {   
        string packingLable = "";
        foreach (Product product in _products)
        {
            _productName = product.GetProductName();
            _productID = product.GetProductID();
            packingLable += $"{_productName} - {_productID}\n";
        }
        return packingLable;
    }
    public int ShippingCost()
    {
        if (_customer.IsInUSA())
        {
           return _shippingFee = 5;
        }
        else
        {
            return _shippingFee = 35;
        }
    }
    public int TototalCost()
    {   
        foreach (Product p in _products)
        {
            int totalPrice = p.GetTotalPrice();
            _productTotalPrice += totalPrice;
        }
        _shippingFee = ShippingCost();
        return _shippingFee + _productTotalPrice;
    }

    public void AddProduct(string productName, int productID, int price, int quantity)
    {
        _products.Add(new Product(productName, productID, price, quantity));
    }


}