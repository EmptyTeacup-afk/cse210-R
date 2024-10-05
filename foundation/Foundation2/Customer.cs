class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string name, Address address)
    {
        this._customerName = name;
        this._address = address;
    }

    public string Name => _customerName;

    public Address Address => _address;

    public bool IsInUSA() => _address.IsInUSA();
}
