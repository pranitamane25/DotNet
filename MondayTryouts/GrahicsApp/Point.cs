namespace GrahicsApp;

public class Point
{
    private int x;
    private int y;


    //Constructor Overloading - multiple constructors with different parameters
    public Point()  //default constructor
    {
        x = 0;
        y = 0;
    }

    //Parameterized constructor
    public Point(int x, int y)  //constructor - special method to initialize the object
    {

        //this: refers to the current instance of the class
        this.x = x;
        this.y = y;
    }

    //getters and setters
    public int GetX()
    {
        return x;
    }
    public int GetY()
    {
        return y;
    }

    public void SetX(int x)
    {
        this.x = x;
    }

    public void SetY(int y)
    {
        this.y = y;
    }

}