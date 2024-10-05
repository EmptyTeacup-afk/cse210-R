class Product
{
    private string _productName;
    private string _productId;
    private decimal _price;
    private int _quantity;
    public Product(string name, string productId, decimal price, int quantity)

    {
        this._productName = name;
        this._productId = productId;
        this._price = price;
        this._quantity = quantity;
    }

    public string Name => _productName;
    public string ProductId => _productId;
    public decimal Price => _price;
    public int Quantity => _quantity;
    public decimal GetTotalCost() => _price * _quantity;

}