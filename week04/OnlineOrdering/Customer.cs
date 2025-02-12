class Customer
{
    private string _name;
    private Address _address = new Address();
    public Customer()
    {
        _name = "";
    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool IsInUSA()
    {
        return _address.IsInUsa();
    }
    public string GetCustomerName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.GetAddress();
    }

}