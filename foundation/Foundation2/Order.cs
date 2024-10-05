class Order
{
    private Customer customer;
    private List<Product> products;

    public Order(Customer customer, List<Product> products)
    {
        this.customer = customer;
        this.products = products;
    }

    public Customer Customer => customer;
    public List<Product> Products => products;
    public decimal GetTotalCost() => products.Sum(p => p.GetTotalCost());
    public decimal GetShippingCost() => customer.IsInUSA() ? 5 : 35;
    public decimal GetTotalPrice() => GetTotalCost() + GetShippingCost();
    public string GetPackingLabel() => string.Join("\n", products.Select(p => $"{p.Name} ({p.ProductId})"));
    public string GetShippingLabel() => $"{customer.Name}\n{customer.Address}";
    
}