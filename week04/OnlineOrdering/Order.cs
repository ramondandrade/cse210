using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private double _shippingPrice;
    private DateTime _date;
    private double _totalPrice;

    public Order(List<Product> products, Customer customer, DateTime date)
    {
        _products = products;
        _customer = customer;
        _date = date;
        _shippingPrice = CalculateShipping();
        _totalPrice = GetTotalPrice();
    }

    public string GetOrderDateFormatted(string format = "yyyy-MM-dd")
    {
        return _date.ToString(format);
    }

    public double CalculateShipping()
    {
        return _customer.GetCountry().ToLower() == "usa" ? 5.0 : 35.0;
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.CalculateTotalCost();
        }
        return total + _shippingPrice;
    }

    public string DisplayFullOrder()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("===== Order =====\n");
        sb.AppendLine($"\nDate: {GetOrderDateFormatted()}\n");

        foreach (var product in _products)
        {
            sb.AppendLine($"Product: {product.GetName()}, Quantity: {product.GetQuantity()}, Unit Price: {product.GetPrice()}, Total: ${product.CalculateTotalCost()}");
        }
        sb.AppendLine($"\nShipping: ${_shippingPrice}");
        sb.AppendLine($"\nTotal Order Price: ${_totalPrice}");
        return sb.ToString();
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("===== Packing Label =====");
        foreach (var product in _products)
        {
            sb.AppendLine($"Product: {product.GetName()}, Quantity: {product.GetQuantity()}");
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        return $"===== Shipping Label =====\nTo: {_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
