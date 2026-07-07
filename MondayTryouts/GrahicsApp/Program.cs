
namespace GrahicsApp;
public class Program{

    public static void Main(string[] args)
    {
        Point point1 = new Point(0, 0);
        Point point2 = new Point(3, 4);
        Point point3 = new Point(6, 0);

        Triangle triangle = new Triangle(point1, point2, point3);
        triangle.Display();

        Point center = new Point(5, 5);
        Circle circle = new Circle(center, 10);
        circle.Display();
         
    }
}   