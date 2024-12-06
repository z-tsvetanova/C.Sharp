namespace study6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle rect1 = new rectangle();
            rect1.X = int.Parse(Console.ReadLine());
            rect1.Y = int.Parse(Console.ReadLine());
            Console.WriteLine($" area of first rectangle = " + rect1.Area);

            rectangle rect2 = new rectangle();
            rect2.X = int.Parse(Console.ReadLine());
            rect2.Y=int.Parse(Console.ReadLine());
            Console.WriteLine($" area of second rectangle = " + rect2.Area);

            rectangle rect3 = new rectangle();
            rect3.X = int.Parse(Console.ReadLine());
            rect3.Y = int.Parse(Console.ReadLine());
            Console.WriteLine($" area of third rectangle = " + rect3.Area);
        }
    }
}
public class rectangle
{
    private int x, y;
    public rectangle()
    {
        x = 0;
        y = 0;
    }
    public rectangle(int X,int Y)
    {
        x = X;
        y = Y;
    }
    public int X
    {
        set
        {
            x = value;
        }
    }
    public int Y
    {
        set
        {
            y = value;
        }
    }
    public int Area
    {
        get
        {
            return x * y;
        }
    }
}