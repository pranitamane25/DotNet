
namespace ECommerce;

public class Product
{
    private string name;
    private decimal price;
    private int quantity;

    public Product(string name, decimal price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }

    public string GetName()
    {
        return name;
    }

    public decimal GetPrice()
    {
        return price;
    }

    public int GetQuantity()
    {
        return quantity;
    }

    public void Display()
    {
        Console.WriteLine($"Product: {name}, Price: {price:C}, Quantity: {quantity}");
    }
}
