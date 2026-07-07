namespace GrahicsApp;
public class Line
{

    //Association: Line has two Points - start and end
    private Point start;
    private Point end;

    public Line(Point start, Point end)
    {
        this.start = start;
        this.end = end;
    }

    public Point GetStart()
    {
        return start;
    }

    public Point GetEnd()
    {
        return end;
    }

    public void Display()
    {
        Console.WriteLine($"Line starts at ({start.GetX()}, {start.GetY()}) and ends at ({end.GetX()}, {end.GetY()})");
    }
}