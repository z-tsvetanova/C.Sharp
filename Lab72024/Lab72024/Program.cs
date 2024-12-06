namespace Lab72024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RectangularArea area = RectangularArea.GetInstance;
            area.Info();
            Point p1 = new Point();
            p1.InPut();
            p1.OutPut();
        }
    }
}
sealed class RectangularArea
{
    private static int top;
    private static int bottom;
    private static int left;
    private static int right;
    private static RectangularArea instance = null;
    private RectangularArea()
    {
        top = 0;
        bottom = 1000;
        left = 0;
        right = 1000;
    }
    public static RectangularArea GetInstance
    {
        get
        {
            if (instance == null)
            {
                instance = new RectangularArea();
            }
            return instance;
        }
    }
    public int LEFT
    {
        get
        {
            return left;
        }
    }
    public int RIGHT
    {
        get
        {
            return right;
        }
    }
    public int TOP
    {
        get
        {
            return top;
        }
    }
    public int BOTTOM
    {
        get
        {
            return bottom;
        }
    }
    public void Info()
    {
        Console.WriteLine("Boundaries Top:{0}, Bottom:{1}, Left:{2}, Right:{3}", top, bottom, left, right);
    }
}
public class Point
{
    private int x;
    private int y;
    RectangularArea area = RectangularArea.GetInstance;
    public void InPut()
    {
        Console.Write("Enter x coordinate: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Enter y coordinate: ");
        y = int.Parse(Console.ReadLine());
    }
    public void OutPut()
    {
        Console.WriteLine("Point coordinates: x = {0}, y = {1}", x, y);
        area.Info();
    }
    public void Info()
    {
        try
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x < area.LEFT || x > area.RIGHT || y < area.TOP || y > area.BOTTOM) throw new Exception("not valid");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
