namespace ECommerce;

public class Cart
{
    private List<Product> products;

    public Cart()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        products.Remove(product);
    }

    public decimal GetTotalPrice()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.GetPrice() * product.GetQuantity();
        }
        return total;
    }

    public void DisplayCart()
    {
        Console.WriteLine("Shopping Cart:");
        foreach (var product in products)
        {
            product.Display();
        }
        Console.WriteLine($"Total Price: {GetTotalPrice():C}");
    }
}