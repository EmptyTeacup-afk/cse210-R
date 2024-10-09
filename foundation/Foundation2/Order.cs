class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        this._customer = customer;
        this._products = products;
    }

    public Customer Customer => _customer;
    public List<Product> Products => _products;
    public decimal GetTotalCost() => _products.Sum(p => p.GetTotalCost());
    public decimal GetShippingCost() => _customer.IsInUSA() ? 5 : 35;
    public decimal GetTotalPrice() => GetTotalCost() + GetShippingCost();
    public string GetPackingLabel() => string.Join("\n", _products.Select(p => $"{p.Name} ({p.ProductId})"));
    public string GetShippingLabel() => $"{_customer.Name}\n{_customer.Address}";
    
}