
public class Product
{
    private string _productName;
    private int _productID;
    private int _price;
    private int _quantity;

    public Product(string productName, int productID, int price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    public int GetTotalPrice()
    {
        return _price * _quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }
    public int GetProductID()
    {
        return _productID;
    }
}