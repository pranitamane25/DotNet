namespace GrahicsApp;
public class Circle
{
    private Point center;
    private int radius;

    public Circle(Point center, int radius)
    {
        this.center = center;
        this.radius = radius;
    }

    public Point GetCenter()
    {
        return center;
    }

    public int GetRadius()
    {
        return radius;
    }

    public void Display()
    {
        Console.WriteLine($"Circle with center at ({center.GetX()}, {center.GetY()}) and radius {radius}");
    }
}