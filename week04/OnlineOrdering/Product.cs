class Product
{
    private string _name;
    private int _productId;
    private int _price;
    private int _quantity;

    public Product(string name, int produdctid,int price, int quantity)
    {
        _name = name;
        _productId = produdctid;
        _price = price;
        _quantity = quantity;
    }

    public int CalculateTotalPrice()
    {
        return _price * _quantity;
    }
    public string GetProductID()
    {
        return _productId.ToString();
    }
    public string GetName()
    {
        return _name;
    }
}