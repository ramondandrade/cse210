public class Product
{
    private string _id;
    private string _name;
    private double _price;
    private double _quantity;

    public Product(string id, string name, double price, double quantity)
    {
        _id = id;
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public double CalculateTotalCost()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public double GetQuantity()
    {
        return _quantity;
    }

    public double GetPrice()
    {
        return _price;
    }

    public void SetQuantity(double quantity)
    {
        _quantity = quantity;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"Product: {_name}, ID: {_id}, Quantity: {_quantity}, Price: {_price}, Total Price: {CalculateTotalCost()}, ");
    }
}
